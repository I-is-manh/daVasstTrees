using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace daVasstTrees.Model
{
    public class Admin
    {
        private int adminID;
        private string email;
        private string password;
        private string fullname;
        private string role;

        public Admin()
        {

        }

        public Admin(int adminID, string email, string password, string fullname, string role)
        {
            this.adminID = adminID;
            this.email = email;
            this.password = password;
            this.fullname = fullname;
            this.role = role;
        }
        public int AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public override string ToString()
        {
            return $"AdminID: {adminID}, Email: {email}, Fullname: {fullname}, Role: {role}";
        }
    }
}