using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace FAS_Tool
{
    class Crypto
    {

        // A guide to finding this key is provided in the Wiki section of the GitHub repo.
        // It's included in the obfuscated release. <-- Only download from trusted sources.

        public static string secretKey = "PRETTY_SURE_IM_NOT_ALLOWED_TO_INCLUDE_THIS_SO_FIND_IT_YOURSELF";

        #region Encrypt Save
        public static string Encrypt(string plainText) {

            try {

                string password = secretKey;
                DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
                cryptoServiceProvider.GenerateIV();
                byte[] bytes1 = new Rfc2898DeriveBytes(password, cryptoServiceProvider.IV, 1000).GetBytes(8);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoServiceProvider.CreateEncryptor(bytes1, cryptoServiceProvider.IV), CryptoStreamMode.Write))
                    {
                        memoryStream.Write(cryptoServiceProvider.IV, 0, cryptoServiceProvider.IV.Length);
                        byte[] bytes2 = Encoding.UTF8.GetBytes(plainText);
                        cryptoStream.Write(bytes2, 0, bytes2.Length);
                        cryptoStream.FlushFinalBlock();
                        string encryptedSave = Convert.ToBase64String(memoryStream.ToArray());
                        return encryptedSave;
                    }
                }

            } catch(Exception ex)
            {
                return ex.Message;
            }
            
        }
        #endregion

        #region Decrypt Save

        public static string Decrypt(string cipherText)
        {
            string password = secretKey;
            if (!string.IsNullOrEmpty(cipherText))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    try
                    {
                        using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cipherText)))
                        {
                            DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
                            byte[] numArray = new byte[8];
                            memoryStream.Read(numArray, 0, numArray.Length);
                            byte[] bytes = new Rfc2898DeriveBytes(password, numArray, 1000).GetBytes(8);
                            using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoServiceProvider.CreateDecryptor(bytes, numArray), CryptoStreamMode.Read))
                            {
                                using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                                {
                                    string decryptedSave = streamReader.ReadToEnd();
                                    return decryptedSave;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                }
            }
            return "Save decryption failed for some reason.";
        }

        #endregion

    }
}
