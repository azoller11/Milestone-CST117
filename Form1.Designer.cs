
namespace Milestone
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clearSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_decrease = new System.Windows.Forms.Button();
            this.btn_increase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_currentStock = new System.Windows.Forms.Label();
            this.lb_productCost = new System.Windows.Forms.Label();
            this.lb_productAmount = new System.Windows.Forms.Label();
            this.lb_productName = new System.Windows.Forms.Label();
            this.lb_productID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_createProduct = new System.Windows.Forms.Button();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_showProduct = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_products = new System.Windows.Forms.ListBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.btn_clearSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_removeProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_createProduct);
            this.panel1.Controls.Add(this.btn_editProduct);
            this.panel1.Controls.Add(this.btn_showProduct);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 118);
            this.panel1.TabIndex = 0;
            // 
            // btn_clearSearch
            // 
            this.btn_clearSearch.Location = new System.Drawing.Point(336, 88);
            this.btn_clearSearch.Name = "btn_clearSearch";
            this.btn_clearSearch.Size = new System.Drawing.Size(78, 23);
            this.btn_clearSearch.TabIndex = 7;
            this.btn_clearSearch.Text = "Refresh";
            this.btn_clearSearch.UseVisualStyleBackColor = true;
            this.btn_clearSearch.Click += new System.EventHandler(this.btn_clearSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.btn_decrease);
            this.panel2.Controls.Add(this.btn_increase);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_currentStock);
            this.panel2.Controls.Add(this.lb_productCost);
            this.panel2.Controls.Add(this.lb_productAmount);
            this.panel2.Controls.Add(this.lb_productName);
            this.panel2.Controls.Add(this.lb_productID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(538, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 108);
            this.panel2.TabIndex = 6;
            // 
            // btn_decrease
            // 
            this.btn_decrease.Location = new System.Drawing.Point(72, 73);
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Size = new System.Drawing.Size(36, 23);
            this.btn_decrease.TabIndex = 8;
            this.btn_decrease.Text = "\\/";
            this.btn_decrease.UseVisualStyleBackColor = true;
            this.btn_decrease.Click += new System.EventHandler(this.btn_decrease_Click);
            // 
            // btn_increase
            // 
            this.btn_increase.Location = new System.Drawing.Point(193, 76);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(36, 23);
            this.btn_increase.TabIndex = 7;
            this.btn_increase.Text = "/\\";
            this.btn_increase.UseVisualStyleBackColor = true;
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edit Stock:";
            // 
            // lb_currentStock
            // 
            this.lb_currentStock.AutoSize = true;
            this.lb_currentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_currentStock.Location = new System.Drawing.Point(114, 76);
            this.lb_currentStock.Name = "lb_currentStock";
            this.lb_currentStock.Size = new System.Drawing.Size(18, 20);
            this.lb_currentStock.TabIndex = 5;
            this.lb_currentStock.Text = "0";
            // 
            // lb_productCost
            // 
            this.lb_productCost.AutoSize = true;
            this.lb_productCost.Location = new System.Drawing.Point(7, 60);
            this.lb_productCost.Name = "lb_productCost";
            this.lb_productCost.Size = new System.Drawing.Size(31, 13);
            this.lb_productCost.TabIndex = 4;
            this.lb_productCost.Text = "Cost:";
            // 
            // lb_productAmount
            // 
            this.lb_productAmount.AutoSize = true;
            this.lb_productAmount.Location = new System.Drawing.Point(7, 47);
            this.lb_productAmount.Name = "lb_productAmount";
            this.lb_productAmount.Size = new System.Drawing.Size(46, 13);
            this.lb_productAmount.TabIndex = 3;
            this.lb_productAmount.Text = "Amount:";
            // 
            // lb_productName
            // 
            this.lb_productName.AutoSize = true;
            this.lb_productName.Location = new System.Drawing.Point(7, 34);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.Size = new System.Drawing.Size(38, 13);
            this.lb_productName.TabIndex = 2;
            this.lb_productName.Text = "Name:";
            // 
            // lb_productID
            // 
            this.lb_productID.AutoSize = true;
            this.lb_productID.Location = new System.Drawing.Point(7, 21);
            this.lb_productID.Name = "lb_productID";
            this.lb_productID.Size = new System.Drawing.Size(21, 13);
            this.lb_productID.TabIndex = 1;
            this.lb_productID.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Product";
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Location = new System.Drawing.Point(440, 19);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(92, 35);
            this.btn_removeProduct.TabIndex = 5;
            this.btn_removeProduct.Text = "Remove Product";
            this.btn_removeProduct.UseVisualStyleBackColor = true;
            this.btn_removeProduct.Click += new System.EventHandler(this.btn_removeProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // btn_createProduct
            // 
            this.btn_createProduct.Location = new System.Drawing.Point(342, 19);
            this.btn_createProduct.Name = "btn_createProduct";
            this.btn_createProduct.Size = new System.Drawing.Size(92, 35);
            this.btn_createProduct.TabIndex = 4;
            this.btn_createProduct.Text = "Create Product";
            this.btn_createProduct.UseVisualStyleBackColor = true;
            this.btn_createProduct.Click += new System.EventHandler(this.btn_createProduct_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Location = new System.Drawing.Point(244, 19);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(92, 35);
            this.btn_editProduct.TabIndex = 3;
            this.btn_editProduct.Text = "Edit Product";
            this.btn_editProduct.UseVisualStyleBackColor = true;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_showProduct
            // 
            this.btn_showProduct.Location = new System.Drawing.Point(146, 19);
            this.btn_showProduct.Name = "btn_showProduct";
            this.btn_showProduct.Size = new System.Drawing.Size(92, 35);
            this.btn_showProduct.TabIndex = 2;
            this.btn_showProduct.Text = "View Product";
            this.btn_showProduct.UseVisualStyleBackColor = true;
            this.btn_showProduct.Click += new System.EventHandler(this.btn_showProduct_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(252, 89);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(78, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(9, 91);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(237, 20);
            this.tb_search.TabIndex = 0;
            // 
            // lb_products
            // 
            this.lb_products.FormattingEnabled = true;
            this.lb_products.Location = new System.Drawing.Point(12, 148);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(770, 290);
            this.lb_products.TabIndex = 1;
            this.lb_products.SelectedIndexChanged += new System.EventHandler(this.lb_products_SelectedIndexChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(12, 58);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(128, 23);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_products);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Inventory Managment Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_removeProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_createProduct;
        private System.Windows.Forms.Button btn_editProduct;
        private System.Windows.Forms.Button btn_showProduct;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ListBox lb_products;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_productCost;
        private System.Windows.Forms.Label lb_productAmount;
        private System.Windows.Forms.Label lb_productName;
        private System.Windows.Forms.Label lb_productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clearSearch;
        private System.Windows.Forms.Button btn_decrease;
        private System.Windows.Forms.Button btn_increase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_currentStock;
        private System.Windows.Forms.Button btn_login;
    }
}

