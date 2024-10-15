using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class AesEncryption
{
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("A1234567890B1234A1234567890B1234"); // 32 bytes for AES-256
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("1234567890ABCDEF"); // 16 bytes for AES

    public static string EncryptString(string plainText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                }
                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }

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

class Program
{
    static void Main(string[] args)
    {
        string sourceConnectionString = "Data Source=.;Initial Catalog=ECUS5VNACCS;User ID=CS_ECUS;Password=CS_ECUS@2024";
        string destinationConnectionString = "Data Source=61.28.231.43,14330;Initial Catalog=CS_ECUS;User ID=CS_WHM;Password=CS_WHM@2024";

        // Mã hóa các chuỗi kết nối
        string encryptedSourceConnectionString = AesEncryption.EncryptString(sourceConnectionString);
        string encryptedDestinationConnectionString = AesEncryption.EncryptString(destinationConnectionString);

        Console.WriteLine("Encrypted Source Connection String: " + encryptedSourceConnectionString);
        Console.WriteLine("Encrypted Destination Connection String: " + encryptedDestinationConnectionString);

        // Giải mã các chuỗi kết nối để kiểm tra
        string decryptedSourceConnectionString = AesEncryption.DecryptString(encryptedSourceConnectionString);
        string decryptedDestinationConnectionString = AesEncryption.DecryptString(encryptedDestinationConnectionString);

        Console.WriteLine("Decrypted Source Connection String: " + decryptedSourceConnectionString);
        Console.WriteLine("Decrypted Destination Connection String: " + decryptedDestinationConnectionString);

        // Dừng lại để hiển thị kết quả
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
