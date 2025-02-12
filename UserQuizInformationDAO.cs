using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class UserQuizInformationDAO
    {

        private static string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=geography;";

        public static void retrieveUserQuizInformation()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                //server down
            }

            if (Program.successfulConnection)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM USERACCOUNT", connection);

                UserAccount userAccount = Program.currentAccount;

                int totalQuizCount = 0;
                int totalQuizScore = 0;
                int totalQuizAverage;

                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        //should probably be userID but too late for implementation
                        if (userAccount.getUsername().Equals(reader.GetString(1)))
                        {
                            totalQuizCount++;
                            totalQuizScore += reader.GetUInt16(2);
                        }
                    }
                }

                totalQuizAverage = totalQuizScore/totalQuizCount;

                connection.Close();
            }
        }
    }
    
}
