using System;

namespace common
{
    class aes
    {
        public static byte[] AES_Encrypt(string input, string pass)
        {
            System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
            System.Security.Cryptography.MD5CryptoServiceProvider Hash_AES = new System.Security.Cryptography.MD5CryptoServiceProvider();
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = System.Security.Cryptography.CipherMode.ECB;
                System.Security.Cryptography.ICryptoTransform DESEncrypter = AES.CreateEncryptor();
                byte[] Buffer = System.Text.ASCIIEncoding.ASCII.GetBytes(input);
                return DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string AES_Decrypt(byte[] input, string pass)
        {
            System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
            System.Security.Cryptography.MD5CryptoServiceProvider Hash_AES = new System.Security.Cryptography.MD5CryptoServiceProvider();
            string decrypted = "";
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = System.Security.Cryptography.CipherMode.ECB;
                System.Security.Cryptography.ICryptoTransform DESDecrypter = AES.CreateDecryptor();
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(input, 0, input.Length));
                return decrypted;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}