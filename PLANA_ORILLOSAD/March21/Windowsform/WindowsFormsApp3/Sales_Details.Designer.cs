namespace WindowsFormsApp3
{
    partial class Sales_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Details));
            this.cust_name_input = new System.Windows.Forms.TextBox();
            this.sales_id = new System.Windows.Forms.Label();
            this.selected_sales_item_view = new System.Windows.Forms.DataGridView();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.total_text = new System.Windows.Forms.TextBox();
            this.total_label = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cust_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.date_input = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.selected_sales_item_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cust_name_input
            // 
            this.cust_name_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_name_input.Location = new System.Drawing.Point(590, 176);
            this.cust_name_input.Multiline = true;
            this.cust_name_input.Name = "cust_name_input";
            this.cust_name_input.ReadOnly = true;
            this.cust_name_input.Size = new System.Drawing.Size(275, 26);
            this.cust_name_input.TabIndex = 198;
            // 
            // sales_id
            // 
            this.sales_id.AutoSize = true;
            this.sales_id.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_id.ForeColor = System.Drawing.Color.White;
            this.sales_id.Location = new System.Drawing.Point(390, 94);
            this.sales_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sales_id.Name = "sales_id";
            this.sales_id.Size = new System.Drawing.Size(41, 44);
            this.sales_id.TabIndex = 197;
            this.sales_id.Text = "x";
            // 
            // selected_sales_item_view
            // 
            this.selected_sales_item_view.AllowUserToAddRows = false;
            this.selected_sales_item_view.AllowUserToDeleteRows = false;
            this.selected_sales_item_view.AllowUserToResizeColumns = false;
            this.selected_sales_item_view.AllowUserToResizeRows = false;
            this.selected_sales_item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selected_sales_item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.selected_sales_item_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.selected_sales_item_view.DefaultCellStyle = dataGridViewCellStyle4;
            this.selected_sales_item_view.Location = new System.Drawing.Point(60, 244);
            this.selected_sales_item_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selected_sales_item_view.MultiSelect = false;
            this.selected_sales_item_view.Name = "selected_sales_item_view";
            this.selected_sales_item_view.RowHeadersVisible = false;
            this.selected_sales_item_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.selected_sales_item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selected_sales_item_view.Size = new System.Drawing.Size(805, 235);
            this.selected_sales_item_view.TabIndex = 196;
            // 
            // cust_id
            // 
            this.cust_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_id.Location = new System.Drawing.Point(68, 101);
            this.cust_id.Multiline = true;
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(41, 26);
            this.cust_id.TabIndex = 195;
            this.cust_id.Visible = false;
            // 
            // total_text
            // 
            this.total_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_text.Location = new System.Drawing.Point(752, 485);
            this.total_text.Multiline = true;
            this.total_text.Name = "total_text";
            this.total_text.ReadOnly = true;
            this.total_text.Size = new System.Drawing.Size(112, 26);
            this.total_text.TabIndex = 194;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.Color.White;
            this.total_label.Location = new System.Drawing.Point(691, 491);
            this.total_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(44, 16);
            this.total_label.TabIndex = 193;
            this.total_label.Text = "Total";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(775, 47);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 192;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(451, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 190;
            this.label2.Text = "Date of Purchase";
            // 
            // cust_label
            // 
            this.cust_label.AutoSize = true;
            this.cust_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_label.ForeColor = System.Drawing.Color.White;
            this.cust_label.Location = new System.Drawing.Point(460, 183);
            this.cust_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_label.Name = "cust_label";
            this.cust_label.Size = new System.Drawing.Size(118, 16);
            this.cust_label.TabIndex = 187;
            this.cust_label.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 44);
            this.label1.TabIndex = 189;
            this.label1.Text = "Sales Details #";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(60, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 200;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 18);
            this.pictureBox1.TabIndex = 199;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(887, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 201;
            this.exit.Text = "x";
            // 
            // date_input
            // 
            this.date_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_input.Location = new System.Drawing.Point(590, 209);
            this.date_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date_input.Name = "date_input";
            this.date_input.Size = new System.Drawing.Size(275, 26);
            this.date_input.TabIndex = 202;
            // 
            // Sales_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.date_input);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cust_name_input);
            this.Controls.Add(this.sales_id);
            this.Controls.Add(this.selected_sales_item_view);
            this.Controls.Add(this.total_text);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cust_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cust_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Sales_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selected_sales_item_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cust_name_input;
        private System.Windows.Forms.Label sales_id;
        private System.Windows.Forms.DataGridView selected_sales_item_view;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.TextBox total_text;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cust_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.DateTimePicker date_input;
    }
}