using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace daVasstTrees.Model
{
    public class User
    {
        private int customerID;
        private string email;
        private string customerPassword;
        private string address;
        private string numberphone;
        private string avatar;
        private string fullName;
        private string confirmcode;
        public User()
        {

        }
        public User(int customerID, string email, string customerPassword, string address, string numberphone, string avatar, string fullName)
        {
            this.customerID = customerID;
            this.email = email;
            this.customerPassword = customerPassword;
            this.address = address;
            this.numberphone = numberphone;
            this.avatar = avatar;
            this.fullName = fullName;
        }
        public User(int customerID, string email, string customerPassword, string address, string numberphone, string avatar, string fullName,string confirmcode)
        {
            this.customerID = customerID;
            this.email = email;
            this.customerPassword = customerPassword;
            this.address = address;
            this.numberphone = numberphone;
            this.avatar = avatar;
            this.fullName = fullName;
            this.confirmcode = confirmcode;
        }
        public int GetCustomerID()
        {
            return customerID;
        }

        public void SetCustomerID(int value)
        {
            customerID = value;
        }

        // Getter và Setter cho email
        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        // Getter và Setter cho customerPassword
        public string GetCustomerPassword()
        {
            return customerPassword;
        }
        public string getConfirm()
        {
            return this.confirmcode;
        }
        public void SetCustomerPassword(string value)
        {
            customerPassword = value;
        }

        // Getter và Setter cho address
        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string value)
        {
            address = value;
        }

        // Getter và Setter cho numberphone
        public string GetNumberphone()
        {
            return numberphone;
        }

        public void SetNumberphone(string value)
        {
            numberphone = value;
        }

        // Getter và Setter cho avatar
        public string GetAvatar()
        {
            return this.avatar;
        }

        public void SetAvatar(string value)
        {
            avatar = value;
        }

        // Getter và Setter cho fullName
        public string GetFullName()
        {
            return fullName;
        }

        public void SetFullName(string value)
        {
            fullName = value;
        }

    }
}