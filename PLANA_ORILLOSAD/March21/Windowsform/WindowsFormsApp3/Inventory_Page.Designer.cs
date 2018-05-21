namespace WindowsFormsApp3
{
    partial class Inventory_Page
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Inventory_Link = new System.Windows.Forms.Button();
            this.Stockout_Link = new System.Windows.Forms.Button();
            this.Stockin_Link = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.Purchase_Order_Link = new System.Windows.Forms.Button();
            this.purchase_order_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_order_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Inventory_Link
            // 
            this.Inventory_Link.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Inventory_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Inventory_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventory_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Inventory_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Inventory_Link.ForeColor = System.Drawing.Color.White;
            this.Inventory_Link.Location = new System.Drawing.Point(80, 179);
            this.Inventory_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Inventory_Link.Name = "Inventory_Link";
            this.Inventory_Link.Size = new System.Drawing.Size(288, 39);
            this.Inventory_Link.TabIndex = 73;
            this.Inventory_Link.Text = "INVENTORY";
            this.Inventory_Link.UseVisualStyleBackColor = false;
            this.Inventory_Link.Click += new System.EventHandler(this.Inventory_Link_Click);
            // 
            // Stockout_Link
            // 
            this.Stockout_Link.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Stockout_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Stockout_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stockout_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stockout_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Stockout_Link.ForeColor = System.Drawing.Color.White;
            this.Stockout_Link.Location = new System.Drawing.Point(81, 282);
            this.Stockout_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Stockout_Link.Name = "Stockout_Link";
            this.Stockout_Link.Size = new System.Drawing.Size(287, 41);
            this.Stockout_Link.TabIndex = 71;
            this.Stockout_Link.Text = "STOCK OUT";
            this.Stockout_Link.UseVisualStyleBackColor = false;
            this.Stockout_Link.Click += new System.EventHandler(this.Stockout_Link_Click);
            // 
            // Stockin_Link
            // 
            this.Stockin_Link.BackColor = System.Drawing.Color.Tomato;
            this.Stockin_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Stockin_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stockin_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stockin_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Stockin_Link.ForeColor = System.Drawing.Color.White;
            this.Stockin_Link.Location = new System.Drawing.Point(81, 231);
            this.Stockin_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Stockin_Link.Name = "Stockin_Link";
            this.Stockin_Link.Size = new System.Drawing.Size(286, 40);
            this.Stockin_Link.TabIndex = 69;
            this.Stockin_Link.Text = "STOCK IN";
            this.Stockin_Link.UseVisualStyleBackColor = false;
            this.Stockin_Link.Click += new System.EventHandler(this.Stockin_Link_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(312, 57);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 123;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(454, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 135;
            this.exit.Text = "x";
            // 
            // Purchase_Order_Link
            // 
            this.Purchase_Order_Link.BackColor = System.Drawing.Color.SeaGreen;
            this.Purchase_Order_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Purchase_Order_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Purchase_Order_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Purchase_Order_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Purchase_Order_Link.ForeColor = System.Drawing.Color.White;
            this.Purchase_Order_Link.Location = new System.Drawing.Point(80, 126);
            this.Purchase_Order_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Purchase_Order_Link.Name = "Purchase_Order_Link";
            this.Purchase_Order_Link.Size = new System.Drawing.Size(287, 40);
            this.Purchase_Order_Link.TabIndex = 136;
            this.Purchase_Order_Link.Text = "PURCHASE ORDER";
            this.Purchase_Order_Link.UseVisualStyleBackColor = false;
            this.Purchase_Order_Link.Click += new System.EventHandler(this.Purchase_Order_Link_Click);
            // 
            // purchase_order_view
            // 
            this.purchase_order_view.AllowUserToAddRows = false;
            this.purchase_order_view.AllowUserToDeleteRows = false;
            this.purchase_order_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchase_order_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.purchase_order_view.ColumnHeadersHeight = 26;
            this.purchase_order_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.purchase_order_view.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchase_order_view.DefaultCellStyle = dataGridViewCellStyle6;
            this.purchase_order_view.Location = new System.Drawing.Point(355, 56);
            this.purchase_order_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.purchase_order_view.Name = "purchase_order_view";
            this.purchase_order_view.ReadOnly = true;
            this.purchase_order_view.RowHeadersVisible = false;
            this.purchase_order_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.purchase_order_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchase_order_view.Size = new System.Drawing.Size(39, 15);
            this.purchase_order_view.TabIndex = 317;
            // 
            // Inventory_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(476, 398);
            this.Controls.Add(this.Purchase_Order_Link);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Inventory_Link);
            this.Controls.Add(this.Stockout_Link);
            this.Controls.Add(this.Stockin_Link);
            this.Controls.Add(this.purchase_order_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLTP AUTO REPAIR SHOP";
            this.Load += new System.EventHandler(this.Inventory_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchase_order_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Inventory_Link;
        private System.Windows.Forms.Button Stockout_Link;
        private System.Windows.Forms.Button Stockin_Link;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button Purchase_Order_Link;
        private System.Windows.Forms.DataGridView purchase_order_view;
    }
}