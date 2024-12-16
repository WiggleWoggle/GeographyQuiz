using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class AccountDAO
    {

        public static List<UserAccount> userAccounts = new List<UserAccount>();

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=geography;";

        public void getAccounts()
        {

            userAccounts.Clear();

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                //server down
                Program.successfulConnection = false;
                Console.Write("FALLBACK");
            }

            if (Program.successfulConnection) {
                MySqlCommand command = new MySqlCommand("SELECT * FROM USERACCOUNT", connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        UserAccount account = new UserAccount();

                        account.setName(reader.GetString(1));
                        account.setUserName(reader.GetString(2));
                        account.setEncryptedPassword(reader.GetString(3));

                        userAccounts.Add(account);
                    }
                }

                connection.Close();
            }
        }

        public void addAccount(UserAccount importedAccount)
        {

            String name = importedAccount.getName();
            String username = importedAccount.getUsername();
            String encryptedPassword = importedAccount.getEncryptedPassword();

            int stars = importedAccount.getStarsCount();
            int skips = importedAccount.getSkipCount();
            int eliminates = importedAccount.getEliminateCount();
            int doubles = importedAccount.getDoubleCount();
            int multipliers = importedAccount.getMultiplyCount();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `useraccount`(`FirstName`, `Username`, `EncryptedPassword`, `Stars`, `Skips`, `Eliminates`, `Doubles`, `Multipliers`) VALUES (@firstname, @username, @encryptedpassword, @stars, @skips, @eliminates, @doubles, @multipliers)", connection);
            command.Parameters.AddWithValue("@firstname", name);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@encryptedpassword", encryptedPassword);
            command.Parameters.AddWithValue("@stars", stars);
            command.Parameters.AddWithValue("@skips", skips);
            command.Parameters.AddWithValue("@eliminates", eliminates);
            command.Parameters.AddWithValue("@doubles", doubles);
            command.Parameters.AddWithValue("@multipliers", multipliers);

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
