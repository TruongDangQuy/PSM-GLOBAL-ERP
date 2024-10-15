using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;

class Program
{
    static NotifyIcon notifyIcon;

    static void Main(string[] args)
    {
        KillPro();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        notifyIcon = new System.Windows.Forms.NotifyIcon()
        {       
            BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
            BalloonTipText = "PSM Synchronization",
            BalloonTipTitle = "PSM Global",
            Icon = PSMSyncData.Properties.Resources.Icon,
            Visible = true,
            Text = "PSM Global",
            ContextMenu = new ContextMenu(new MenuItem[] {
                  new MenuItem("Sync Now", SyncNow),
                  new MenuItem("Exit", Exit)
            })
        };

        var timer = new System.Threading.Timer(SyncData, null, TimeSpan.Zero, TimeSpan.FromMinutes(60));

        AddApplicationToStartup();

        Application.Run();
    }
         private static void AddApplicationToStartup()
    {
        try
        {
            string exePath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            string appName = System.Reflection.MethodBase.GetCurrentMethod().Name; 
          
            using (Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
        {
            if (registryKey.GetValue(appName) == null)
            {
                registryKey.SetValue(appName, exePath);
              
            }
        }
         
        }
        catch    {    }
    }

    private static void KillPro()
    {
        try
        {
            foreach (System.Diagnostics.Process prog in System.Diagnostics.Process.GetProcesses())
            {
                if (prog.ProcessName == System.Reflection.MethodBase.GetCurrentMethod().Name)
                {
                    prog.Kill();
                }
            }
        }
        catch { }
    }

  private static void SyncData(object state)
  {
      string encryptedSourceConnectionString = "8Ahhp9/r97wMMECZd45GFKgSAnqMKYRC/I4JZyseqGV3u59uF5fJEJa1+GJRyrVC1zhcMtIBFaxgKI7jWMke7OYCr7CpkzQPoMXVjTgXa5Y=";
      string encryptedDestinationConnectionString = "TadBOOVDcdKwxrHkxNma5wg4sspoeAm44wQURgvhYR7XsOHUrEFwZmNpBOCpII8rfSXirs5VGZ3W7Jc8NOZ97oHZwfFK+H/dEDKhawL1PSOvsLpt1KbNjIvPs7z+1z2o";

      string sourceConnectionString = AesEncryption.DecryptString(encryptedSourceConnectionString);
      string destinationConnectionString = AesEncryption.DecryptString(encryptedDestinationConnectionString);

      using (SqlConnection sourceConnection = new SqlConnection(sourceConnectionString))
      using (SqlConnection destinationConnection = new SqlConnection(destinationConnectionString))
      {
          try
          {
              sourceConnection.Open();
              destinationConnection.Open();

              var tables = GetTables(destinationConnection);
              string List_Table = string.Empty;
              string List_Table_His = string.Empty;
              foreach (var table in tables)
              {
                  var rowCount = SyncTable(table.TableName, table.SQLWhere, sourceConnection, destinationConnection);
                  List_Table += table.TableName + ":" + rowCount + "; ";
                  List_Table_His += table.TableName + (string.IsNullOrWhiteSpace(table.SQLWhere) ? "" : "-" + table.SQLWhere) + ":" + rowCount + "; ";
              }

              LogSyncHistory(destinationConnection, "Success", List_Table_His);
              ShowNotification(List_Table);
          }
          catch (Exception ex)
          {
              LogSyncHistory(destinationConnection, "Failure", ex.Message);
              notifyIcon.ShowBalloonTip(1000, "Data Synchronization", "An error occurred: " + ex.Message, ToolTipIcon.Error);
          }
      }
  }


  private static List<TableInfo> GetTables(SqlConnection connection)
  {
      var tables = new List<TableInfo>();
      var query = "SELECT TableName, SQLWhere FROM PSMSyncTable WHERE CheckSync = 1 ORDER BY Seq ASC";

      using (var command = new SqlCommand(query, connection))
      using (var reader = command.ExecuteReader())
      {
          while (reader.Read())
          {
              tables.Add(new TableInfo
              {
                  TableName = reader.GetString(0),
                  SQLWhere = reader.IsDBNull(1) ? string.Empty : reader.GetString(1)
              });
          }
      }
      return tables;
  }

  private static int SyncTable(string tableName, string sqlWhere, SqlConnection sourceConnection, SqlConnection destinationConnection)
  {
    
        var primaryKey = GetPrimaryKey(tableName, sourceConnection);
        if (primaryKey == null)
        {
            CopyEntireTable(tableName, sqlWhere, sourceConnection, destinationConnection);
            return -1;
        }
                                    
        var sourceData = GetDataTable("SELECT * FROM " + tableName + " " + (string.IsNullOrWhiteSpace(sqlWhere) ? "" : sqlWhere), sourceConnection);
        var destinationData = GetDataTable("SELECT * FROM " + tableName + " " + (string.IsNullOrWhiteSpace(sqlWhere) ? "" : sqlWhere), destinationConnection);

        int rowCount = 0;

        foreach (DataRow sourceRow in sourceData.Rows)
        {
            var key = sourceRow[primaryKey];
            var destinationRow = destinationData.AsEnumerable().FirstOrDefault(row => row[primaryKey].Equals(key));

            if (destinationRow != null)
            {
                var updateQuery = BuildUpdateQuery(tableName, sourceRow, primaryKey);
                ExecuteNonQuery(updateQuery, destinationConnection, sourceRow);
            }
            else
            {
                bool isIdentity = IsIdentityColumn(tableName, primaryKey, sourceConnection);
                if (isIdentity)
                {
                    ExecuteNonQuery("SET IDENTITY_INSERT " + tableName + " ON", destinationConnection);
                }

                var insertQuery = BuildInsertQuery(tableName, sourceRow);
                ExecuteNonQuery(insertQuery, destinationConnection, sourceRow);

                if (isIdentity)
                {
                    ExecuteNonQuery("SET IDENTITY_INSERT " + tableName + " OFF", destinationConnection);
                }
            }
            rowCount++;
        }

        return rowCount;
    }
    private static void CopyEntireTable(string tableName, string sqlWhere,SqlConnection sourceConnection, SqlConnection destinationConnection)
    {
        var sourceData = GetDataTable("SELECT * FROM " + tableName, sourceConnection);

        ExecuteNonQuery("DELETE FROM " + tableName, destinationConnection);

        foreach (DataRow sourceRow in sourceData.Rows)
        {
            var insertQuery = BuildInsertQuery(tableName, sourceRow);
            ExecuteNonQuery(insertQuery, destinationConnection, sourceRow);
        }
    }
    private static bool IsIdentityColumn(string tableName, string columnName, SqlConnection connection)
    {
        var query = @"
            SELECT COLUMNPROPERTY(OBJECT_ID(@TableName), @ColumnName, 'IsIdentity')";

        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@TableName", tableName);
            command.Parameters.AddWithValue("@ColumnName", columnName);
            return Convert.ToBoolean(command.ExecuteScalar());
        }
    }

