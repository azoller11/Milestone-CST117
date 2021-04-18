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
    public partial class ProductViewer : Form
    {
        public ProductViewer()
        {
            InitializeComponent();
            lb_name.Text = Inventory.selectedProduct.productName;
            tb_name.Text = Inventory.selectedProduct.productName;
            tb_amount.Text = Inventory.selectedProduct.productAmount.ToString();
            tb_cost.Text = Inventory.selectedProduct.productCost.ToString() ;
            tb_disciption.Text = Inventory.selectedProduct.productDisctription;

        }
        



        private void btn_save_Click(object sender, EventArgs e)
        {

            //If the ID = null or zero then we are creating a new product otherwise we are editing a prodcut;
            if (Inventory.selectedProduct.productID != 0)
            {
                //Edit
                
                try
                {
                    Product newProduct = new Product();
                    newProduct.productID = Inventory.selectedProduct.productID;
                    newProduct.productName = tb_name.Text;
                    newProduct.productAmount = int.Parse(tb_amount.Text);
                    newProduct.productCost = float.Parse(tb_cost.Text);
                    newProduct.productDisctription = tb_disciption.Text;
                    if (newProduct.productAmount < 0)
                    {
                        MessageBox.Show("The amount must be atleast Zero, we set it to zero.");
                        newProduct.productAmount = 0;
                    }
                    InventoryManager.editProductByID(Inventory.selectedProduct.productID, newProduct);
                    
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Please Enter The Correct Credentials");
                }

            } else
            {
                //Create

                try
                {
                    Product newProduct = new Product();
                    newProduct.productID = InventoryManager.checkForAvailibleID();
                    newProduct.productName = tb_name.Text;
                    newProduct.productAmount = int.Parse(tb_amount.Text);
                    newProduct.productCost = float.Parse(tb_cost.Text);
                    newProduct.productDisctription = tb_disciption.Text;
                    if (newProduct.productAmount < 0)
                    {
                        MessageBox.Show("The amount must be atleast Zero, we set it to zero.");
                        newProduct.productAmount = 0;
                    }
                    InventoryManager.createNewProduct(newProduct);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Please Enter The Correct Credentials");
                }
            }



            
           
        }
        //Closes out of the window, without saving any data.
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void lb_nameEdit_Click(object sender, EventArgs e)
        {

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_cost_Click(object sender, EventArgs e)
        {

        }

        private void tb_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_amount_Click(object sender, EventArgs e)
        {

        }

        private void tb_disciption_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
