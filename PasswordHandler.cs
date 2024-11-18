using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class PasswordHandler
    {

        //Encryption and decryption
        public static String encryptPassword(String password)
        {

            String sha256Step = SHA256Hash(password);
            String base64Step = base64Encrypt(sha256Step);

            return base64Step;
        }

        public static Boolean decryptPassword(String password, String encrypted)
        {
            String base64Step = base64Decrypt(encrypted);

            if (compareHashes(password, base64Step))
            {
                return true;
            }

            return false;
        }

        //Base 64 Encryption
        public static String base64Encrypt(String hashed)
        {
            return "";
        }

        public static String base64Decrypt(String base64)
        {
            return "";
        }

        //SHA256 Encryption
        public static String SHA256Hash(String password)
        {

            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                stringBuilder.Append(bytes[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        public static Boolean compareHashes(String inputPassword, String registeredHash)
        {
            if (SHA256Hash(inputPassword).Equals(registeredHash))
            {
                return true;
            }

            return false;
        }
    }
}
