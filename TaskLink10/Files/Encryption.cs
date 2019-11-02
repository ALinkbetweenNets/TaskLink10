using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskLink10Server
{
    public partial class FormServer : Form
    {
        /// <summary>
        /// Session password used for Communication. Should never be clear text (-> use SHA-256).
        /// Must be equal on all devices
        /// </summary>
        private string SessionPassword = string.Empty;

        /// <summary>
        /// size of the IV in bytes = keysize / 8
        /// Default 256 -> IV = 32 bytes
        /// Using 16 character string -> 32 bytes when converted to a byte array
        /// </summary>
        private static readonly string initVector = "pemgail9uzpgzl88";

        /// <summary>
        /// used to determine the keysize of the encryption algorithm
        /// AES standard keysize is 256
        /// </summary>
        private const ushort keysize = 256;

        public UTF8Encoding utf8 = new UTF8Encoding();

        /// <summary>
        /// Encrypts given string with AES using passphrase and initVector
        /// </summary>
        /// <param name="plainText">string to Encrypt</param>
        /// <param name="passPhrase">Passphrase to use in Combination with initVector</param>
        /// <returns>Encrypted string</returns>
        public string EncryptString(string plainText)
        {
            Log("Encrypting: " + plainText);
            Log("With Password: " + SessionPassword);
            Log("Using initVector: " + initVector);

            byte[] initVectorBytes = utf8.GetBytes(initVector);
            byte[] plainTextBytes = utf8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(SessionPassword, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            using (AesCryptoServiceProvider symmetricKey = new AesCryptoServiceProvider
            {
                Mode = CipherMode.CBC
            })
            {
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                cryptoStream.Close();
                memoryStream.Close();
                password.Dispose();
                symmetricKey.Clear();
                return Convert.ToBase64String(cipherTextBytes);
            }
        }

        /// <summary>
        /// Decrypts given string with AES using passphrase and initVector
        /// </summary>
        /// <param name="cipherText">string to Decrypt</param>
        /// <param name="passPhrase">Passphrase to use in Combination with initVector</param>
        /// <returns>Decrypted string</returns>
        public string DecryptString(string cipherText)
        {
            Log("Decrypting: " + cipherText);
            Log("With Password: " + SessionPassword);
            byte[] initVectorBytes = utf8.GetBytes(initVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(SessionPassword, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            using (AesCryptoServiceProvider symmetricKey = new AesCryptoServiceProvider
            {
                Mode = CipherMode.CBC
            })
            {
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.Close();
                memoryStream.Close();
                password.Dispose();
                symmetricKey.Clear();
                return utf8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
        }


        /// <summary>
        /// Checks if DateTime.Today Object given by System is accurate and returns if that is the case
        /// </summary>
        /// <returns></returns>
        private DateTime GetDateTime()
        {
            //Log(Convert.ToByte(2019).ToString());
            //Log(Convert.ToByte(11).ToString());
            try
            {
                Log("Getting Date...");
                DateTime date = DateTime.Today;
                if (date.Year > 2019)
                {
                    Log("DateTime is correct");
                    Application.Exit();
                    Environment.Exit(1);
                }
                return date;
            }
            catch (Exception ex)
            {
                Log(ex);
                return DateTime.Today;
            }
        }

        /// <summary>
        /// Calculates SHA-256 Hash Sum of given string
        /// </summary>
        /// <param name="text">text to calculate the Hash of</param>
        /// <returns>Calculated SHA-256 Hash</returns>
        public string GetHashSha256(string text)
        {
            byte[] textBytes = utf8.GetBytes(text);
            using (SHA256Managed hashstring = new SHA256Managed())
            {
                byte[] hash = hashstring.ComputeHash(textBytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte x in hash)
                {
                    builder.Append(string.Format(@"{0:x2}", x));
                }
                string encodedString = builder.ToString();
                Log("Encrypted: " + text + " to SHA-256 Hash: " + encodedString);
                return encodedString;
            }
        }














    }
}
