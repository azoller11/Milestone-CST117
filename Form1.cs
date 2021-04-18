using MilestoneProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
            
            Inventory.resetListBox(lb_products, InventoryManager.allProducts, false);
            btn_login.Text = Program.loggedUser;




        }
        




        private void lb_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_products.SelectedIndex >= 0)
            {
                Inventory.selectedProduct = InventoryManager.search(tb_search.Text)[lb_products.SelectedIndex];
                lb_productID.Text = "ID: " + Inventory.selectedProduct.productID.ToString();
                lb_productName.Text = "Name: " + Inventory.selectedProduct.productName.ToString();
                lb_productAmount.Text = "Amount: " + Inventory.selectedProduct.productAmount.ToString();
                lb_productCost.Text = "Cost: $" + Inventory.selectedProduct.productCost.ToString();
                lb_currentStock.Text = Inventory.selectedProduct.productAmount.ToString();
            }
            
        }

        private void btn_showProduct_Click(object sender, EventArgs e)
        {
            if (lb_products.SelectedIndex >= 0)
            {
                Inventory.selectedProduct = InventoryManager.search(tb_search.Text)[lb_products.SelectedIndex];
                lb_productID.Text = "ID: " + Inventory.selectedProduct.productID.ToString();
                lb_productName.Text = "Name: " + Inventory.selectedProduct.productName.ToString();
                lb_productAmount.Text = "Amount: " + Inventory.selectedProduct.productAmount.ToString();
                lb_productCost.Text = "Cost: $" + Inventory.selectedProduct.productCost.ToString();
                ProductView pv = new ProductView();
                pv.ShowDialog();
                tb_search.Text = "";
                Inventory.resetListBox(lb_products, InventoryManager.allProducts, false);
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Inventory.resetListBox(lb_products, InventoryManager.search(tb_search.Text), false);
        }

        private void btn_clearSearch_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            Inventory.resetListBox(lb_products, InventoryManager.allProducts, false);
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            if (lb_products.SelectedIndex >= 0)
            {
                Inventory.selectedProduct = InventoryManager.search(tb_search.Text)[lb_products.SelectedIndex];
                ProductViewer pv = new ProductViewer();
                pv.ShowDialog();
                tb_search.Text = "";
                Inventory.resetListBox(lb_products, InventoryManager.allProducts, false);
            }
        }

        private void btn_createProduct_Click(object sender, EventArgs e)
        {
            
             Inventory.selectedProduct = new Product();
             ProductViewer pv = new ProductViewer();
             pv.ShowDialog();
             tb_search.Text = "";
             Inventory.resetListBox(lb_products, InventoryManager.allProducts, false);

        }

        private void btn_removeProduct_Click(object sender, EventArgs e)
        {
            InventoryManager.removeProductByID(Inventory.selectedProduct.productID);
            tb_search.Text = "";
            Inventory.resetListBox(lb_products, InventoryManager.allProducts, false);

        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            InventoryManager.restockProductByID(Inventory.selectedProduct.productID, (int.Parse(lb_currentStock.Text) + 1) - Inventory.selectedProduct.productAmount);
            lb_productAmount.Text = "Amount: " + Inventory.selectedProduct.productAmount.ToString();
            lb_currentStock.Text = Inventory.selectedProduct.productAmount.ToString();
            Inventory.resetListBox(lb_products, InventoryManager.search(tb_search.Text), false);

        }

        private void btn_decrease_Click(object sender, EventArgs e)
        {
            InventoryManager.restockProductByID(Inventory.selectedProduct.productID, (int.Parse(lb_currentStock.Text) - 1) - Inventory.selectedProduct.productAmount);
            lb_productAmount.Text = "Amount: " + Inventory.selectedProduct.productAmount.ToString();
            lb_currentStock.Text = Inventory.selectedProduct.productAmount.ToString();
            Inventory.resetListBox(lb_products, InventoryManager.search(tb_search.Text), false);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            login.Show();
            btn_login.Text = Program.loggedUser;
        }
    }
}
