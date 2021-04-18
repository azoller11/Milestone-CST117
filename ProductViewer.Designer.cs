
namespace Milestone
{
    partial class ProductViewer
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
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_nameEdit = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.lb_cost = new System.Windows.Forms.Label();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.lb_amount = new System.Windows.Forms.Label();
            this.tb_disciption = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 74);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lb_name.Location = new System.Drawing.Point(3, 9);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(250, 51);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "this Product";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // lb_nameEdit
            // 
            this.lb_nameEdit.AutoSize = true;
            this.lb_nameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_nameEdit.Location = new System.Drawing.Point(13, 93);
            this.lb_nameEdit.Name = "lb_nameEdit";
            this.lb_nameEdit.Size = new System.Drawing.Size(71, 26);
            this.lb_nameEdit.TabIndex = 1;
            this.lb_nameEdit.Text = "Name";
            this.lb_nameEdit.Click += new System.EventHandler(this.lb_nameEdit_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(18, 123);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(147, 20);
            this.tb_name.TabIndex = 2;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(18, 173);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(147, 20);
            this.tb_cost.TabIndex = 4;
            this.tb_cost.TextChanged += new System.EventHandler(this.tb_cost_TextChanged);
            // 
            // lb_cost
            // 
            this.lb_cost.AutoSize = true;
            this.lb_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_cost.Location = new System.Drawing.Point(13, 143);
            this.lb_cost.Name = "lb_cost";
            this.lb_cost.Size = new System.Drawing.Size(57, 26);
            this.lb_cost.TabIndex = 3;
            this.lb_cost.Text = "Cost";
            this.lb_cost.Click += new System.EventHandler(this.lb_cost_Click);
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(18, 223);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(147, 20);
            this.tb_amount.TabIndex = 6;
            this.tb_amount.TextChanged += new System.EventHandler(this.tb_amount_TextChanged);
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_amount.Location = new System.Drawing.Point(13, 193);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(88, 26);
            this.lb_amount.TabIndex = 5;
            this.lb_amount.Text = "Amount";
            this.lb_amount.Click += new System.EventHandler(this.lb_amount_Click);
            // 
            // tb_disciption
            // 
            this.tb_disciption.Location = new System.Drawing.Point(18, 273);
            this.tb_disciption.Name = "tb_disciption";
            this.tb_disciption.Size = new System.Drawing.Size(147, 20);
            this.tb_disciption.TabIndex = 8;
            this.tb_disciption.TextChanged += new System.EventHandler(this.tb_disciption_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(13, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discription";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(18, 313);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 45);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(248, 313);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 45);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ProductViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 370);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_disciption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.lb_amount);
            this.Controls.Add(this.tb_cost);
            this.Controls.Add(this.lb_cost);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_nameEdit);
            this.Controls.Add(this.panel1);
            this.Name = "ProductViewer";
            this.ShowIcon = false;
            this.Text = "Product Viewer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_nameEdit;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.Label lb_cost;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.TextBox tb_disciption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
    }
}