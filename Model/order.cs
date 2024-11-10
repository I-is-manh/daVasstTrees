using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace daVasstTrees.Model
{
    public class order
    {
        private int orderID;
        private int customerID;
        private DateTime createDate;
        private string address;
        private string pttt;
        private string moreinfo;

        public order(int orderID, int customerID, DateTime createDate,string address,string pttt, string moreinfo)
        {
            this.orderID = orderID;
            this.customerID = customerID;
            this.createDate = createDate;
            this.address = address;
            this.pttt = pttt;
            this.moreinfo = moreinfo;
        }
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        public String Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public String PTTT
        {
            get { return this.pttt; }
            set { this.pttt = value; }
        }
        public String MoreInfo
        {
            get { return this.moreinfo; }
            set { this.moreinfo  = value; }
        }
    }
}