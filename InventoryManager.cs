using MilestoneProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    class InventoryManager
    {
        //For milestone 5 we are converting to a List here.
        public static List<Product> allProducts = new List<Product>();

        //Create a new product, if its already there we dont add it.
        public static void createNewProduct(Product newProduct)
        {
            if (allProducts.Contains(newProduct))
            {
                MessageBox.Show("This products already exhists. The new prodcut was not added to you inventory.");
            } else
            {
                allProducts.Add(newProduct);
                MessageBox.Show("Success!");
            }
        }

        //We edit a product by its id;
        public static void editProductByID(int id, Product newCredentials)
        {
            try
            {


                bool found = false;
                for (int amount = 0; amount < allProducts.Count; amount++)
                {
                    if (allProducts[amount].productID == id)
                    {
                        allProducts[amount] = newCredentials;
                        found = true;
                    }
                }

                if (!found)
                {
                    if (MessageBox.Show("This product ID does not exhist, would you like to make this a new product?", "Create New Product", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                       allProducts.Add(newCredentials);
                    }
                }
            }
            catch
            {
                MessageBox.Show("The item was not found and no products were Edited.");
            }

        }

        public static Product getProductByID(int id)
        {
            Product found = null;
            foreach (Product thisProduct in allProducts)
            {
                if (thisProduct.productID == id)
                {

                    return thisProduct;
                }
            }
            return found;
        }

        //We remove a product by its id; First it makes sure its there and gives the user a message.
        public static void removeProductByID(int id)
        {
            if (allProducts.Contains(getProductByID(id))) {
                if (MessageBox.Show("Are you sure you want to remove this product?", "Remove Product", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    allProducts.Remove(getProductByID(id));
                }
            }
        }

        //This returns a list of the searched criteria
        public static List<Product> search(String desire)
        {
            desire = desire.ToLower();
            List<Product> found = new List<Product>();
            foreach (Product thisProduct in allProducts)
            {
                Boolean addToList = false;
                if (thisProduct.productName.ToLower().Contains(desire))
                {
                    addToList = true;
                }
                if (thisProduct.productDisctription.ToLower().Contains(desire))
                {
                    addToList = true;
                }
                if (thisProduct.productID.Equals(desire))
                {
                    addToList = true;
                }
                if (addToList == true)
                {
                    found.Add(thisProduct);
                }
            }
            return found;

        }

        //We can restock an item by amount;
        public static void restockProductByID(int id, int addAmount)
        {
            if (getProductByID(id).productAmount + addAmount < 0)
            {
                MessageBox.Show("Stock cannot go below Zero.", "Stock Error");
            } else
            {
                getProductByID(id).productAmount += addAmount;
            }
            
        }





        //When a product is created, we want to make sure there is no overlapping IDs;
        public static int checkForAvailibleID()
        {
            List<int> numbers = new List<int>();
            foreach (Product tp in allProducts)
            {
                numbers.Add(tp.productID);
            }
            int iteration = 1;
            while(numbers.Contains(iteration))
            {
                iteration++;
            }

            return iteration;
        }

    }
}
