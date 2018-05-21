namespace WindowsFormsApp3
{
    partial class Purchase_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_Order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exit = new System.Windows.Forms.Label();
            this.remove_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.purch_id = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.supplier_id = new System.Windows.Forms.TextBox();
            this.item_id = new System.Windows.Forms.TextBox();
            this.stock_in_view = new System.Windows.Forms.DataGridView();
            this.iname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_meas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isupp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isuppid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reset_button = new System.Windows.Forms.Button();
            this.item_quantity_text = new System.Windows.Forms.TextBox();
            this.item_name_text = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.item_name_label = new System.Windows.Forms.Label();
            this.supplier_text = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.item_view = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.total_text = new System.Windows.Forms.TextBox();
            this.purchase_price_text = new System.Windows.Forms.TextBox();
            this.selling_price_text = new System.Windows.Forms.TextBox();
            this.create_button = new System.Windows.Forms.Button();
            this.measure_text = new System.Windows.Forms.TextBox();
            this.brand_text = new System.Windows.Forms.TextBox();
            this.date_input = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_input = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emp_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_in_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1078, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 200;
            this.exit.Text = "x";
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Tomato;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove_button.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.Location = new System.Drawing.Point(894, 307);
            this.remove_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(80, 27);
            this.remove_button.TabIndex = 199;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 198;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 22);
            this.pictureBox1.TabIndex = 197;
            this.pictureBox1.TabStop = false;
            // 
            // purch_id
            // 
            this.purch_id.AutoSize = true;
            this.purch_id.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purch_id.ForeColor = System.Drawing.Color.White;
            this.purch_id.Location = new System.Drawing.Point(572, 92);
            this.purch_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.purch_id.Name = "purch_id";
            this.purch_id.Size = new System.Drawing.Size(41, 44);
            this.purch_id.TabIndex = 192;
            this.purch_id.Text = "x";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(958, 36);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 186;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 44);
            this.label3.TabIndex = 185;
            this.label3.Text = "Create Purchase Order #";
            // 
            // supplier_id
            // 
            this.supplier_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_id.Location = new System.Drawing.Point(163, 98);
            this.supplier_id.Multiline = true;
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.Size = new System.Drawing.Size(37, 26);
            this.supplier_id.TabIndex = 194;
            this.supplier_id.Visible = false;
            // 
            // item_id
            // 
            this.item_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_id.Location = new System.Drawing.Point(122, 98);
            this.item_id.Multiline = true;
            this.item_id.Name = "item_id";
            this.item_id.Size = new System.Drawing.Size(35, 26);
            this.item_id.TabIndex = 193;
            this.item_id.Visible = false;
            // 
            // stock_in_view
            // 
            this.stock_in_view.AllowUserToAddRows = false;
            this.stock_in_view.AllowUserToDeleteRows = false;
            this.stock_in_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stock_in_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stock_in_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iname,
            this.i_brand,
            this.i_meas,
            this.isp,
            this.ipp,
            this.iqty,
            this.isupp,
            this.isuppid,
            this.iid,
            this.subt,
            this.request});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stock_in_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.stock_in_view.Location = new System.Drawing.Point(50, 339);
            this.stock_in_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stock_in_view.Name = "stock_in_view";
            this.stock_in_view.ReadOnly = true;
            this.stock_in_view.RowHeadersVisible = false;
            this.stock_in_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stock_in_view.Size = new System.Drawing.Size(1012, 128);
            this.stock_in_view.TabIndex = 184;
            this.stock_in_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stock_in_view_CellClick);
            // 
            // iname
            // 
            this.iname.HeaderText = "Item Name";
            this.iname.Name = "iname";
            this.iname.ReadOnly = true;
            // 
            // i_brand
            // 
            this.i_brand.HeaderText = "Brand";
            this.i_brand.Name = "i_brand";
            this.i_brand.ReadOnly = true;
            // 
            // i_meas
            // 
            this.i_meas.HeaderText = "Measurement";
            this.i_meas.Name = "i_meas";
            this.i_meas.ReadOnly = true;
            // 
            // isp
            // 
            this.isp.HeaderText = "Selling Price";
            this.isp.Name = "isp";
            this.isp.ReadOnly = true;
            this.isp.Visible = false;
            // 
            // ipp
            // 
            this.ipp.HeaderText = "Price";
            this.ipp.Name = "ipp";
            this.ipp.ReadOnly = true;
            // 
            // iqty
            // 
            this.iqty.HeaderText = "Quantity";
            this.iqty.Name = "iqty";
            this.iqty.ReadOnly = true;
            // 
            // isupp
            // 
            this.isupp.HeaderText = "Supplier";
            this.isupp.Name = "isupp";
            this.isupp.ReadOnly = true;
            this.isupp.Visible = false;
            // 
            // isuppid
            // 
            this.isuppid.HeaderText = "Supplier ID";
            this.isuppid.Name = "isuppid";
            this.isuppid.ReadOnly = true;
            this.isuppid.Visible = false;
            // 
            // iid
            // 
            this.iid.HeaderText = "Item ID";
            this.iid.Name = "iid";
            this.iid.ReadOnly = true;
            this.iid.Visible = false;
            // 
            // subt
            // 
            this.subt.HeaderText = "Subtotal";
            this.subt.Name = "subt";
            this.subt.ReadOnly = true;
            // 
            // request
            // 
            this.request.HeaderText = "Requested By";
            this.request.Name = "request";
            this.request.ReadOnly = true;
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_button.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(982, 307);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(80, 27);
            this.reset_button.TabIndex = 177;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // item_quantity_text
            // 
            this.item_quantity_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity_text.Location = new System.Drawing.Point(809, 241);
            this.item_quantity_text.Multiline = true;
            this.item_quantity_text.Name = "item_quantity_text";
            this.item_quantity_text.Size = new System.Drawing.Size(253, 26);
            this.item_quantity_text.TabIndex = 176;
            this.item_quantity_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item_quantity_text_KeyPress);
            // 
            // item_name_text
            // 
            this.item_name_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item_name_text.Location = new System.Drawing.Point(809, 208);
            this.item_name_text.Multiline = true;
            this.item_name_text.Name = "item_name_text";
            this.item_name_text.ReadOnly = true;
            this.item_name_text.Size = new System.Drawing.Size(252, 26);
            this.item_name_text.TabIndex = 175;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.ForeColor = System.Drawing.Color.White;
            this.quantity_label.Location = new System.Drawing.Point(738, 248);
            this.quantity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(64, 16);
            this.quantity_label.TabIndex = 174;
            this.quantity_label.Text = "Quantity";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(809, 307);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(77, 27);
            this.add_button.TabIndex = 173;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // item_name_label
            // 
            this.item_name_label.AutoSize = true;
            this.item_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_label.ForeColor = System.Drawing.Color.White;
            this.item_name_label.Location = new System.Drawing.Point(723, 214);
            this.item_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item_name_label.Name = "item_name_label";
            this.item_name_label.Size = new System.Drawing.Size(82, 16);
            this.item_name_label.TabIndex = 172;
            this.item_name_label.Text = "Item Name";
            // 
            // supplier_text
            // 
            this.supplier_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_text.FormattingEnabled = true;
            this.supplier_text.Location = new System.Drawing.Point(808, 174);
            this.supplier_text.Name = "supplier_text";
            this.supplier_text.Size = new System.Drawing.Size(253, 28);
            this.supplier_text.TabIndex = 286;
            this.supplier_text.SelectedIndexChanged += new System.EventHandler(this.supplier_text_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(736, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 285;
            this.label4.Text = "Supplier";
            // 
            // item_view
            // 
            this.item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.item_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_view.DefaultCellStyle = dataGridViewCellStyle4;
            this.item_view.Location = new System.Drawing.Point(50, 173);
            this.item_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.item_view.Name = "item_view";
            this.item_view.RowHeadersVisible = false;
            this.item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_view.Size = new System.Drawing.Size(634, 133);
            this.item_view.TabIndex = 287;
            this.item_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_view_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(906, 478);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 289;
            this.label7.Text = "Total";
            // 
            // total_text
            // 
            this.total_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.total_text.Location = new System.Drawing.Point(957, 473);
            this.total_text.Multiline = true;
            this.total_text.Name = "total_text";
            this.total_text.ReadOnly = true;
            this.total_text.Size = new System.Drawing.Size(104, 26);
            this.total_text.TabIndex = 288;
            // 
            // purchase_price_text
            // 
            this.purchase_price_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_price_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.purchase_price_text.Location = new System.Drawing.Point(605, 184);
            this.purchase_price_text.Multiline = true;
            this.purchase_price_text.Name = "purchase_price_text";
            this.purchase_price_text.ReadOnly = true;
            this.purchase_price_text.Size = new System.Drawing.Size(10, 26);
            this.purchase_price_text.TabIndex = 294;
            this.purchase_price_text.Visible = false;
            // 
            // selling_price_text
            // 
            this.selling_price_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selling_price_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.selling_price_text.Location = new System.Drawing.Point(606, 218);
            this.selling_price_text.Multiline = true;
            this.selling_price_text.Name = "selling_price_text";
            this.selling_price_text.ReadOnly = true;
            this.selling_price_text.Size = new System.Drawing.Size(10, 26);
            this.selling_price_text.TabIndex = 293;
            this.selling_price_text.Visible = false;
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.create_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.create_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_button.ForeColor = System.Drawing.Color.White;
            this.create_button.Location = new System.Drawing.Point(853, 506);
            this.create_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(208, 27);
            this.create_button.TabIndex = 292;
            this.create_button.Text = "Create Purchase Order";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // measure_text
            // 
            this.measure_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measure_text.Location = new System.Drawing.Point(561, 219);
            this.measure_text.Multiline = true;
            this.measure_text.Name = "measure_text";
            this.measure_text.Size = new System.Drawing.Size(10, 26);
            this.measure_text.TabIndex = 296;
            this.measure_text.Visible = false;
            // 
            // brand_text
            // 
            this.brand_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.brand_text.Location = new System.Drawing.Point(561, 184);
            this.brand_text.Multiline = true;
            this.brand_text.Name = "brand_text";
            this.brand_text.ReadOnly = true;
            this.brand_text.Size = new System.Drawing.Size(10, 26);
            this.brand_text.TabIndex = 295;
            this.brand_text.Visible = false;
            // 
            // date_input
            // 
            this.date_input.Checked = false;
            this.date_input.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.date_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_input.Location = new System.Drawing.Point(783, 102);
            this.date_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date_input.Name = "date_input";
            this.date_input.Size = new System.Drawing.Size(280, 26);
            this.date_input.TabIndex = 298;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(738, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 297;
            this.label2.Text = "Date";
            // 
            // employee_input
            // 
            this.employee_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_input.FormattingEnabled = true;
            this.employee_input.Location = new System.Drawing.Point(809, 273);
            this.employee_input.Name = "employee_input";
            this.employee_input.Size = new System.Drawing.Size(253, 28);
            this.employee_input.TabIndex = 299;
            this.employee_input.SelectedIndexChanged += new System.EventHandler(this.employee_input_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(700, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 300;
            this.label1.Text = "Requested by";
            // 
            // emp_id
            // 
            this.emp_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.emp_id.Location = new System.Drawing.Point(649, 176);
            this.emp_id.Multiline = true;
            this.emp_id.Name = "emp_id";
            this.emp_id.ReadOnly = true;
            this.emp_id.Size = new System.Drawing.Size(35, 26);
            this.emp_id.TabIndex = 301;
            // 
            // Purchase_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1118, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employee_input);
            this.Controls.Add(this.date_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total_text);
            this.Controls.Add(this.item_view);
            this.Controls.Add(this.supplier_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.purch_id);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplier_id);
            this.Controls.Add(this.item_id);
            this.Controls.Add(this.stock_in_view);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.item_quantity_text);
            this.Controls.Add(this.item_name_text);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.item_name_label);
            this.Controls.Add(this.purchase_price_text);
            this.Controls.Add(this.selling_price_text);
            this.Controls.Add(this.measure_text);
            this.Controls.Add(this.brand_text);
            this.Controls.Add(this.emp_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Purchase_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_in_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label purch_id;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supplier_id;
        private System.Windows.Forms.TextBox item_id;
        private System.Windows.Forms.DataGridView stock_in_view;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TextBox item_quantity_text;
        private System.Windows.Forms.TextBox item_name_text;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label item_name_label;
        private System.Windows.Forms.ComboBox supplier_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView item_view;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox total_text;
        private System.Windows.Forms.TextBox purchase_price_text;
        private System.Windows.Forms.TextBox selling_price_text;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.TextBox measure_text;
        private System.Windows.Forms.TextBox brand_text;
        private System.Windows.Forms.DateTimePicker date_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox employee_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn iname;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_meas;
        private System.Windows.Forms.DataGridViewTextBoxColumn isp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipp;
        private System.Windows.Forms.DataGridViewTextBoxColumn iqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn isupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn isuppid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subt;
        private System.Windows.Forms.DataGridViewTextBoxColumn request;
    }
}