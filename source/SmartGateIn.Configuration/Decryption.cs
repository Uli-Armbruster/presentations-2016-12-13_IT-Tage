using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

using Newtonsoft.Json;

using SmartGateIn.Contracts.Common;

namespace SmartGateIn.Configuration
{
    internal class Decryption
    {
        public Config Decrypt(string content, string password)
        {
            try
            {
                var bytesToBeDecrypted = Convert.FromBase64String(content);
                var passwordBytes = Encoding.UTF8.GetBytes(password);
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

                var bytesDecrypted = AesDecrypt(bytesToBeDecrypted, passwordBytes);

                var decryptedString = Encoding.UTF8.GetString(bytesDecrypted);

                var config = JsonConvert.DeserializeObject<Config>(decryptedString);
                return config;
            }
            catch (Exception ex)
            {
                throw new InvalidDataException("Decryption failed", ex);
            }
        }

        private static byte[] AesDecrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);

                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }
    }
}