    private static string GetPrimaryKey(string tableName, SqlConnection connection)
    {
        var query = @"
            SELECT COLUMN_NAME
            FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
            WHERE TABLE_NAME = @TableName
            AND OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_NAME), 'IsPrimaryKey') = 1";

        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@TableName", tableName);
            return command.ExecuteScalar() as string;
        }
    }

    private static DataTable GetDataTable(string query, SqlConnection connection)
    {
        using (var command = new SqlCommand(query, connection))
        using (var adapter = new SqlDataAdapter(command))
        {
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }

    private static void ExecuteNonQuery(string query, SqlConnection connection, DataRow dataRow = null)
    {
        using (var command = new SqlCommand(query, connection))
        {
            if (dataRow != null)
            {
                foreach (DataColumn column in dataRow.Table.Columns)
                {
                    command.Parameters.AddWithValue("@" + column.ColumnName, dataRow[column]);
                }
            }
            command.ExecuteNonQuery();
        }
    }

    private static string BuildUpdateQuery(string tableName, DataRow row, string primaryKey)
    {
        var setClause = new StringBuilder();

        foreach (DataColumn column in row.Table.Columns)
        {
            if (column.ColumnName != primaryKey)
            {
                if (setClause.Length > 0)
                {
                    setClause.Append(", ");
                }
                setClause.Append(column.ColumnName + " = @" + column.ColumnName);
            }
        }

        return "UPDATE " + tableName + " SET " + setClause + " WHERE " + primaryKey + " = @" + primaryKey;
    }

    private static string BuildInsertQuery(string tableName, DataRow row)
    {
        var columns = string.Join(", ", row.Table.Columns.Cast<DataColumn>().Select(col => col.ColumnName));
        var values = string.Join(", ", row.Table.Columns.Cast<DataColumn>().Select(col => "@" + col.ColumnName));

        return "INSERT INTO " + tableName + " (" + columns + ") VALUES (" + values + ")";
    }

    private static void LogSyncHistory(SqlConnection connection, string status, string details)
    {
        var query = "INSERT INTO PSMSyncTable_His (SyncStatus, SyncDetails, ComputerName, UserName) VALUES (@SyncStatus, @SyncDetails, @ComputerName, @UserName)";

        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@SyncStatus", status);
            command.Parameters.AddWithValue("@SyncDetails", details);
            command.Parameters.AddWithValue("@ComputerName", Environment.MachineName);
            command.Parameters.AddWithValue("@UserName", Environment.UserName);
            command.ExecuteNonQuery();
        }
    }



    private static void ShowNotification(string ListtableName)
    {
        string message = string.Format("List synchronized: {1} - {0}", DateTime.Now, ListtableName);
        notifyIcon.ShowBalloonTip(1000, "Data Synchronization", message, ToolTipIcon.Info);
    }
  
    private static void Exit(object sender, EventArgs e)
    {
        notifyIcon.Dispose();
        Application.Exit();
    }

    private static void SyncNow(object sender, EventArgs e)
    {
        SyncData(null);
    }

}

public class TableInfo
{
    public string TableName { get; set; }
    public string SQLWhere { get; set; }
}

public static class AesEncryption
{
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("A1234567890B1234A1234567890B1234");
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("1234567890ABCDEF"); 

    public static string DecryptString(string cipherText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
            {
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
        }
    }
}
