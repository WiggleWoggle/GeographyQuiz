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

        public static Boolean validName(String name)
        {
            if (minCharacters(name, 2))
            {
                if (maxCharacters(name, 20))
                {
                    if (containsLetters(name))
                    {
                        if (noSpaces(name))
                        {
                            return true;
                        }
                    }
                }
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
                        } else
                        {
                            usernameIssue = "Your username cannot contain spaces!";
                        }
                    }
                    else
                    {
                        usernameIssue = "Your username must contain letters!";
                    }
                }
                else
                {
                    usernameIssue = "Your username can't be over 20 characters!";
                }
            }
            else
            {
                usernameIssue = "Your username must be at least 8 characters!";
            }

            return false;
        }

        public static Boolean validEmail(String email)
        {
            if (containsA(email))
            {
                if (containsDomain(email))
                {
                    if (noSpaces(email))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static Boolean containsA(String field)
        {
            if (field.Contains("@"))
            {
                return true;
            }

            return false;
        }

        public static Boolean containsDomain(String field)
        {
            if (field.Contains("."))
            {
                return true;
            }

            return false;
        }

        public static Boolean containsLetters(String field)
        {
            //if the string contains a letter from a-z uppercase or lowercase return true
            if (Regex.IsMatch(field, ".*?[a-zA-Z].*?"))
            {
                return true;
            }
            //otherwise return false
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
            //create a sha hashing object
            var sha256 = SHA256.Create();
            //split the password into bytes, hash the bytes, and return them as a list of hashed bytes
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            //create a stringbuilder object
            StringBuilder stringBuilder = new StringBuilder();
            //for every byte, append it to the string
            for (int i = 0; i < bytes.Length; i++)
            {
                stringBuilder.Append(bytes[i].ToString("x2"));
            }
            //build and return the string
            return stringBuilder.ToString();
        }
    }
}
