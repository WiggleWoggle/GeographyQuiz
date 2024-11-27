  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class UserAccount
    {
        private String name;
        private String username;
        private String encryptedPassword;

        private int starCount;

        private int powerupMultiplier;
        private int powerupImmunity;
        private int powerupEliminate;
        private int powerupStakes;
        private int powerupDoubler;

        private System.Drawing.Color profileColor;

        public UserAccount() {


        }

        public UserAccount(String username, String encryptedPassword)
        {

            this.username = username;
            this.encryptedPassword = encryptedPassword;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void setUserName(String username)
        {
            this.username = username;
        }

        public void setEncryptedPassword(String encryptedPassword)
        {
            this.encryptedPassword = encryptedPassword;
        }

        public String getUsername()
        {
            return this.username;
        }

        public String getEncryptedPassword()
        {
            return this.encryptedPassword;
        }
    }
}
