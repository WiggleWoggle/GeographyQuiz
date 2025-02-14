﻿  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class UserAccount
    {
        private String name = "";
        private String username = "";
        private String encryptedPassword = "";
        private String email = "";

        private int starCount = 0;

        private int powerupMultiplier = 0;
        private int powerupImmunity = 0;
        private int powerupEliminate = 0;
        private int powerupStakes = 0;
        private int powerupDoubler = 0;
        private int powerupSkip = 0;

        private System.Drawing.Color profileColor;
        private String profilePicPath = "";

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

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getEmail()
        {
            return this.email;
        }

        public void setProfilePicPath(String profilePicPath)
        {
            this.profilePicPath = profilePicPath;
        }

        public String getProfilePicPath()
        {
            return this.profilePicPath;
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
            return this.powerupSkip;
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
