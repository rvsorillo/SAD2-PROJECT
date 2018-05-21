namespace WindowsFormsApp3
{
    partial class Profile_Item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Item));
            this.reset_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.item_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.supplier_id = new System.Windows.Forms.TextBox();
            this.item_type_id_fk = new System.Windows.Forms.TextBox();
            this.item_id = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.item_size = new System.Windows.Forms.TextBox();
            this.brand_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.measure_text = new System.Windows.Forms.ComboBox();
            this.measure_label = new System.Windows.Forms.Label();
            this.item_name_text = new System.Windows.Forms.TextBox();
            this.item_name_label = new System.Windows.Forms.Label();
            this.item_supplier_text = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.item_type_text = new System.Windows.Forms.ComboBox();
            this.item_sellingprice_text = new System.Windows.Forms.TextBox();
            this.item_purchaseprice_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.Tomato;
            this.reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(973, 496);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(104, 27);
            this.reset_button.TabIndex = 136;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_button.Enabled = false;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(869, 496);
            this.update_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(98, 27);
            this.update_button.TabIndex = 135;
            this.update_button.Text = "Update ";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(769, 496);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(95, 27);
            this.add_button.TabIndex = 134;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // item_view
            // 
            this.item_view.AllowUserToAddRows = false;
            this.item_view.AllowUserToDeleteRows = false;
            this.item_view.AllowUserToResizeColumns = false;
            this.item_view.AllowUserToResizeRows = false;
            this.item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.item_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.item_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.item_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_view.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.item_view.Location = new System.Drawing.Point(50, 196);
            this.item_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.item_view.MultiSelect = false;
            this.item_view.Name = "item_view";
            this.item_view.ReadOnly = true;
            this.item_view.RowHeadersVisible = false;
            this.item_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_view.Size = new System.Drawing.Size(674, 327);
            this.item_view.TabIndex = 133;
            this.item_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_view_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 44);
            this.label1.TabIndex = 138;
            this.label1.Text = "Item";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(967, 48);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 139;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // supplier_id
            // 
            this.supplier_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_id.Location = new System.Drawing.Point(276, 238);
            this.supplier_id.Multiline = true;
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.Size = new System.Drawing.Size(31, 26);
            this.supplier_id.TabIndex = 147;
            // 
            // item_type_id_fk
            // 
            this.item_type_id_fk.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_type_id_fk.Location = new System.Drawing.Point(105, 196);
            this.item_type_id_fk.Multiline = true;
            this.item_type_id_fk.Name = "item_type_id_fk";
            this.item_type_id_fk.Size = new System.Drawing.Size(40, 26);
            this.item_type_id_fk.TabIndex = 146;
            this.item_type_id_fk.Visible = false;
            // 
            // item_id
            // 
            this.item_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_id.Location = new System.Drawing.Point(60, 196);
            this.item_id.Multiline = true;
            this.item_id.Name = "item_id";
            this.item_id.Size = new System.Drawing.Size(39, 26);
            this.item_id.TabIndex = 145;
            this.item_id.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 155;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1025, 15);
            this.pictureBox1.TabIndex = 154;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1101, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 156;
            this.exit.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(805, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 176;
            this.label7.Text = "Size";
            // 
            // item_size
            // 
            this.item_size.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_size.Location = new System.Drawing.Point(852, 230);
            this.item_size.Multiline = true;
            this.item_size.Name = "item_size";
            this.item_size.Size = new System.Drawing.Size(225, 26);
            this.item_size.TabIndex = 175;
            // 
            // brand_text
            // 
            this.brand_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_text.Location = new System.Drawing.Point(852, 337);
            this.brand_text.Multiline = true;
            this.brand_text.Name = "brand_text";
            this.brand_text.Size = new System.Drawing.Size(225, 26);
            this.brand_text.TabIndex = 174;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(793, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 173;
            this.label6.Text = "Brand";
            // 
            // measure_text
            // 
            this.measure_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measure_text.FormattingEnabled = true;
            this.measure_text.Location = new System.Drawing.Point(852, 300);
            this.measure_text.Name = "measure_text";
            this.measure_text.Size = new System.Drawing.Size(225, 28);
            this.measure_text.TabIndex = 172;
            // 
            // measure_label
            // 
            this.measure_label.AutoSize = true;
            this.measure_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measure_label.ForeColor = System.Drawing.Color.White;
            this.measure_label.Location = new System.Drawing.Point(744, 307);
            this.measure_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.measure_label.Name = "measure_label";
            this.measure_label.Size = new System.Drawing.Size(101, 16);
            this.measure_label.TabIndex = 171;
            this.measure_label.Text = "Measurement";
            // 
            // item_name_text
            // 
            this.item_name_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_text.Location = new System.Drawing.Point(851, 197);
            this.item_name_text.Multiline = true;
            this.item_name_text.Name = "item_name_text";
            this.item_name_text.Size = new System.Drawing.Size(225, 26);
            this.item_name_text.TabIndex = 170;
            // 
            // item_name_label
            // 
            this.item_name_label.AutoSize = true;
            this.item_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_label.ForeColor = System.Drawing.Color.White;
            this.item_name_label.Location = new System.Drawing.Point(763, 202);
            this.item_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item_name_label.Name = "item_name_label";
            this.item_name_label.Size = new System.Drawing.Size(82, 16);
            this.item_name_label.TabIndex = 169;
            this.item_name_label.Text = "Item Name";
            // 
            // item_supplier_text
            // 
            this.item_supplier_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_supplier_text.FormattingEnabled = true;
            this.item_supplier_text.Location = new System.Drawing.Point(851, 441);
            this.item_supplier_text.Name = "item_supplier_text";
            this.item_supplier_text.Size = new System.Drawing.Size(225, 28);
            this.item_supplier_text.TabIndex = 168;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(776, 447);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 167;
            this.label5.Text = "Supplier";
            // 
            // item_type_text
            // 
            this.item_type_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_type_text.FormattingEnabled = true;
            this.item_type_text.Location = new System.Drawing.Point(852, 264);
            this.item_type_text.Name = "item_type_text";
            this.item_type_text.Size = new System.Drawing.Size(225, 28);
            this.item_type_text.TabIndex = 166;
            // 
            // item_sellingprice_text
            // 
            this.item_sellingprice_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_sellingprice_text.Location = new System.Drawing.Point(851, 406);
            this.item_sellingprice_text.Multiline = true;
            this.item_sellingprice_text.Name = "item_sellingprice_text";
            this.item_sellingprice_text.Size = new System.Drawing.Size(225, 26);
            this.item_sellingprice_text.TabIndex = 165;
            // 
            // item_purchaseprice_text
            // 
            this.item_purchaseprice_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_purchaseprice_text.Location = new System.Drawing.Point(851, 371);
            this.item_purchaseprice_text.Multiline = true;
            this.item_purchaseprice_text.Name = "item_purchaseprice_text";
            this.item_purchaseprice_text.Size = new System.Drawing.Size(225, 26);
            this.item_purchaseprice_text.TabIndex = 164;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(748, 412);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 163;
            this.label2.Text = "Selling Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(768, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 162;
            this.label3.Text = "Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(732, 376);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 161;
            this.label4.Text = "Purchase Price";
            // 
            // Profile_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 592);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.item_size);
            this.Controls.Add(this.brand_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.measure_text);
            this.Controls.Add(this.measure_label);
            this.Controls.Add(this.item_name_text);
            this.Controls.Add(this.item_name_label);
            this.Controls.Add(this.item_supplier_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.item_type_text);
            this.Controls.Add(this.item_sellingprice_text);
            this.Controls.Add(this.item_purchaseprice_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.item_view);
            this.Controls.Add(this.supplier_id);
            this.Controls.Add(this.item_type_id_fk);
            this.Controls.Add(this.item_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile_Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLTP AUTO REPAIR SHOP";
            this.Load += new System.EventHandler(this.Profile_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView item_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox supplier_id;
        private System.Windows.Forms.TextBox item_type_id_fk;
        private System.Windows.Forms.TextBox item_id;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox item_size;
        private System.Windows.Forms.TextBox brand_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox measure_text;
        private System.Windows.Forms.Label measure_label;
        private System.Windows.Forms.TextBox item_name_text;
        private System.Windows.Forms.Label item_name_label;
        private System.Windows.Forms.ComboBox item_supplier_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox item_type_text;
        private System.Windows.Forms.TextBox item_sellingprice_text;
        private System.Windows.Forms.TextBox item_purchaseprice_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}