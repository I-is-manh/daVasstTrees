using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace daVasstTrees.Model
{
    public class orderDetail
    {
        private int orderID;
        private int productID;
        private int quantity;
        public orderDetail(int orderID, int productID, int quantity)
        {
            this.orderID = orderID;
            this.productID = productID;
            this.quantity = quantity;
        }

        // Getter and Setter for OrderID
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        // Getter and Setter for ProductID
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        // Getter and Setter for Quantity
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        // Getter and Setter for Price
        
    }
}