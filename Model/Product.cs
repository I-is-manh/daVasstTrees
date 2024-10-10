using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace daVasstTrees.Model
{
    public class Product
    {
        private int productID;
        private int categoryID;
        private string name;
        private float price;
        private float discount_percent;
        private int purchase;
        private int quantity;
        private string linkimg;
        private string desc;
        private bool status;

        public Product(int productID, int categoryID, string name, float price, float discount_percent, int purchase, int quantity, string linkimg, string desc, bool status)
        {
            this.productID = productID;
            this.categoryID = categoryID;
            this.name = name;
            this.price = price;
            this.discount_percent = discount_percent;
            this.purchase = purchase;
            this.quantity = quantity;
            this.linkimg = linkimg;
            this.desc = desc;
            this.status = status;
        }
        public Product()
        {

        }
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        // Getter và Setter cho categoryID
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        // Getter và Setter cho name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Getter và Setter cho price
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        // Getter và Setter cho discount_percent
        public float DiscountPercent
        {
            get { return discount_percent; }
            set { discount_percent = value; }
        }

        // Getter và Setter cho purchase
        public int Purchase
        {
            get { return this.purchase; }
            set { purchase = value; }
        }

        // Getter và Setter cho quantity
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        // Getter và Setter cho linkimg
        public string LinkImg
        {
            get { return linkimg; }
            set { linkimg = value; }
        }

        // Getter và Setter cho desc
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        // Getter và Setter cho status
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}