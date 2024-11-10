using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace daVasstTrees.Model
{
    public class UserInfomationOrder
    {
        private string fullname;
        private string address;
        private string numberphone;
        private string email;
        private string moreinfo;
        private string dateOrder;
        private string pttt;

        public UserInfomationOrder(string fullname, string address, string numberphone, string email, string moreinfo,string dateOrder,string pttt)
        {
            this.fullname = fullname;
            this.address = address;
            this.numberphone = numberphone;
            this.email = email;
            this.moreinfo = moreinfo;
            this.dateOrder = dateOrder;
            this.pttt = pttt;
        }

        public UserInfomationOrder()
        {
        }
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Numberphone
        {
            get { return numberphone; }
            set { numberphone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Moreinfo
        {
            get { return moreinfo; }
            set { moreinfo = value; }
        }
        public string DateOrder
        {
            get { return dateOrder; }
            set { dateOrder = value; }
        }

        public string PTTT
        {
            get { return pttt; }
            set { pttt = value; }
        }
    }
}