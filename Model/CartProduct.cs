using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace daVasstTrees.Model
{
    public class CartProduct
    {
        private Product product;
        private int quantity;

        public CartProduct(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
        public CartProduct()
        {
            
        }
        public Product Product
        {
            get { return this.product; }
        }
        public int Quantity
        {
            get{ return this.quantity; }
            set { this.quantity = value; }
        }
    }
}