namespace WindowsFormsApp3
{
    partial class Purchase_Order_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_Order_List));
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.purch_id = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.TabControl();
            this.pendingtab = new System.Windows.Forms.TabPage();
            this.pending_view = new System.Windows.Forms.DataGridView();
            this.completedtab = new System.Windows.Forms.TabPage();
            this.complete_view = new System.Windows.Forms.DataGridView();
            this.viewalltab = new System.Windows.Forms.TabPage();
            this.purchase_order_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.view.SuspendLayout();
            this.pendingtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pending_view)).BeginInit();
            this.completedtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complete_view)).BeginInit();
            this.viewalltab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_order_view)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(887, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 314;
            this.exit.Text = "x";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 312;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 22);
            this.pictureBox1.TabIndex = 311;
            this.pictureBox1.TabStop = false;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(769, 57);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 307;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 44);
            this.label3.TabIndex = 306;
            this.label3.Text = "Purchase Order List";
            // 
            // purch_id
            // 
            this.purch_id.AutoSize = true;
            this.purch_id.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purch_id.ForeColor = System.Drawing.Color.White;
            this.purch_id.Location = new System.Drawing.Point(116, 109);
            this.purch_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.purch_id.Name = "purch_id";
            this.purch_id.Size = new System.Drawing.Size(41, 44);
            this.purch_id.TabIndex = 308;
            this.purch_id.Text = "x";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(657, 57);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(104, 27);
            this.add_button.TabIndex = 315;
            this.add_button.Text = "Create ";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // view
            // 
            this.view.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.view.Controls.Add(this.pendingtab);
            this.view.Controls.Add(this.completedtab);
            this.view.Controls.Add(this.viewalltab);
            this.view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(41, 188);
            this.view.Name = "view";
            this.view.Padding = new System.Drawing.Point(76, 8);
            this.view.SelectedIndex = 0;
            this.view.Size = new System.Drawing.Size(833, 328);
            this.view.TabIndex = 317;
            // 
            // pendingtab
            // 
            this.pendingtab.Controls.Add(this.pending_view);
            this.pendingtab.Location = new System.Drawing.Point(4, 42);
            this.pendingtab.Name = "pendingtab";
            this.pendingtab.Size = new System.Drawing.Size(825, 282);
            this.pendingtab.TabIndex = 1;
            this.pendingtab.Text = "Pending Orders";
            this.pendingtab.UseVisualStyleBackColor = true;
            // 
            // pending_view
            // 
            this.pending_view.AllowUserToAddRows = false;
            this.pending_view.AllowUserToDeleteRows = false;
            this.pending_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pending_view.ColumnHeadersHeight = 26;
            this.pending_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pending_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pending_view.Location = new System.Drawing.Point(16, 14);
            this.pending_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pending_view.Name = "pending_view";
            this.pending_view.ReadOnly = true;
            this.pending_view.RowHeadersVisible = false;
            this.pending_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.pending_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pending_view.Size = new System.Drawing.Size(793, 254);
            this.pending_view.TabIndex = 317;
            this.pending_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pending_view_CellDoubleClick);
            // 
            // completedtab
            // 
            this.completedtab.Controls.Add(this.complete_view);
            this.completedtab.Location = new System.Drawing.Point(4, 42);
            this.completedtab.Name = "completedtab";
            this.completedtab.Size = new System.Drawing.Size(825, 282);
            this.completedtab.TabIndex = 2;
            this.completedtab.Text = "Completed Orders";
            this.completedtab.UseVisualStyleBackColor = true;
            // 
            // complete_view
            // 
            this.complete_view.AllowUserToAddRows = false;
            this.complete_view.AllowUserToDeleteRows = false;
            this.complete_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.complete_view.ColumnHeadersHeight = 26;
            this.complete_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.complete_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.complete_view.Location = new System.Drawing.Point(16, 14);
            this.complete_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.complete_view.Name = "complete_view";
            this.complete_view.ReadOnly = true;
            this.complete_view.RowHeadersVisible = false;
            this.complete_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.complete_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.complete_view.Size = new System.Drawing.Size(793, 254);
            this.complete_view.TabIndex = 317;
            this.complete_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.complete_view_CellDoubleClick);
            // 
            // viewalltab
            // 
            this.viewalltab.Controls.Add(this.purchase_order_view);
            this.viewalltab.Location = new System.Drawing.Point(4, 42);
            this.viewalltab.Name = "viewalltab";
            this.viewalltab.Size = new System.Drawing.Size(825, 282);
            this.viewalltab.TabIndex = 0;
            this.viewalltab.Text = "View All Orders ";
            this.viewalltab.UseVisualStyleBackColor = true;
            // 
            // purchase_order_view
            // 
            this.purchase_order_view.AllowUserToAddRows = false;
            this.purchase_order_view.AllowUserToDeleteRows = false;
            this.purchase_order_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchase_order_view.ColumnHeadersHeight = 26;
            this.purchase_order_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.purchase_order_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchase_order_view.Location = new System.Drawing.Point(16, 14);
            this.purchase_order_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.purchase_order_view.Name = "purchase_order_view";
            this.purchase_order_view.ReadOnly = true;
            this.purchase_order_view.RowHeadersVisible = false;
            this.purchase_order_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.purchase_order_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchase_order_view.Size = new System.Drawing.Size(793, 254);
            this.purchase_order_view.TabIndex = 318;
            this.purchase_order_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchase_order_view_CellDoubleClick);
            // 
            // Purchase_Order_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.view);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.purch_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase_Order_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase_Order_List";
            this.Load += new System.EventHandler(this.Purchase_Order_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.view.ResumeLayout(false);
            this.pendingtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pending_view)).EndInit();
            this.completedtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.complete_view)).EndInit();
            this.viewalltab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchase_order_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label purch_id;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TabControl view;
        private System.Windows.Forms.TabPage viewalltab;
        private System.Windows.Forms.TabPage pendingtab;
        private System.Windows.Forms.TabPage completedtab;
        private System.Windows.Forms.DataGridView pending_view;
        private System.Windows.Forms.DataGridView complete_view;
        private System.Windows.Forms.DataGridView purchase_order_view;
    }
}