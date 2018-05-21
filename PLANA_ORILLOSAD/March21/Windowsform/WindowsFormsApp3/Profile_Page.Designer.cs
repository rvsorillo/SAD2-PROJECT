namespace WindowsFormsApp3
{
    partial class Profile_Page
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
            this.exit = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.Customer_Link = new System.Windows.Forms.Button();
            this.Vehicle_Link = new System.Windows.Forms.Button();
            this.Employee_Link = new System.Windows.Forms.Button();
            this.Items_Link = new System.Windows.Forms.Button();
            this.Supplier_Link = new System.Windows.Forms.Button();
            this.Services_Link = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(705, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 134;
            this.exit.Text = "x";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(578, 48);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(99, 27);
            this.back_button.TabIndex = 148;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // Customer_Link
            // 
            this.Customer_Link.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Customer_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Customer_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customer_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Customer_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Customer_Link.ForeColor = System.Drawing.Color.White;
            this.Customer_Link.Location = new System.Drawing.Point(169, 149);
            this.Customer_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Customer_Link.Name = "Customer_Link";
            this.Customer_Link.Size = new System.Drawing.Size(307, 40);
            this.Customer_Link.TabIndex = 153;
            this.Customer_Link.Text = "CUSTOMER";
            this.Customer_Link.UseVisualStyleBackColor = false;
            this.Customer_Link.Click += new System.EventHandler(this.Customer_Link_Click);
            // 
            // Vehicle_Link
            // 
            this.Vehicle_Link.BackColor = System.Drawing.Color.SeaGreen;
            this.Vehicle_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Vehicle_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vehicle_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Vehicle_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Vehicle_Link.ForeColor = System.Drawing.Color.White;
            this.Vehicle_Link.Location = new System.Drawing.Point(169, 206);
            this.Vehicle_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Vehicle_Link.Name = "Vehicle_Link";
            this.Vehicle_Link.Size = new System.Drawing.Size(307, 40);
            this.Vehicle_Link.TabIndex = 154;
            this.Vehicle_Link.Text = "VEHICLE";
            this.Vehicle_Link.UseVisualStyleBackColor = false;
            this.Vehicle_Link.Click += new System.EventHandler(this.Vehicle_Link_Click);
            // 
            // Employee_Link
            // 
            this.Employee_Link.BackColor = System.Drawing.Color.Tomato;
            this.Employee_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Employee_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Employee_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Employee_Link.ForeColor = System.Drawing.Color.White;
            this.Employee_Link.Location = new System.Drawing.Point(169, 263);
            this.Employee_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Employee_Link.Name = "Employee_Link";
            this.Employee_Link.Size = new System.Drawing.Size(307, 40);
            this.Employee_Link.TabIndex = 155;
            this.Employee_Link.Text = "EMPLOYEE";
            this.Employee_Link.UseVisualStyleBackColor = false;
            this.Employee_Link.Click += new System.EventHandler(this.Employee_Link_Click);
            // 
            // Items_Link
            // 
            this.Items_Link.BackColor = System.Drawing.Color.IndianRed;
            this.Items_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Items_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Items_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Items_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Items_Link.ForeColor = System.Drawing.Color.White;
            this.Items_Link.Location = new System.Drawing.Point(169, 435);
            this.Items_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Items_Link.Name = "Items_Link";
            this.Items_Link.Size = new System.Drawing.Size(307, 40);
            this.Items_Link.TabIndex = 158;
            this.Items_Link.Text = "ITEMS";
            this.Items_Link.UseVisualStyleBackColor = false;
            this.Items_Link.Click += new System.EventHandler(this.Items_Link_Click);
            // 
            // Supplier_Link
            // 
            this.Supplier_Link.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Supplier_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Supplier_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Supplier_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supplier_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Supplier_Link.ForeColor = System.Drawing.Color.White;
            this.Supplier_Link.Location = new System.Drawing.Point(169, 377);
            this.Supplier_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Supplier_Link.Name = "Supplier_Link";
            this.Supplier_Link.Size = new System.Drawing.Size(307, 40);
            this.Supplier_Link.TabIndex = 157;
            this.Supplier_Link.Text = "SUPPLIER";
            this.Supplier_Link.UseVisualStyleBackColor = false;
            this.Supplier_Link.Click += new System.EventHandler(this.Supplier_Link_Click);
            // 
            // Services_Link
            // 
            this.Services_Link.BackColor = System.Drawing.Color.Sienna;
            this.Services_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Services_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Services_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Services_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Services_Link.ForeColor = System.Drawing.Color.White;
            this.Services_Link.Location = new System.Drawing.Point(169, 320);
            this.Services_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Services_Link.Name = "Services_Link";
            this.Services_Link.Size = new System.Drawing.Size(307, 40);
            this.Services_Link.TabIndex = 156;
            this.Services_Link.Text = "SERVICES";
            this.Services_Link.UseVisualStyleBackColor = false;
            this.Services_Link.Click += new System.EventHandler(this.Services_Link_Click);
            // 
            // Profile_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(738, 592);
            this.Controls.Add(this.Items_Link);
            this.Controls.Add(this.Supplier_Link);
            this.Controls.Add(this.Services_Link);
            this.Controls.Add(this.Employee_Link);
            this.Controls.Add(this.Vehicle_Link);
            this.Controls.Add(this.Customer_Link);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLTP AUTO REPAIR SHOP";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button Customer_Link;
        private System.Windows.Forms.Button Vehicle_Link;
        private System.Windows.Forms.Button Employee_Link;
        private System.Windows.Forms.Button Items_Link;
        private System.Windows.Forms.Button Supplier_Link;
        private System.Windows.Forms.Button Services_Link;
    }
}