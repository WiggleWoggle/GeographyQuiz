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
