using MilestoneProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone
{
    class Inventory
    {
        public static Product[] InventoryProducts = new Product[3];
        public static Product selectedProduct;

        public void initilizeProducts()
        {
            addProduct(new Product(1, "Apple", 1.00f, 10, "Red crisp apple."));
            addProduct(new Product(2, "Bannana", 0.75f, 12, "A yellow Bannana."));
            addProduct(new Product(3, "Orange", 1.15f, 42, "A big orange, full of vitamin D."));
            InventoryManager.allProducts = InventoryProducts.OfType<Product>().ToList();
        }



        public static void addProduct(Product newProduct)
        {
            if (InventoryProducts == null)
            {
                InventoryProducts = new Product[] { newProduct };
            }

            Product[] result = new Product[InventoryProducts.Length + 1];
            for (int i = 0; i < InventoryProducts.Length; i++)
            {
                result[i] = InventoryProducts[i];
            }

            if (newProduct.productID == -1)
            {
                newProduct.productID = result.Length;
            }

            result[InventoryProducts.Length] = newProduct;

            InventoryProducts = result;

        }



        public static Product[] getProducts()
        {
            return InventoryProducts;
        }


        //This will update the list if an item is edited, so it can render correctly on the form.
        //This isent really nessecary, but a cool tool to update the graphical listbox for the forms.
        public static void resetListBox(System.Windows.Forms.ListBox lb_items, List<Product> np, bool simple)
        {
            lb_items.Items.Clear();
            foreach (Product tp in np)
            {
                //The simple credential is added to define if the program wants to display a simple or complex string, with all the variables 
                //in that product object. 
                if (simple)
                {
                    lb_items.Items.Add(tp.simpleToString());
                }
                else
                {
                    lb_items.Items.Add(tp.ToString());

                }

            }
            lb_items.ClearSelected();

        }

        public static void resetListBox(System.Windows.Forms.ListBox lb_items, Product[] np, bool simple)
        {
            lb_items.Items.Clear();
            for (int i = 0; i < np.Length; i++)
            {
                if (simple)
                {
                    lb_items.Items.Add(np[i].simpleToString());
                }
                else
                {
                    lb_items.Items.Add(np[i].ToString());

                }
            }
        }
    }
}
