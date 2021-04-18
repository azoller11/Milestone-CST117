using System;
using System.Collections.Generic;
using System.Text;

namespace MilestoneProject
{
    class Product
    {


        //Defualt constructor
        public Product() { }

        //Constart values
        public Product(int pID, String pName, float pCost, int pAmount, String pDiscription)
        {
            this.productID = pID;
            this.productName = pName;
            this.productCost = pCost;
            this.productAmount = pAmount;
            this.productDisctription = pDiscription;
        }

        //I also added this constructor so that it will auto generate the ID when added to the list in the inventory class;
        public Product( String pName, float pCost, int pAmount, String pDiscription)
        {
            this.productID = -1;
            this.productName = pName;
            this.productCost = pCost;
            this.productAmount = pAmount;
            this.productDisctription = pDiscription;
        }


        // Properties for the class
        public int productID { get; set; }
        public String productName { get; set; }
        public float productCost { get; set; }
        public int productAmount { get; set; }
        public String productDisctription { get; set; }

        public override string ToString()
        {
            //Returns each of its values and what they are;
            return "ID:" + productID + " Name: " + productName + " Cost: " + productCost + " Amount: " + productAmount + " Discription: " + productDisctription;
        }

        public string simpleToString()
        {
            // A cheap way to convert a float to the standard currency format;
            String currencyConverter = productCost.ToString("C");
            //Returns only a few items (for public view) and what they are. 
            return productName + "     Cost: " + currencyConverter + "     Amount: " + productAmount;

        }

        public String[] dataGridToString()
        {
            return new string[] { productID.ToString(), productName.ToString(), productAmount.ToString(), productCost.ToString(), productDisctription.ToString() };
        }


    }
}
