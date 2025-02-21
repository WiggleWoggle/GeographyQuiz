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
            //accounts are refreshed on form change so make sure no duplicates can be made
            userAccounts.Clear();
            //assign the path of the connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            //try to open a connection and if it fails catch the error and set the program mode to offline
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                //server down
                Program.successfulConnection = false;
            }
            //if the connection is made then create a select command
            if (Program.successfulConnection) {
                MySqlCommand command = new MySqlCommand("SELECT * FROM USERACCOUNT", connection);
                //execute the command and parse the results with a data reader
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    //read each row of user information and create a user account with the information
                    while (reader.Read())
                    {
                        UserAccount account = new UserAccount();

                        account.setName(reader.GetString(1));
                        account.setUserName(reader.GetString(2));
                        account.setEncryptedPassword(reader.GetString(3));
                        account.setEmail(reader.GetString(9));
                        account.setProfilePicPath(reader.GetString(10));
                        //add the created user account to the list
                        userAccounts.Add(account);
                    }
                }
                //close the connection once done
                connection.Close();
            }
        }

        public void addAccount(UserAccount importedAccount)
        {
            //split the account information into separate strings for ease of use 
            String name = importedAccount.getName();
            String username = importedAccount.getUsername();
            String encryptedPassword = importedAccount.getEncryptedPassword();
            String email = importedAccount.getEmail();
            String profilePicture = importedAccount.getProfilePicPath();
            //split the account information into separate striintsngs for ease of use
            int stars = importedAccount.getStarsCount();
            int skips = importedAccount.getSkipCount();
            int eliminates = importedAccount.getEliminateCount();
            int doubles = importedAccount.getDoubleCount();
            int multipliers = importedAccount.getMultiplyCount();
            //establish a connection to the server from the path
            MySqlConnection connection = new MySqlConnection(connectionString);
            //open the connection
            connection.Open();
            //format an insert command to insert information into the fields started in the parenthesis
            MySqlCommand command = new MySqlCommand("INSERT INTO `useraccount`(`FirstName`, `Username`, `EncryptedPassword`, `Stars`, `Skips`, `Eliminates`, `Doubles`, `Multipliers`, `Email`, `ProfilePicture`) VALUES (@firstname, @username, @encryptedpassword, @stars, @skips, @eliminates, @doubles, @multipliers, @email, @profilepicture)", connection);
            //assign the information parameters to the values that were split into strings/ints earlier
            command.Parameters.AddWithValue("@firstname", name);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@encryptedpassword", encryptedPassword);
            command.Parameters.AddWithValue("@stars", stars);
            command.Parameters.AddWithValue("@skips", skips);
            command.Parameters.AddWithValue("@eliminates", eliminates);
            command.Parameters.AddWithValue("@doubles", doubles);
            command.Parameters.AddWithValue("@multipliers", multipliers);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@profilepicture", profilePicture);
            //execute the command without expecting a return
            command.ExecuteNonQuery();
            //close the sql connection
            connection.Close();
        }
    }
}
