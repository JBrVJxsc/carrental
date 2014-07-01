using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CarRentalLoader.Class.Managers
{
    public class EncryptionManager
    {
        public static readonly string IV = "SuFjcEmp/TE=";
        public static readonly string Key = "KIPSToILGp6fl+3gXJvMsN4IajizYBBT";

        private static TripleDESCryptoServiceProvider GetCryptoProvider()
        {
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
            provider.IV = Convert.FromBase64String(IV);
            provider.Key = Convert.FromBase64String(Key);
            return provider;
        }

        public static string Encrypt(string text)
        {
            TripleDESCryptoServiceProvider provider = GetCryptoProvider();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, provider.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] toEncrypt = new UTF8Encoding().GetBytes(text);
            cStream.Write(toEncrypt, 0, toEncrypt.Length);
            cStream.FlushFinalBlock();
            byte[] ret = mStream.ToArray();
            cStream.Close();
            mStream.Close();
            return Convert.ToBase64String(ret);
        }

        public static string Decrypt(string text)
        {
            TripleDESCryptoServiceProvider provider = GetCryptoProvider();
            byte[] inputEquivalent = Convert.FromBase64String(text);
            MemoryStream msDecrypt = new MemoryStream();
            CryptoStream csDecrypt = new CryptoStream(msDecrypt,
            provider.CreateDecryptor(),
            CryptoStreamMode.Write);
            csDecrypt.Write(inputEquivalent, 0, inputEquivalent.Length);
            csDecrypt.FlushFinalBlock();
            csDecrypt.Close();
            return new UTF8Encoding().GetString(msDecrypt.ToArray());
        }
    }
}
