namespace WindowsFormsApp3
{
    partial class Profile_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cust_vehicles_label = new System.Windows.Forms.Label();
            this.cust_address_text = new System.Windows.Forms.TextBox();
            this.cust_address_label = new System.Windows.Forms.Label();
            this.cust_contact_text = new System.Windows.Forms.TextBox();
            this.cust_contact_label = new System.Windows.Forms.Label();
            this.cust_lastname_text = new System.Windows.Forms.TextBox();
            this.cust_lastname_label = new System.Windows.Forms.Label();
            this.cust_firstname_text = new System.Windows.Forms.TextBox();
            this.cust_firstname_label = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.add_vehicle_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.customer_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.company_name = new System.Windows.Forms.TextBox();
            this.customer_view = new System.Windows.Forms.DataGridView();
            this.vehicle_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_view)).BeginInit();
            this.SuspendLayout();
            // 
            // cust_vehicles_label
            // 
            this.cust_vehicles_label.AutoSize = true;
            this.cust_vehicles_label.BackColor = System.Drawing.Color.Transparent;
            this.cust_vehicles_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_vehicles_label.ForeColor = System.Drawing.Color.White;
            this.cust_vehicles_label.Location = new System.Drawing.Point(69, 380);
            this.cust_vehicles_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_vehicles_label.Name = "cust_vehicles_label";
            this.cust_vehicles_label.Size = new System.Drawing.Size(68, 16);
            this.cust_vehicles_label.TabIndex = 90;
            this.cust_vehicles_label.Text = "Vehicles";
            // 
            // cust_address_text
            // 
            this.cust_address_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_address_text.Location = new System.Drawing.Point(247, 291);
            this.cust_address_text.Margin = new System.Windows.Forms.Padding(4);
            this.cust_address_text.Name = "cust_address_text";
            this.cust_address_text.Size = new System.Drawing.Size(258, 26);
            this.cust_address_text.TabIndex = 88;
            // 
            // cust_address_label
            // 
            this.cust_address_label.AutoSize = true;
            this.cust_address_label.BackColor = System.Drawing.Color.Transparent;
            this.cust_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_address_label.ForeColor = System.Drawing.Color.White;
            this.cust_address_label.Location = new System.Drawing.Point(171, 297);
            this.cust_address_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_address_label.Name = "cust_address_label";
            this.cust_address_label.Size = new System.Drawing.Size(66, 16);
            this.cust_address_label.TabIndex = 87;
            this.cust_address_label.Text = "Address";
            // 
            // cust_contact_text
            // 
            this.cust_contact_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_contact_text.Location = new System.Drawing.Point(247, 258);
            this.cust_contact_text.Margin = new System.Windows.Forms.Padding(4);
            this.cust_contact_text.MaxLength = 11;
            this.cust_contact_text.Name = "cust_contact_text";
            this.cust_contact_text.Size = new System.Drawing.Size(258, 26);
            this.cust_contact_text.TabIndex = 86;
            this.cust_contact_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cust_contact_text_KeyPress);
            // 
            // cust_contact_label
            // 
            this.cust_contact_label.AutoSize = true;
            this.cust_contact_label.BackColor = System.Drawing.Color.Transparent;
            this.cust_contact_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_contact_label.ForeColor = System.Drawing.Color.White;
            this.cust_contact_label.Location = new System.Drawing.Point(119, 264);
            this.cust_contact_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_contact_label.Name = "cust_contact_label";
            this.cust_contact_label.Size = new System.Drawing.Size(118, 16);
            this.cust_contact_label.TabIndex = 85;
            this.cust_contact_label.Text = "Contact Number";
            // 
            // cust_lastname_text
            // 
            this.cust_lastname_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_lastname_text.Location = new System.Drawing.Point(247, 225);
            this.cust_lastname_text.Margin = new System.Windows.Forms.Padding(4);
            this.cust_lastname_text.Name = "cust_lastname_text";
            this.cust_lastname_text.Size = new System.Drawing.Size(258, 26);
            this.cust_lastname_text.TabIndex = 84;
            // 
            // cust_lastname_label
            // 
            this.cust_lastname_label.AutoSize = true;
            this.cust_lastname_label.BackColor = System.Drawing.Color.Transparent;
            this.cust_lastname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_lastname_label.ForeColor = System.Drawing.Color.White;
            this.cust_lastname_label.Location = new System.Drawing.Point(163, 231);
            this.cust_lastname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_lastname_label.Name = "cust_lastname_label";
            this.cust_lastname_label.Size = new System.Drawing.Size(75, 16);
            this.cust_lastname_label.TabIndex = 83;
            this.cust_lastname_label.Text = "Lastname";
            // 
            // cust_firstname_text
            // 
            this.cust_firstname_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_firstname_text.Location = new System.Drawing.Point(247, 193);
            this.cust_firstname_text.Margin = new System.Windows.Forms.Padding(4);
            this.cust_firstname_text.Name = "cust_firstname_text";
            this.cust_firstname_text.Size = new System.Drawing.Size(258, 26);
            this.cust_firstname_text.TabIndex = 82;
            // 
            // cust_firstname_label
            // 
            this.cust_firstname_label.AutoSize = true;
            this.cust_firstname_label.BackColor = System.Drawing.Color.Transparent;
            this.cust_firstname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_firstname_label.ForeColor = System.Drawing.Color.White;
            this.cust_firstname_label.Location = new System.Drawing.Point(163, 198);
            this.cust_firstname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_firstname_label.Name = "cust_firstname_label";
            this.cust_firstname_label.Size = new System.Drawing.Size(76, 16);
            this.cust_firstname_label.TabIndex = 81;
            this.cust_firstname_label.Text = "Firstname";
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_button.Enabled = false;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.Color.Transparent;
            this.update_button.Location = new System.Drawing.Point(867, 541);
            this.update_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(98, 27);
            this.update_button.TabIndex = 144;
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
            this.add_button.Location = new System.Drawing.Point(762, 541);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 27);
            this.add_button.TabIndex = 142;
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
            this.back_button.Location = new System.Drawing.Point(971, 42);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 146;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.Tomato;
            this.reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.Color.Transparent;
            this.reset_button.Location = new System.Drawing.Point(971, 541);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(104, 27);
            this.reset_button.TabIndex = 143;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(185, 106);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.ShortcutsEnabled = false;
            this.txtid.Size = new System.Drawing.Size(33, 24);
            this.txtid.TabIndex = 150;
            this.txtid.Visible = false;
            // 
            // add_vehicle_button
            // 
            this.add_vehicle_button.BackColor = System.Drawing.Color.Gray;
            this.add_vehicle_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_vehicle_button.Enabled = false;
            this.add_vehicle_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_vehicle_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_vehicle_button.ForeColor = System.Drawing.Color.White;
            this.add_vehicle_button.Location = new System.Drawing.Point(370, 369);
            this.add_vehicle_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_vehicle_button.Name = "add_vehicle_button";
            this.add_vehicle_button.Size = new System.Drawing.Size(135, 27);
            this.add_vehicle_button.TabIndex = 151;
            this.add_vehicle_button.Text = "Add Vehicle";
            this.add_vehicle_button.UseVisualStyleBackColor = false;
            this.add_vehicle_button.Click += new System.EventHandler(this.add_vehicle_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1025, 15);
            this.pictureBox1.TabIndex = 152;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 153;
            this.pictureBox2.TabStop = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1104, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 154;
            this.exit.Text = "x";
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.customer_label.ForeColor = System.Drawing.Color.White;
            this.customer_label.Location = new System.Drawing.Point(122, 85);
            this.customer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(208, 47);
            this.customer_label.TabIndex = 77;
            this.customer_label.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 155;
            this.label1.Text = "Company Name (optional)";
            // 
            // company_name
            // 
            this.company_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_name.Location = new System.Drawing.Point(247, 325);
            this.company_name.Margin = new System.Windows.Forms.Padding(4);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(258, 26);
            this.company_name.TabIndex = 156;
            // 
            // customer_view
            // 
            this.customer_view.AllowUserToAddRows = false;
            this.customer_view.AllowUserToDeleteRows = false;
            this.customer_view.AllowUserToResizeColumns = false;
            this.customer_view.AllowUserToResizeRows = false;
            this.customer_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customer_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.customer_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customer_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customer_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customer_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_view.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customer_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.customer_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.customer_view.Location = new System.Drawing.Point(548, 193);
            this.customer_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customer_view.MultiSelect = false;
            this.customer_view.Name = "customer_view";
            this.customer_view.ReadOnly = true;
            this.customer_view.RowHeadersVisible = false;
            this.customer_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.customer_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customer_view.Size = new System.Drawing.Size(526, 328);
            this.customer_view.TabIndex = 157;
            this.customer_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_view_CellClick_1);
            // 
            // vehicle_view
            // 
            this.vehicle_view.AllowUserToAddRows = false;
            this.vehicle_view.AllowUserToDeleteRows = false;
            this.vehicle_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vehicle_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.vehicle_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vehicle_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehicle_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vehicle_view.DefaultCellStyle = dataGridViewCellStyle4;
            this.vehicle_view.Location = new System.Drawing.Point(71, 403);
            this.vehicle_view.Name = "vehicle_view";
            this.vehicle_view.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehicle_view.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.vehicle_view.RowHeadersVisible = false;
            this.vehicle_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.vehicle_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehicle_view.Size = new System.Drawing.Size(433, 118);
            this.vehicle_view.TabIndex = 158;
            // 
            // Profile_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 592);
            this.Controls.Add(this.customer_view);
            this.Controls.Add(this.vehicle_view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.company_name);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.customer_label);
            this.Controls.Add(this.cust_contact_label);
            this.Controls.Add(this.cust_vehicles_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cust_address_label);
            this.Controls.Add(this.add_vehicle_button);
            this.Controls.Add(this.cust_firstname_label);
            this.Controls.Add(this.cust_lastname_label);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.cust_address_text);
            this.Controls.Add(this.cust_contact_text);
            this.Controls.Add(this.cust_lastname_text);
            this.Controls.Add(this.cust_firstname_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLTP AUTO REPAIR SHOP";
            this.Load += new System.EventHandler(this.Profile_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cust_vehicles_label;
        private System.Windows.Forms.TextBox cust_address_text;
        private System.Windows.Forms.Label cust_address_label;
        private System.Windows.Forms.TextBox cust_contact_text;
        private System.Windows.Forms.Label cust_contact_label;
        private System.Windows.Forms.TextBox cust_lastname_text;
        private System.Windows.Forms.Label cust_lastname_label;
        private System.Windows.Forms.TextBox cust_firstname_text;
        private System.Windows.Forms.Label cust_firstname_label;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button add_vehicle_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox company_name;
        private System.Windows.Forms.DataGridView customer_view;
        private System.Windows.Forms.DataGridView vehicle_view;
    }
}