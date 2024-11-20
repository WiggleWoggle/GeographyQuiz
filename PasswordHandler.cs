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

            //convert the password to a base64 value first
            String base64Step = base64Encrypt(password);

            //convert the base64 value to a sha256 encrypted value
            String sha256Step = SHA256Hash(base64Step);

            return sha256Step;
        }

        public static Boolean decryptPassword(String password, String encrypted)
        {
            //convert the attempt password to a base64 value first
            String base64Step = base64Encrypt(password);

            //convert the base64 value to a sha256 encrypted value
            String sha256Step = SHA256Hash(base64Step);

            //see if repeating the process gave us the same value as the target value
            if (encrypted.Equals(sha256Step))
            {
                return true;
            }

            return false;
        }

        //Base 64 Encryption
        public static String base64Encrypt(String hashed)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(hashed);

            return System.Convert.ToBase64String(plainTextBytes);
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
    }
}
