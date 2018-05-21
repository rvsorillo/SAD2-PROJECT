namespace WindowsFormsApp3
{
    partial class Profile_Supplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Supplier));
            this.supplier_address_text = new System.Windows.Forms.TextBox();
            this.cust_address_label = new System.Windows.Forms.Label();
            this.supplier_contact_text = new System.Windows.Forms.TextBox();
            this.cust_contact_label = new System.Windows.Forms.Label();
            this.supplier_contact_person = new System.Windows.Forms.TextBox();
            this.cust_lastname_label = new System.Windows.Forms.Label();
            this.supplier_name_text = new System.Windows.Forms.TextBox();
            this.cust_firstname_label = new System.Windows.Forms.Label();
            this.customer_label = new System.Windows.Forms.Label();
            this.supplier_view = new System.Windows.Forms.DataGridView();
            this.update_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.supplier_id = new System.Windows.Forms.TextBox();
            this.add_item_button = new System.Windows.Forms.Button();
            this.item_view = new System.Windows.Forms.DataGridView();
            this.supplier_item_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // supplier_address_text
            // 
            this.supplier_address_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_address_text.Location = new System.Drawing.Point(225, 305);
            this.supplier_address_text.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_address_text.Name = "supplier_address_text";
            this.supplier_address_text.Size = new System.Drawing.Size(260, 26);
            this.supplier_address_text.TabIndex = 102;
            // 
            // cust_address_label
            // 
            this.cust_address_label.AutoSize = true;
            this.cust_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_address_label.ForeColor = System.Drawing.Color.White;
            this.cust_address_label.Location = new System.Drawing.Point(145, 310);
            this.cust_address_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_address_label.Name = "cust_address_label";
            this.cust_address_label.Size = new System.Drawing.Size(66, 16);
            this.cust_address_label.TabIndex = 101;
            this.cust_address_label.Text = "Address";
            // 
            // supplier_contact_text
            // 
            this.supplier_contact_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_contact_text.Location = new System.Drawing.Point(225, 270);
            this.supplier_contact_text.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_contact_text.MaxLength = 11;
            this.supplier_contact_text.Name = "supplier_contact_text";
            this.supplier_contact_text.Size = new System.Drawing.Size(260, 26);
            this.supplier_contact_text.TabIndex = 100;
            this.supplier_contact_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supplier_contact_text_KeyPress);
            // 
            // cust_contact_label
            // 
            this.cust_contact_label.AutoSize = true;
            this.cust_contact_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_contact_label.ForeColor = System.Drawing.Color.White;
            this.cust_contact_label.Location = new System.Drawing.Point(91, 274);
            this.cust_contact_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_contact_label.Name = "cust_contact_label";
            this.cust_contact_label.Size = new System.Drawing.Size(118, 16);
            this.cust_contact_label.TabIndex = 99;
            this.cust_contact_label.Text = "Contact Number";
            // 
            // supplier_contact_person
            // 
            this.supplier_contact_person.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_contact_person.Location = new System.Drawing.Point(225, 236);
            this.supplier_contact_person.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_contact_person.Name = "supplier_contact_person";
            this.supplier_contact_person.Size = new System.Drawing.Size(260, 26);
            this.supplier_contact_person.TabIndex = 98;
            // 
            // cust_lastname_label
            // 
            this.cust_lastname_label.AutoSize = true;
            this.cust_lastname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_lastname_label.ForeColor = System.Drawing.Color.White;
            this.cust_lastname_label.Location = new System.Drawing.Point(96, 242);
            this.cust_lastname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_lastname_label.Name = "cust_lastname_label";
            this.cust_lastname_label.Size = new System.Drawing.Size(113, 16);
            this.cust_lastname_label.TabIndex = 97;
            this.cust_lastname_label.Text = "Contact Person";
            // 
            // supplier_name_text
            // 
            this.supplier_name_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_name_text.Location = new System.Drawing.Point(225, 202);
            this.supplier_name_text.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_name_text.Name = "supplier_name_text";
            this.supplier_name_text.Size = new System.Drawing.Size(260, 26);
            this.supplier_name_text.TabIndex = 96;
            // 
            // cust_firstname_label
            // 
            this.cust_firstname_label.AutoSize = true;
            this.cust_firstname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_firstname_label.ForeColor = System.Drawing.Color.White;
            this.cust_firstname_label.Location = new System.Drawing.Point(160, 208);
            this.cust_firstname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_firstname_label.Name = "cust_firstname_label";
            this.cust_firstname_label.Size = new System.Drawing.Size(49, 16);
            this.cust_firstname_label.TabIndex = 95;
            this.cust_firstname_label.Text = "Name";
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_label.ForeColor = System.Drawing.Color.White;
            this.customer_label.Location = new System.Drawing.Point(122, 88);
            this.customer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(163, 44);
            this.customer_label.TabIndex = 91;
            this.customer_label.Text = "Supplier";
            // 
            // supplier_view
            // 
            this.supplier_view.AllowUserToAddRows = false;
            this.supplier_view.AllowUserToDeleteRows = false;
            this.supplier_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplier_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.supplier_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplier_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplier_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.supplier_view.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplier_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.supplier_view.Location = new System.Drawing.Point(526, 200);
            this.supplier_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.supplier_view.Name = "supplier_view";
            this.supplier_view.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplier_view.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.supplier_view.RowHeadersVisible = false;
            this.supplier_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplier_view.Size = new System.Drawing.Size(549, 306);
            this.supplier_view.TabIndex = 137;
            this.supplier_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplier_view_CellClick);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_button.Enabled = false;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(868, 521);
            this.update_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(98, 27);
            this.update_button.TabIndex = 140;
            this.update_button.Text = "Update ";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click_1);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.Tomato;
            this.reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(972, 521);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(104, 27);
            this.reset_button.TabIndex = 139;
            this.reset_button.Text = "Reset ";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(765, 521);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(99, 27);
            this.add_button.TabIndex = 138;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(971, 43);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 141;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // supplier_id
            // 
            this.supplier_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_id.Location = new System.Drawing.Point(532, 202);
            this.supplier_id.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.Size = new System.Drawing.Size(32, 26);
            this.supplier_id.TabIndex = 142;
            this.supplier_id.Visible = false;
            // 
            // add_item_button
            // 
            this.add_item_button.BackColor = System.Drawing.Color.Gray;
            this.add_item_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_item_button.Enabled = false;
            this.add_item_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_item_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item_button.ForeColor = System.Drawing.Color.White;
            this.add_item_button.Location = new System.Drawing.Point(350, 351);
            this.add_item_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_item_button.Name = "add_item_button";
            this.add_item_button.Size = new System.Drawing.Size(135, 27);
            this.add_item_button.TabIndex = 154;
            this.add_item_button.Text = "Add Items";
            this.add_item_button.UseVisualStyleBackColor = false;
            this.add_item_button.Click += new System.EventHandler(this.add_item_button_Click);
            // 
            // item_view
            // 
            this.item_view.AllowUserToAddRows = false;
            this.item_view.AllowUserToDeleteRows = false;
            this.item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.item_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.item_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_view.DefaultCellStyle = dataGridViewCellStyle5;
            this.item_view.Location = new System.Drawing.Point(33, 384);
            this.item_view.Name = "item_view";
            this.item_view.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.item_view.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.item_view.RowHeadersVisible = false;
            this.item_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_view.Size = new System.Drawing.Size(452, 122);
            this.item_view.TabIndex = 153;
            this.item_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_view_CellContentClick);
            // 
            // supplier_item_label
            // 
            this.supplier_item_label.AutoSize = true;
            this.supplier_item_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_item_label.ForeColor = System.Drawing.Color.White;
            this.supplier_item_label.Location = new System.Drawing.Point(31, 362);
            this.supplier_item_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplier_item_label.Name = "supplier_item_label";
            this.supplier_item_label.Size = new System.Drawing.Size(45, 16);
            this.supplier_item_label.TabIndex = 152;
            this.supplier_item_label.Text = "Items";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 164;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1025, 15);
            this.pictureBox1.TabIndex = 163;
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
            this.exit.TabIndex = 165;
            this.exit.Text = "x";
            // 
            // Profile_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1138, 596);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.add_item_button);
            this.Controls.Add(this.item_view);
            this.Controls.Add(this.supplier_item_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.supplier_view);
            this.Controls.Add(this.supplier_address_text);
            this.Controls.Add(this.cust_address_label);
            this.Controls.Add(this.supplier_contact_text);
            this.Controls.Add(this.cust_contact_label);
            this.Controls.Add(this.supplier_contact_person);
            this.Controls.Add(this.cust_lastname_label);
            this.Controls.Add(this.supplier_name_text);
            this.Controls.Add(this.cust_firstname_label);
            this.Controls.Add(this.customer_label);
            this.Controls.Add(this.supplier_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLTP AUTO REPAIR SHOP";
            this.Load += new System.EventHandler(this.Profile_Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplier_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox supplier_address_text;
        private System.Windows.Forms.Label cust_address_label;
        private System.Windows.Forms.TextBox supplier_contact_text;
        private System.Windows.Forms.Label cust_contact_label;
        private System.Windows.Forms.TextBox supplier_contact_person;
        private System.Windows.Forms.Label cust_lastname_label;
        private System.Windows.Forms.TextBox supplier_name_text;
        private System.Windows.Forms.Label cust_firstname_label;
        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.DataGridView supplier_view;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox supplier_id;
        private System.Windows.Forms.Button add_item_button;
        private System.Windows.Forms.DataGridView item_view;
        private System.Windows.Forms.Label supplier_item_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit;
    }
}