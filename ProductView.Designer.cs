
namespace Milestone
{
    partial class ProductView
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.lb_discription = new System.Windows.Forms.Label();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_cost = new System.Windows.Forms.Label();
            this.lb_nameEdit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Location = new System.Drawing.Point(14, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 74);
            this.panel1.TabIndex = 11;
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
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(109, 304);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 45);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_discription
            // 
            this.lb_discription.AutoSize = true;
            this.lb_discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_discription.Location = new System.Drawing.Point(15, 238);
            this.lb_discription.Name = "lb_discription";
            this.lb_discription.Size = new System.Drawing.Size(114, 26);
            this.lb_discription.TabIndex = 18;
            this.lb_discription.Text = "Discription";
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_amount.Location = new System.Drawing.Point(15, 188);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(88, 26);
            this.lb_amount.TabIndex = 16;
            this.lb_amount.Text = "Amount";
            // 
            // lb_cost
            // 
            this.lb_cost.AutoSize = true;
            this.lb_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_cost.Location = new System.Drawing.Point(15, 138);
            this.lb_cost.Name = "lb_cost";
            this.lb_cost.Size = new System.Drawing.Size(57, 26);
            this.lb_cost.TabIndex = 14;
            this.lb_cost.Text = "Cost";
            // 
            // lb_nameEdit
            // 
            this.lb_nameEdit.AutoSize = true;
            this.lb_nameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_nameEdit.Location = new System.Drawing.Point(15, 88);
            this.lb_nameEdit.Name = "lb_nameEdit";
            this.lb_nameEdit.Size = new System.Drawing.Size(71, 26);
            this.lb_nameEdit.TabIndex = 12;
            this.lb_nameEdit.Text = "Name";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lb_discription);
            this.Controls.Add(this.lb_amount);
            this.Controls.Add(this.lb_cost);
            this.Controls.Add(this.lb_nameEdit);
            this.Name = "ProductView";
            this.Text = "ProductView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_discription;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.Label lb_cost;
        private System.Windows.Forms.Label lb_nameEdit;
    }
}