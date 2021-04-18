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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User log = new User(tb_username.Text, tb_password.Text);
            bool found = false;
            foreach(User users in Program.users) {
                if (users.username.Equals(tb_username.Text) && users.password.Equals(tb_password.Text))
                {
                    Program.loggedUser = tb_username.Text;
                    found = true;
                    Inventory myInventory = new Inventory();
                    myInventory.initilizeProducts();
                    this.Close();
                }
               
            }
            if (!found)
            {
                MessageBox.Show("Invalid login credentials, please contact developer.", "Login fail");
            }

        }
    }
}
