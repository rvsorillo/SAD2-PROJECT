namespace WindowsFormsApp3
{
    partial class Sales_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Create));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sales_label = new System.Windows.Forms.Label();
            this.cust_label = new System.Windows.Forms.Label();
            this.cust_name_input = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_input = new System.Windows.Forms.DateTimePicker();
            this.remove_button = new System.Windows.Forms.Button();
            this.add_item_button = new System.Windows.Forms.Button();
            this.sales_item_view = new System.Windows.Forms.DataGridView();
            this.item_quantity_text = new System.Windows.Forms.TextBox();
            this.item_price_text = new System.Windows.Forms.TextBox();
            this.item_name_text = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.item_name_label = new System.Windows.Forms.Label();
            this.item_price_label = new System.Windows.Forms.Label();
            this.create_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.item_id_text = new System.Windows.Forms.TextBox();
            this.total_text = new System.Windows.Forms.TextBox();
            this.total_label = new System.Windows.Forms.Label();
            this.item_inventory = new System.Windows.Forms.TextBox();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.sales_id = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.brand_text = new System.Windows.Forms.TextBox();
            this.update_item = new System.Windows.Forms.Button();
            this.selected_sales_item_view = new System.Windows.Forms.DataGridView();
            this.itm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itm_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_details_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supp_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sales_item_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_sales_item_view)).BeginInit();
            this.SuspendLayout();
            // 
            // sales_label
            // 
            this.sales_label.AutoSize = true;
            this.sales_label.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_label.ForeColor = System.Drawing.Color.White;
            this.sales_label.Location = new System.Drawing.Point(127, 119);
            this.sales_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sales_label.Name = "sales_label";
            this.sales_label.Size = new System.Drawing.Size(358, 44);
            this.sales_label.TabIndex = 83;
            this.sales_label.Text = "Sales Transaction #";
            // 
            // cust_label
            // 
            this.cust_label.AutoSize = true;
            this.cust_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_label.ForeColor = System.Drawing.Color.White;
            this.cust_label.Location = new System.Drawing.Point(686, 125);
            this.cust_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_label.Name = "cust_label";
            this.cust_label.Size = new System.Drawing.Size(118, 16);
            this.cust_label.TabIndex = 80;
            this.cust_label.Text = "Customer Name";
            // 
            // cust_name_input
            // 
            this.cust_name_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_name_input.FormattingEnabled = true;
            this.cust_name_input.Location = new System.Drawing.Point(816, 119);
            this.cust_name_input.Name = "cust_name_input";
            this.cust_name_input.Size = new System.Drawing.Size(275, 28);
            this.cust_name_input.TabIndex = 84;
            this.cust_name_input.SelectedIndexChanged += new System.EventHandler(this.cust_name_input_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(677, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "Date of Purchase";
            // 
            // date_input
            // 
            this.date_input.Checked = false;
            this.date_input.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.date_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_input.Location = new System.Drawing.Point(816, 153);
            this.date_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date_input.Name = "date_input";
            this.date_input.Size = new System.Drawing.Size(275, 26);
            this.date_input.TabIndex = 98;
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Tomato;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove_button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.Location = new System.Drawing.Point(370, 503);
            this.remove_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(76, 27);
            this.remove_button.TabIndex = 137;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // add_item_button
            // 
            this.add_item_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_item_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_item_button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item_button.ForeColor = System.Drawing.Color.White;
            this.add_item_button.Location = new System.Drawing.Point(284, 503);
            this.add_item_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_item_button.Name = "add_item_button";
            this.add_item_button.Size = new System.Drawing.Size(80, 27);
            this.add_item_button.TabIndex = 136;
            this.add_item_button.Text = "Add";
            this.add_item_button.UseVisualStyleBackColor = false;
            this.add_item_button.Click += new System.EventHandler(this.add_item_button_Click);
            // 
            // sales_item_view
            // 
            this.sales_item_view.AllowUserToAddRows = false;
            this.sales_item_view.AllowUserToDeleteRows = false;
            this.sales_item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sales_item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sales_item_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sales_item_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.sales_item_view.Location = new System.Drawing.Point(53, 202);
            this.sales_item_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sales_item_view.Name = "sales_item_view";
            this.sales_item_view.ReadOnly = true;
            this.sales_item_view.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_item_view.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.sales_item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sales_item_view.Size = new System.Drawing.Size(487, 172);
            this.sales_item_view.TabIndex = 134;
            this.sales_item_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sales_item_view_CellClick);
            // 
            // item_quantity_text
            // 
            this.item_quantity_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity_text.Location = new System.Drawing.Point(233, 463);
            this.item_quantity_text.Multiline = true;
            this.item_quantity_text.Name = "item_quantity_text";
            this.item_quantity_text.Size = new System.Drawing.Size(307, 26);
            this.item_quantity_text.TabIndex = 133;
            this.item_quantity_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item_quantity_text_KeyPress);
            // 
            // item_price_text
            // 
            this.item_price_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_price_text.Location = new System.Drawing.Point(234, 425);
            this.item_price_text.Multiline = true;
            this.item_price_text.Name = "item_price_text";
            this.item_price_text.ReadOnly = true;
            this.item_price_text.Size = new System.Drawing.Size(305, 26);
            this.item_price_text.TabIndex = 132;
            // 
            // item_name_text
            // 
            this.item_name_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_text.Location = new System.Drawing.Point(234, 387);
            this.item_name_text.Multiline = true;
            this.item_name_text.Name = "item_name_text";
            this.item_name_text.ReadOnly = true;
            this.item_name_text.Size = new System.Drawing.Size(305, 26);
            this.item_name_text.TabIndex = 131;
            this.item_name_text.TextChanged += new System.EventHandler(this.item_name_text_TextChanged);
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.ForeColor = System.Drawing.Color.White;
            this.quantity_label.Location = new System.Drawing.Point(161, 468);
            this.quantity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(64, 16);
            this.quantity_label.TabIndex = 130;
            this.quantity_label.Text = "Quantity";
            // 
            // item_name_label
            // 
            this.item_name_label.AutoSize = true;
            this.item_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_label.ForeColor = System.Drawing.Color.White;
            this.item_name_label.Location = new System.Drawing.Point(144, 393);
            this.item_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item_name_label.Name = "item_name_label";
            this.item_name_label.Size = new System.Drawing.Size(82, 16);
            this.item_name_label.TabIndex = 129;
            this.item_name_label.Text = "Item Name";
            // 
            // item_price_label
            // 
            this.item_price_label.AutoSize = true;
            this.item_price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_price_label.ForeColor = System.Drawing.Color.White;
            this.item_price_label.Location = new System.Drawing.Point(149, 431);
            this.item_price_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item_price_label.Name = "item_price_label";
            this.item_price_label.Size = new System.Drawing.Size(77, 16);
            this.item_price_label.TabIndex = 128;
            this.item_price_label.Text = "Item Price";
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.create_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.create_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_button.ForeColor = System.Drawing.Color.White;
            this.create_button.Location = new System.Drawing.Point(924, 508);
            this.create_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(168, 37);
            this.create_button.TabIndex = 147;
            this.create_button.Text = "Create Transaction";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(987, 50);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 150;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // item_id_text
            // 
            this.item_id_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_id_text.Location = new System.Drawing.Point(439, 202);
            this.item_id_text.Multiline = true;
            this.item_id_text.Name = "item_id_text";
            this.item_id_text.Size = new System.Drawing.Size(38, 26);
            this.item_id_text.TabIndex = 152;
            // 
            // total_text
            // 
            this.total_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_text.Location = new System.Drawing.Point(979, 463);
            this.total_text.Multiline = true;
            this.total_text.Name = "total_text";
            this.total_text.Size = new System.Drawing.Size(112, 26);
            this.total_text.TabIndex = 155;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.Color.White;
            this.total_label.Location = new System.Drawing.Point(928, 468);
            this.total_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(44, 16);
            this.total_label.TabIndex = 154;
            this.total_label.Text = "Total";
            // 
            // item_inventory
            // 
            this.item_inventory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_inventory.Location = new System.Drawing.Point(483, 202);
            this.item_inventory.Multiline = true;
            this.item_inventory.Name = "item_inventory";
            this.item_inventory.Size = new System.Drawing.Size(41, 26);
            this.item_inventory.TabIndex = 156;
            // 
            // cust_id
            // 
            this.cust_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_id.Location = new System.Drawing.Point(392, 202);
            this.cust_id.Multiline = true;
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(41, 26);
            this.cust_id.TabIndex = 157;
            // 
            // sales_id
            // 
            this.sales_id.AutoSize = true;
            this.sales_id.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_id.ForeColor = System.Drawing.Color.White;
            this.sales_id.Location = new System.Drawing.Point(474, 119);
            this.sales_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sales_id.Name = "sales_id";
            this.sales_id.Size = new System.Drawing.Size(41, 44);
            this.sales_id.TabIndex = 158;
            this.sales_id.Text = "x";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 160;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1039, 15);
            this.pictureBox1.TabIndex = 159;
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
            this.exit.TabIndex = 161;
            this.exit.Text = "x";
            // 
            // brand_text
            // 
            this.brand_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_text.Location = new System.Drawing.Point(232, 348);
            this.brand_text.Multiline = true;
            this.brand_text.Name = "brand_text";
            this.brand_text.ReadOnly = true;
            this.brand_text.Size = new System.Drawing.Size(307, 26);
            this.brand_text.TabIndex = 162;
            // 
            // update_item
            // 
            this.update_item.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.update_item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_item.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_item.ForeColor = System.Drawing.Color.White;
            this.update_item.Location = new System.Drawing.Point(453, 503);
            this.update_item.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update_item.Name = "update_item";
            this.update_item.Size = new System.Drawing.Size(87, 27);
            this.update_item.TabIndex = 297;
            this.update_item.Text = "Update ";
            this.update_item.UseVisualStyleBackColor = false;
            this.update_item.Click += new System.EventHandler(this.update_item_Click);
            // 
            // selected_sales_item_view
            // 
            this.selected_sales_item_view.AllowUserToAddRows = false;
            this.selected_sales_item_view.AllowUserToDeleteRows = false;
            this.selected_sales_item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selected_sales_item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.selected_sales_item_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itm_name,
            this.Itm_Price,
            this.qty,
            this.subtotal_text,
            this.sales_details_id,
            this.sid,
            this.iid,
            this.sup});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.selected_sales_item_view.DefaultCellStyle = dataGridViewCellStyle5;
            this.selected_sales_item_view.Location = new System.Drawing.Point(562, 202);
            this.selected_sales_item_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selected_sales_item_view.Name = "selected_sales_item_view";
            this.selected_sales_item_view.ReadOnly = true;
            this.selected_sales_item_view.RowHeadersVisible = false;
            this.selected_sales_item_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.selected_sales_item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selected_sales_item_view.Size = new System.Drawing.Size(529, 252);
            this.selected_sales_item_view.TabIndex = 135;
            this.selected_sales_item_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selected_sales_item_view_CellClick);
            // 
            // itm_name
            // 
            this.itm_name.HeaderText = "Item Name";
            this.itm_name.Name = "itm_name";
            this.itm_name.ReadOnly = true;
            // 
            // Itm_Price
            // 
            this.Itm_Price.HeaderText = "Price";
            this.Itm_Price.Name = "Itm_Price";
            this.Itm_Price.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // subtotal_text
            // 
            this.subtotal_text.HeaderText = "Subtotal";
            this.subtotal_text.Name = "subtotal_text";
            this.subtotal_text.ReadOnly = true;
            // 
            // sales_details_id
            // 
            this.sales_details_id.HeaderText = "Sales Details ID";
            this.sales_details_id.Name = "sales_details_id";
            this.sales_details_id.ReadOnly = true;
            this.sales_details_id.Visible = false;
            // 
            // sid
            // 
            this.sid.HeaderText = "Sales ID";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.Visible = false;
            // 
            // iid
            // 
            this.iid.HeaderText = "Item ID";
            this.iid.Name = "iid";
            this.iid.ReadOnly = true;
            this.iid.Visible = false;
            // 
            // sup
            // 
            this.sup.HeaderText = "Supplier";
            this.sup.Name = "sup";
            this.sup.ReadOnly = true;
            // 
            // supp_name
            // 
            this.supp_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_name.Location = new System.Drawing.Point(235, 202);
            this.supp_name.Multiline = true;
            this.supp_name.Name = "supp_name";
            this.supp_name.ReadOnly = true;
            this.supp_name.Size = new System.Drawing.Size(305, 26);
            this.supp_name.TabIndex = 299;
            // 
            // Sales_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 592);
            this.Controls.Add(this.update_item);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sales_id);
            this.Controls.Add(this.total_text);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.add_item_button);
            this.Controls.Add(this.selected_sales_item_view);
            this.Controls.Add(this.sales_item_view);
            this.Controls.Add(this.item_quantity_text);
            this.Controls.Add(this.item_price_text);
            this.Controls.Add(this.item_name_text);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.item_name_label);
            this.Controls.Add(this.item_price_label);
            this.Controls.Add(this.date_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sales_label);
            this.Controls.Add(this.cust_label);
            this.Controls.Add(this.cust_name_input);
            this.Controls.Add(this.cust_id);
            this.Controls.Add(this.item_inventory);
            this.Controls.Add(this.item_id_text);
            this.Controls.Add(this.brand_text);
            this.Controls.Add(this.supp_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Sales_Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sales_item_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_sales_item_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sales_label;
        private System.Windows.Forms.Label cust_label;
        private System.Windows.Forms.ComboBox cust_name_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_input;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button add_item_button;
        private System.Windows.Forms.DataGridView sales_item_view;
        private System.Windows.Forms.TextBox item_quantity_text;
        private System.Windows.Forms.TextBox item_price_text;
        private System.Windows.Forms.TextBox item_name_text;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label item_name_label;
        private System.Windows.Forms.Label item_price_label;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox item_id_text;
        private System.Windows.Forms.TextBox total_text;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.TextBox item_inventory;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.Label sales_id;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.TextBox brand_text;
        private System.Windows.Forms.Button update_item;
        private System.Windows.Forms.DataGridView selected_sales_item_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn itm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itm_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_details_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sup;
        private System.Windows.Forms.TextBox supp_name;
    }
}