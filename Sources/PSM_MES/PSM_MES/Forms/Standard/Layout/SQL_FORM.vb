Imports System.Text.RegularExpressions
Public Class SQL_FORM

#Region "Variable"
    Private Dsu01 As Long
    Private Form_Close As Boolean
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()
        SPR_SET(vS1, 1, , , OperationMode.SingleSelect, True)
    End Sub

    Private Sub DATA_INIT()

    End Sub

#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        Dim RS01 As DataRow = Nothing

        vS1.Enabled = False

        DATA_SEARCH01 = False

        Try
            If rad_Prod.Checked = True Then
                SQL = "SELECT  name, type_desc, create_date, modify_date FROM sys.procedures WHERE type='P' and name like N'%" & txt_Name.Data _
                    & "%' and name not like N'%SPREAD%' and name not like N'%PFP9%'  and name not like N'sp_%'  and name not like N'%PFP7%' and name not like N'%PFP8%'  " & "" _
                    & " and  name not like N'%HLP9%' and name not like N'%ISUD9%' and name not like N'%HLP7%' and name not like N'%ISUD7%' and name not like N'%HLP8%' and name not like N'%ISUD8%' " & "" _
                    & " ORDER BY  name "
            ElseIf rad_Function.Checked = True Then
                SQL = "SELECT  name, type_desc, create_date, modify_date FROM sys.objects WHERE type='FN' and name like N'%" & txt_Name.Data _
                    & "%' ORDER BY  name "
            ElseIf rad_Trigger.Checked = True Then
                SQL = "SELECT  name, type_desc, create_date, modify_date FROM sys.triggers WHERE name like N'%" & txt_Name.Data _
                    & "%' ORDER BY  name "
            End If

            DS1 = SqlDS(SQL, cn)
            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "SQLProc", "Vs1")
                vS1.Enabled = True
                txt_SQLDetail.Text = ""
                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "SQLProc", "Vs1")
            txt_SQLDetail.Text = ""
        Catch ex As Exception

        End Try

        DATA_SEARCH01 = True

        vS1.Enabled = True

    End Function

#End Region

#Region "Event"
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH01()
    End Sub

#End Region

    Private Sub vS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellDoubleClick

        Try
            Dim i As Integer
            Dim zname = getData(vS1, getColumnIndex(vS1, "name"), vS1.ActiveSheet.ActiveRowIndex)
            Dim tempStr As String = "SET ANSI_NULLS ON " & Environment.NewLine & "GO " & Environment.NewLine & "SET QUOTED_IDENTIFIER ON " & Environment.NewLine & "GO " & Environment.NewLine

            If zname <> "" Then
                SQL = "SELECT object_definition(object_id) AS Proc_Definition FROM sys.objects where NAME ='" & zname & "'"
                DS1 = SqlDS(SQL, cn)
                i = 0
                For Each RS01 As DataRow In DS1.Tables(0).Rows
                    i = i + 1
                    If i = 1 Then
                        txt_SQLDetail.Text = tempStr & Replace(RS01!Proc_Definition, "CREATE", "ALTER")
                    End If
                Next

            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub btn_Executive_Click(sender As Object, e As EventArgs) Handles btn_Executive.Click
        vS2.Enabled = False
        Dim sqlTmp As String = ""
        Dim tmp As String = ""

        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")
        Try
            SQL = txt_SQLDetail.SelectedText

            If SQL = "" Then
                tmp = txt_SQLDetail.Text
                Dim str As IEnumerable = Regex.Split(tmp, "^\s*GO\s*$", RegexOptions.Multiline)

                For Each commandString As String In str
                    If commandString.Trim() <> "" Then
                        cmd = New SqlClient.SqlCommand(commandString, cn)
                        cmd.ExecuteNonQuery()
                    End If
                Next
                SPR_SET(vS2, , , 0, OperationMode.Normal)
            Else

                DS1 = PrcDS(SQL, cn, Nothing)

                Dim ProgramName As String
                Dim SheetName As String
                Dim IndexX As Integer
                Dim IndexY1 As Integer
                Dim IndexY2 As Integer

                IndexX = SQL.IndexOf("'")
                ProgramName = Strings.Left(SQL, IndexX)
                ProgramName = ProgramName.Replace("[", "").Replace("]", "").Replace(" ", "")

                IndexX = ProgramName.ToUpper.IndexOf("VS")
                IndexY1 = ProgramName.ToUpper.IndexOf("_", IndexX - 2)
                IndexY2 = ProgramName.ToUpper.IndexOf("_", IndexX)

                If IndexY2 > 0 Then
                    SheetName = Strings.Mid(SQL, IndexX, IndexY2 - IndexX)
                Else
                    SheetName = Strings.Right(ProgramName, Len(ProgramName) - IndexX)
                End If

                If GetDsRc(DS1) = 0 Then
                    SPR_SET(vS2, , , , OperationMode.Normal)
                    SPR_PRO(vS2, DS1, ProgramName, SheetName)
                    vS2.Enabled = True

                    Exit Sub
                End If

                SPR_SET(vS2, , , , OperationMode.Normal)
                SPR_PRO(vS2, DS1, ProgramName, SheetName)
            End If

        Catch ex As Exception
        Finally
            vS2.Enabled = True
            Starting.Close()
        End Try
        
    End Sub

    Private Sub txt_SQLDetail_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SQLDetail.KeyDown
        If e.KeyCode = Keys.F5 Then
            btn_Executive.PerformClick()
        End If
    End Sub
End Class