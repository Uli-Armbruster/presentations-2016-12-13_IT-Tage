using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SmartGateIn.Configuration
{
    internal class Encryption
    {
        public static string Encrypt(string serializedConfig, string encryptionPassword)
        {
            try
            {
                var bytesToBeEncrypted = Encoding.UTF8.GetBytes(serializedConfig);
                var passwordBytes = Encoding.UTF8.GetBytes(encryptionPassword);

                // Hash the password with SHA256
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

                var bytesEncrypted = AesEncrypt(bytesToBeEncrypted, passwordBytes);

                var result = Convert.ToBase64String(bytesEncrypted);

                return result;
            }
            catch (Exception ex)
            {
                
                throw new InvalidDataException("Encryption failed", ex);
            }
        }

        private static byte[] AesEncrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = {1, 2, 3, 4, 5, 6, 7, 8};

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    aes.Key = key.GetBytes(aes.KeySize/8);
                    aes.IV = key.GetBytes(aes.BlockSize/8);

                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }
    }
}