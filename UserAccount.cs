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
        private int powerupSkip;

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

        //stars
        public int getStarsCount()
        {
            return this.starCount;
        }

        public void setStarsCount(int starCount)
        {
            this.starCount = starCount;
        }

        //powerups
        public int getEliminateCount()
        {
            return this.powerupEliminate;
        }

        public void setEliminateCount(int powerupEliminate)
        {
            this.powerupEliminate = powerupEliminate;
        }

        //
        public int getMultiplyCount()
        {
            return this.powerupMultiplier;
        }

        public void setMultiplyCount(int powerupMultiplier)
        {
            this.powerupMultiplier = powerupMultiplier;
        }
        //
        public int getDoubleCount()
        {
            return this.powerupDoubler;
        }

        public void setDoubleCount(int powerupDoubler)
        {
            this.powerupDoubler = powerupDoubler;
        }
        //
        public int getStakesCount()
        {
            return this.powerupStakes;
        }

        public void setStakesCount(int powerupStakes)
        {
            this.powerupStakes = powerupStakes;
        }
        //
        public int getImmunityCount()
        {
            return this.powerupImmunity;
        }

        public void setImmunityCount(int powerupImmunity)
        {
            this.powerupImmunity = powerupImmunity;
        }
        //
        public int getSkipCount()
        {
            return this.starCount;
        }

        public void setSkipCount(int powerupSkip)
        {
            this.powerupSkip = powerupSkip;
        }

        public void setAttemptedQuizzes(List<Quiz> quiz)
        {

        }
    }
}
