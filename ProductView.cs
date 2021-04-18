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
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
            lb_name.Text = Inventory.selectedProduct.productName;
            lb_nameEdit.Text = Inventory.selectedProduct.productName;
            lb_amount.Text = Inventory.selectedProduct.productAmount.ToString();
            lb_cost.Text = "$" + Inventory.selectedProduct.productCost.ToString();
            lb_discription.Text = Inventory.selectedProduct.productDisctription;



        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
