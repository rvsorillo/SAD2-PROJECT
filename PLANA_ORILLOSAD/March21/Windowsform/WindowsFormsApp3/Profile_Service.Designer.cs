namespace WindowsFormsApp3
{
    partial class Profile_Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Service));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.item_id = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.service_label = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.service_view = new System.Windows.Forms.DataGridView();
            this.service_type_text = new System.Windows.Forms.TextBox();
            this.service_type_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.item_name_text = new System.Windows.Forms.ComboBox();
            this.emp_position_label = new System.Windows.Forms.Label();
            this.add_item = new System.Windows.Forms.Button();
            this.remove_item = new System.Windows.Forms.Button();
            this.brand_text = new System.Windows.Forms.TextBox();
            this.measure_text = new System.Windows.Forms.TextBox();
            this.purchase_price_text = new System.Windows.Forms.TextBox();
            this.selling_price_text = new System.Windows.Forms.TextBox();
            this.supplier_id = new System.Windows.Forms.TextBox();
            this.supplier_text = new System.Windows.Forms.TextBox();
            this.service_items_view = new System.Windows.Forms.DataGridView();
            this.service_id = new System.Windows.Forms.TextBox();
            this.servid = new System.Windows.Forms.TextBox();
            this.reset_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.service_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_items_view)).BeginInit();
            this.SuspendLayout();
            // 
            // item_id
            // 
            this.item_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_id.Location = new System.Drawing.Point(483, 256);
            this.item_id.Multiline = true;
            this.item_id.Name = "item_id";
            this.item_id.Size = new System.Drawing.Size(39, 26);
            this.item_id.TabIndex = 160;
            this.item_id.Visible = false;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(970, 41);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 159;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // service_label
            // 
            this.service_label.AutoSize = true;
            this.service_label.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_label.ForeColor = System.Drawing.Color.White;
            this.service_label.Location = new System.Drawing.Point(122, 88);
            this.service_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.service_label.Name = "service_label";
            this.service_label.Size = new System.Drawing.Size(169, 44);
            this.service_label.TabIndex = 158;
            this.service_label.Text = "Services";
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.Tomato;
            this.reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(312, 519);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(104, 27);
            this.reset_button.TabIndex = 156;
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
            this.update_button.Location = new System.Drawing.Point(208, 519);
            this.update_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(98, 27);
            this.update_button.TabIndex = 155;
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
            this.add_button.Location = new System.Drawing.Point(107, 519);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(95, 27);
            this.add_button.TabIndex = 154;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // service_view
            // 
            this.service_view.AllowUserToAddRows = false;
            this.service_view.AllowUserToDeleteRows = false;
            this.service_view.AllowUserToResizeColumns = false;
            this.service_view.AllowUserToResizeRows = false;
            this.service_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.service_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.service_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.service_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.service_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.service_view.ColumnHeadersHeight = 26;
            this.service_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.service_view.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.service_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.service_view.Location = new System.Drawing.Point(50, 222);
            this.service_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.service_view.MultiSelect = false;
            this.service_view.Name = "service_view";
            this.service_view.ReadOnly = true;
            this.service_view.RowHeadersVisible = false;
            this.service_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.service_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.service_view.Size = new System.Drawing.Size(365, 290);
            this.service_view.TabIndex = 153;
            this.service_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.service_view_CellClick);
            // 
            // service_type_text
            // 
            this.service_type_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_type_text.Location = new System.Drawing.Point(156, 185);
            this.service_type_text.Multiline = true;
            this.service_type_text.Name = "service_type_text";
            this.service_type_text.Size = new System.Drawing.Size(259, 26);
            this.service_type_text.TabIndex = 152;
            this.service_type_text.TextChanged += new System.EventHandler(this.service_type_text_TextChanged);
            // 
            // service_type_label
            // 
            this.service_type_label.AutoSize = true;
            this.service_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_type_label.ForeColor = System.Drawing.Color.White;
            this.service_type_label.Location = new System.Drawing.Point(47, 191);
            this.service_type_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.service_type_label.Name = "service_type_label";
            this.service_type_label.Size = new System.Drawing.Size(101, 16);
            this.service_type_label.TabIndex = 151;
            this.service_type_label.Text = "Service Type";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 162;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1025, 15);
            this.pictureBox1.TabIndex = 161;
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
            this.exit.TabIndex = 163;
            this.exit.Text = "x";
            // 
            // item_name_text
            // 
            this.item_name_text.Enabled = false;
            this.item_name_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_text.FormattingEnabled = true;
            this.item_name_text.Location = new System.Drawing.Point(858, 185);
            this.item_name_text.Name = "item_name_text";
            this.item_name_text.Size = new System.Drawing.Size(216, 28);
            this.item_name_text.TabIndex = 166;
            this.item_name_text.SelectedIndexChanged += new System.EventHandler(this.item_name_text_SelectedIndexChanged);
            // 
            // emp_position_label
            // 
            this.emp_position_label.AutoSize = true;
            this.emp_position_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_position_label.ForeColor = System.Drawing.Color.White;
            this.emp_position_label.Location = new System.Drawing.Point(769, 191);
            this.emp_position_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emp_position_label.Name = "emp_position_label";
            this.emp_position_label.Size = new System.Drawing.Size(82, 16);
            this.emp_position_label.TabIndex = 165;
            this.emp_position_label.Text = "Item Name";
            // 
            // add_item
            // 
            this.add_item.BackColor = System.Drawing.Color.DimGray;
            this.add_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_item.Enabled = false;
            this.add_item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_item.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.add_item.ForeColor = System.Drawing.Color.White;
            this.add_item.Location = new System.Drawing.Point(859, 221);
            this.add_item.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(103, 27);
            this.add_item.TabIndex = 167;
            this.add_item.Text = "Add";
            this.add_item.UseVisualStyleBackColor = false;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // remove_item
            // 
            this.remove_item.BackColor = System.Drawing.Color.DimGray;
            this.remove_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_item.Enabled = false;
            this.remove_item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove_item.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.remove_item.ForeColor = System.Drawing.Color.White;
            this.remove_item.Location = new System.Drawing.Point(971, 221);
            this.remove_item.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.remove_item.Name = "remove_item";
            this.remove_item.Size = new System.Drawing.Size(104, 27);
            this.remove_item.TabIndex = 168;
            this.remove_item.Text = "Remove";
            this.remove_item.UseVisualStyleBackColor = false;
            this.remove_item.Click += new System.EventHandler(this.remove_item_Click);
            // 
            // brand_text
            // 
            this.brand_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_text.Location = new System.Drawing.Point(526, 257);
            this.brand_text.Multiline = true;
            this.brand_text.Name = "brand_text";
            this.brand_text.Size = new System.Drawing.Size(39, 26);
            this.brand_text.TabIndex = 169;
            this.brand_text.Visible = false;
            // 
            // measure_text
            // 
            this.measure_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measure_text.Location = new System.Drawing.Point(568, 257);
            this.measure_text.Multiline = true;
            this.measure_text.Name = "measure_text";
            this.measure_text.Size = new System.Drawing.Size(39, 26);
            this.measure_text.TabIndex = 170;
            this.measure_text.Visible = false;
            // 
            // purchase_price_text
            // 
            this.purchase_price_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_price_text.Location = new System.Drawing.Point(619, 257);
            this.purchase_price_text.Multiline = true;
            this.purchase_price_text.Name = "purchase_price_text";
            this.purchase_price_text.Size = new System.Drawing.Size(39, 26);
            this.purchase_price_text.TabIndex = 171;
            this.purchase_price_text.Visible = false;
            // 
            // selling_price_text
            // 
            this.selling_price_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selling_price_text.Location = new System.Drawing.Point(664, 256);
            this.selling_price_text.Multiline = true;
            this.selling_price_text.Name = "selling_price_text";
            this.selling_price_text.Size = new System.Drawing.Size(39, 26);
            this.selling_price_text.TabIndex = 172;
            this.selling_price_text.Visible = false;
            // 
            // supplier_id
            // 
            this.supplier_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_id.Location = new System.Drawing.Point(749, 257);
            this.supplier_id.Multiline = true;
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.Size = new System.Drawing.Size(39, 26);
            this.supplier_id.TabIndex = 173;
            this.supplier_id.Visible = false;
            // 
            // supplier_text
            // 
            this.supplier_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_text.Location = new System.Drawing.Point(709, 256);
            this.supplier_text.Multiline = true;
            this.supplier_text.Name = "supplier_text";
            this.supplier_text.Size = new System.Drawing.Size(39, 26);
            this.supplier_text.TabIndex = 174;
            this.supplier_text.Visible = false;
            // 
            // service_items_view
            // 
            this.service_items_view.AllowUserToAddRows = false;
            this.service_items_view.AllowUserToDeleteRows = false;
            this.service_items_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.service_items_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.service_items_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.service_items_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.service_items_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.service_items_view.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.service_items_view.DefaultCellStyle = dataGridViewCellStyle4;
            this.service_items_view.Location = new System.Drawing.Point(442, 255);
            this.service_items_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.service_items_view.Name = "service_items_view";
            this.service_items_view.ReadOnly = true;
            this.service_items_view.RowHeadersVisible = false;
            this.service_items_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.service_items_view.Size = new System.Drawing.Size(633, 258);
            this.service_items_view.TabIndex = 185;
            this.service_items_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.service_items_view_CellClick);
            // 
            // service_id
            // 
            this.service_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_id.Location = new System.Drawing.Point(122, 88);
            this.service_id.Multiline = true;
            this.service_id.Name = "service_id";
            this.service_id.Size = new System.Drawing.Size(42, 26);
            this.service_id.TabIndex = 186;
            // 
            // servid
            // 
            this.servid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servid.Location = new System.Drawing.Point(122, 88);
            this.servid.Multiline = true;
            this.servid.Name = "servid";
            this.servid.Size = new System.Drawing.Size(42, 26);
            this.servid.TabIndex = 187;
            // 
            // reset_label
            // 
            this.reset_label.AutoSize = true;
            this.reset_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reset_label.Location = new System.Drawing.Point(439, 236);
            this.reset_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reset_label.Name = "reset_label";
            this.reset_label.Size = new System.Drawing.Size(0, 16);
            this.reset_label.TabIndex = 290;
            this.reset_label.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(439, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 16);
            this.label5.TabIndex = 291;
            this.label5.Text = "* Select from Service Type List before adding/removing items";
            // 
            // Profile_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1138, 596);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reset_label);
            this.Controls.Add(this.service_items_view);
            this.Controls.Add(this.remove_item);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.item_name_text);
            this.Controls.Add(this.emp_position_label);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.service_label);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.service_view);
            this.Controls.Add(this.service_type_text);
            this.Controls.Add(this.service_type_label);
            this.Controls.Add(this.supplier_text);
            this.Controls.Add(this.supplier_id);
            this.Controls.Add(this.selling_price_text);
            this.Controls.Add(this.purchase_price_text);
            this.Controls.Add(this.measure_text);
            this.Controls.Add(this.brand_text);
            this.Controls.Add(this.item_id);
            this.Controls.Add(this.servid);
            this.Controls.Add(this.service_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile_Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile_Service";
            this.Load += new System.EventHandler(this.Profile_Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.service_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_items_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox item_id;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label service_label;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView service_view;
        private System.Windows.Forms.TextBox service_type_text;
        private System.Windows.Forms.Label service_type_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.ComboBox item_name_text;
        private System.Windows.Forms.Label emp_position_label;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button remove_item;
        private System.Windows.Forms.TextBox brand_text;
        private System.Windows.Forms.TextBox measure_text;
        private System.Windows.Forms.TextBox purchase_price_text;
        private System.Windows.Forms.TextBox selling_price_text;
        private System.Windows.Forms.TextBox supplier_id;
        private System.Windows.Forms.TextBox supplier_text;
        private System.Windows.Forms.DataGridView service_items_view;
        private System.Windows.Forms.TextBox service_id;
        private System.Windows.Forms.TextBox servid;
        private System.Windows.Forms.Label reset_label;
        private System.Windows.Forms.Label label5;
    }
}