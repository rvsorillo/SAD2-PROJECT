namespace WindowsFormsApp3
{
    partial class Sales_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_List));
            this.job_order_control = new System.Windows.Forms.TabControl();
            this.view_all_tab = new System.Windows.Forms.TabPage();
            this.view_all_view = new System.Windows.Forms.DataGridView();
            this.customer_tab = new System.Windows.Forms.TabPage();
            this.sales_view = new System.Windows.Forms.DataGridView();
            this.walk_in_tab = new System.Windows.Forms.TabPage();
            this.walk_in_view = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.job_order_control.SuspendLayout();
            this.view_all_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_all_view)).BeginInit();
            this.customer_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_view)).BeginInit();
            this.walk_in_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walk_in_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // job_order_control
            // 
            this.job_order_control.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.job_order_control.Controls.Add(this.view_all_tab);
            this.job_order_control.Controls.Add(this.customer_tab);
            this.job_order_control.Controls.Add(this.walk_in_tab);
            this.job_order_control.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_order_control.Location = new System.Drawing.Point(83, 190);
            this.job_order_control.Name = "job_order_control";
            this.job_order_control.Padding = new System.Drawing.Point(125, 8);
            this.job_order_control.SelectedIndex = 0;
            this.job_order_control.Size = new System.Drawing.Size(959, 374);
            this.job_order_control.TabIndex = 163;
            // 
            // view_all_tab
            // 
            this.view_all_tab.Controls.Add(this.view_all_view);
            this.view_all_tab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all_tab.Location = new System.Drawing.Point(4, 42);
            this.view_all_tab.Name = "view_all_tab";
            this.view_all_tab.Size = new System.Drawing.Size(951, 328);
            this.view_all_tab.TabIndex = 2;
            this.view_all_tab.Text = "View All";
            this.view_all_tab.UseVisualStyleBackColor = true;
            // 
            // view_all_view
            // 
            this.view_all_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_all_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_all_view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all_view.Location = new System.Drawing.Point(23, 21);
            this.view_all_view.Name = "view_all_view";
            this.view_all_view.RowHeadersVisible = false;
            this.view_all_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_all_view.Size = new System.Drawing.Size(905, 287);
            this.view_all_view.TabIndex = 1;
            this.view_all_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_all_view_CellDoubleClick);
            // 
            // customer_tab
            // 
            this.customer_tab.Controls.Add(this.sales_view);
            this.customer_tab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_tab.Location = new System.Drawing.Point(4, 42);
            this.customer_tab.Name = "customer_tab";
            this.customer_tab.Size = new System.Drawing.Size(951, 328);
            this.customer_tab.TabIndex = 3;
            this.customer_tab.Text = "Sales";
            this.customer_tab.UseVisualStyleBackColor = true;
            // 
            // sales_view
            // 
            this.sales_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sales_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales_view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_view.Location = new System.Drawing.Point(23, 21);
            this.sales_view.Name = "sales_view";
            this.sales_view.RowHeadersVisible = false;
            this.sales_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sales_view.Size = new System.Drawing.Size(905, 287);
            this.sales_view.TabIndex = 1;
            this.sales_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sales_view_CellDoubleClick);
            // 
            // walk_in_tab
            // 
            this.walk_in_tab.Controls.Add(this.walk_in_view);
            this.walk_in_tab.Location = new System.Drawing.Point(4, 42);
            this.walk_in_tab.Name = "walk_in_tab";
            this.walk_in_tab.Size = new System.Drawing.Size(951, 328);
            this.walk_in_tab.TabIndex = 4;
            this.walk_in_tab.Text = "Walk-in Sales";
            this.walk_in_tab.UseVisualStyleBackColor = true;
            // 
            // walk_in_view
            // 
            this.walk_in_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.walk_in_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.walk_in_view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walk_in_view.Location = new System.Drawing.Point(23, 21);
            this.walk_in_view.Name = "walk_in_view";
            this.walk_in_view.RowHeadersVisible = false;
            this.walk_in_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.walk_in_view.Size = new System.Drawing.Size(905, 287);
            this.walk_in_view.TabIndex = 2;
            this.walk_in_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.walk_in_view_CellDoubleClick);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(231, 98);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.ShortcutsEnabled = false;
            this.txtid.Size = new System.Drawing.Size(44, 24);
            this.txtid.TabIndex = 162;
            this.txtid.Visible = false;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(985, 43);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 160;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 44);
            this.label1.TabIndex = 158;
            this.label1.Text = "Sales List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 165;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 22);
            this.pictureBox1.TabIndex = 164;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1105, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 166;
            this.exit.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(84, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 16);
            this.label5.TabIndex = 283;
            this.label5.Text = "* Double click a row to view Sales Details";
            // 
            // Sales_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1138, 596);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.job_order_control);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_List";
            this.Load += new System.EventHandler(this.Sales_List_Load);
            this.job_order_control.ResumeLayout(false);
            this.view_all_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_all_view)).EndInit();
            this.customer_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sales_view)).EndInit();
            this.walk_in_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.walk_in_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl job_order_control;
        private System.Windows.Forms.TabPage view_all_tab;
        private System.Windows.Forms.DataGridView view_all_view;
        private System.Windows.Forms.TabPage customer_tab;
        private System.Windows.Forms.DataGridView sales_view;
        private System.Windows.Forms.TabPage walk_in_tab;
        private System.Windows.Forms.DataGridView walk_in_view;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label5;
    }
}