using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace defaultwinform
{
    internal class PasswordHandler
    {

        public static String passwordIssue = "";
        public static String usernameIssue = "";

        public static Boolean validPassword(String password)
        {
            if (minCharacters(password, 8))
            {
                if (maxCharacters(password, 20))
                {
                    if (containsLetters(password))
                    {
                        if (containsSymbols(password))
                        {
                            if (containsNumbers(password))
                            {
                                if (noSpaces(password))
                                {
                                    return true;
                                }
                                else
                                {
                                    passwordIssue = "Your password can't have spaces!";
                                }
                            }
                            else
                            {
                                passwordIssue = "Your password needs to be at least 1 number!";
                            }
                        }
                        else
                        {
                            passwordIssue = "Your password needs to contain at least 1 symbol!";
                        }
                    }
                    else
                    {
                        passwordIssue = "Your password must contain a letter!";
                    }
                }
                else
                {
                    passwordIssue = "Your password can't be over 20 characters!";
                }
            } else
            {
                passwordIssue = "Your password needs to be at least 8 characters!";
            }

            return false;
        }

        public static Boolean validUsername(String username)
        {
            if (minCharacters(username, 5))
            {
                if (maxCharacters(username, 20))
                {
                    if (containsLetters(username))
                    {
                        if (noSpaces(username))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static Boolean containsLetters(String field)
        {

            if (Regex.IsMatch(field, ".*?[a-zA-Z].*?"))
            {
                return true;
            }

            return false;
        }

            public static Boolean noSpaces(String password)
        {
            if (password.Contains(" "))
            {
                return false;
            }

            return true;
        }

        public static Boolean containsSymbols(String password)
        {
            if (password.Contains("~") || password.Contains("!") || password.Contains("@") || password.Contains("#") || password.Contains("$") || password.Contains("%") || password.Contains("^") || password.Contains("&") || password.Contains("*") || password.Contains("(") || password.Contains(")") || password.Contains("_") || password.Contains("+") || password.Contains("=") || password.Contains("{") || password.Contains("}") || password.Contains("[") || password.Contains("]") || password.Contains("/") || password.Contains("<") || password.Contains(">") || password.Contains("?"))
            {

                return true;
            }

            return false;
        }

        public static Boolean containsNumbers(String password)
        {
            if (password.Contains("1") || password.Contains("2") || password.Contains("3") || password.Contains("4") || password.Contains("5") || password.Contains("6") || password.Contains("7") || password.Contains("8") || password.Contains("9") || password.Contains("0"))
            {
                return true;
            }

            return false;
        }

        public static Boolean minCharacters(String field, int min)
        {

            if (field.Length >= min)
            {
                return true;
            }

            return false;
        }

        public static Boolean maxCharacters(String field, int max)
        {
            if (field.Length <= max)
            {
                return true;
            }

            return false;
        }

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
