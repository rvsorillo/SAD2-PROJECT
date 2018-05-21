namespace WindowsFormsApp3
{
    partial class Stock_in
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_in));
            this.label2 = new System.Windows.Forms.Label();
            this.stock_date = new System.Windows.Forms.DateTimePicker();
            this.reset_button = new System.Windows.Forms.Button();
            this.item_quantity_text = new System.Windows.Forms.TextBox();
            this.item_name_text = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.item_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.del_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.stock_in_view = new System.Windows.Forms.DataGridView();
            this.iname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isupp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isuppid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.item_view = new System.Windows.Forms.DataGridView();
            this.selling_price_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.purchase_price_text = new System.Windows.Forms.TextBox();
            this.stock_in_id = new System.Windows.Forms.Label();
            this.item_id = new System.Windows.Forms.TextBox();
            this.supplier_id = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.stock_in_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.supplier_text = new System.Windows.Forms.ComboBox();
            this.item_inventory = new System.Windows.Forms.TextBox();
            this.purch_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stock_in_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(693, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 132;
            this.label2.Text = "Stock in Date";
            // 
            // stock_date
            // 
            this.stock_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_date.Location = new System.Drawing.Point(801, 137);
            this.stock_date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stock_date.Name = "stock_date";
            this.stock_date.Size = new System.Drawing.Size(273, 26);
            this.stock_date.TabIndex = 131;
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_button.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(993, 330);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(80, 27);
            this.reset_button.TabIndex = 130;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // item_quantity_text
            // 
            this.item_quantity_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity_text.Location = new System.Drawing.Point(829, 228);
            this.item_quantity_text.Multiline = true;
            this.item_quantity_text.Name = "item_quantity_text";
            this.item_quantity_text.Size = new System.Drawing.Size(244, 26);
            this.item_quantity_text.TabIndex = 128;
            this.item_quantity_text.TextChanged += new System.EventHandler(this.item_quantity_text_TextChanged);
            this.item_quantity_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item_quantity_text_KeyPress);
            // 
            // item_name_text
            // 
            this.item_name_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item_name_text.Location = new System.Drawing.Point(829, 194);
            this.item_name_text.Multiline = true;
            this.item_name_text.Name = "item_name_text";
            this.item_name_text.ReadOnly = true;
            this.item_name_text.Size = new System.Drawing.Size(243, 26);
            this.item_name_text.TabIndex = 127;
            this.item_name_text.TextChanged += new System.EventHandler(this.item_name_text_TextChanged);
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.ForeColor = System.Drawing.Color.White;
            this.quantity_label.Location = new System.Drawing.Point(756, 234);
            this.quantity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(64, 16);
            this.quantity_label.TabIndex = 126;
            this.quantity_label.Text = "Quantity";
            this.quantity_label.Click += new System.EventHandler(this.quantity_label_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(828, 330);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(77, 27);
            this.add_button.TabIndex = 125;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // item_name_label
            // 
            this.item_name_label.AutoSize = true;
            this.item_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_label.ForeColor = System.Drawing.Color.White;
            this.item_name_label.Location = new System.Drawing.Point(741, 198);
            this.item_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item_name_label.Name = "item_name_label";
            this.item_name_label.Size = new System.Drawing.Size(82, 16);
            this.item_name_label.TabIndex = 124;
            this.item_name_label.Text = "Item Name";
            this.item_name_label.Click += new System.EventHandler(this.item_name_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(693, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 134;
            this.label1.Text = "Delivery Date";
            // 
            // del_date
            // 
            this.del_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_date.Location = new System.Drawing.Point(801, 101);
            this.del_date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.del_date.Name = "del_date";
            this.del_date.Size = new System.Drawing.Size(273, 26);
            this.del_date.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(232, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 135;
            this.label4.Text = "Supplier";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // stock_in_view
            // 
            this.stock_in_view.AllowUserToAddRows = false;
            this.stock_in_view.AllowUserToDeleteRows = false;
            this.stock_in_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stock_in_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.stock_in_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iname,
            this.isp,
            this.ipp,
            this.iqty,
            this.isupp,
            this.isuppid,
            this.idel,
            this.istock,
            this.iid,
            this.ppid});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stock_in_view.DefaultCellStyle = dataGridViewCellStyle18;
            this.stock_in_view.Location = new System.Drawing.Point(558, 364);
            this.stock_in_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stock_in_view.Name = "stock_in_view";
            this.stock_in_view.ReadOnly = true;
            this.stock_in_view.RowHeadersVisible = false;
            this.stock_in_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stock_in_view.Size = new System.Drawing.Size(516, 164);
            this.stock_in_view.TabIndex = 139;
            // 
            // iname
            // 
            this.iname.HeaderText = "Item Name";
            this.iname.Name = "iname";
            this.iname.ReadOnly = true;
            // 
            // isp
            // 
            this.isp.HeaderText = "Selling Price";
            this.isp.Name = "isp";
            this.isp.ReadOnly = true;
            // 
            // ipp
            // 
            this.ipp.HeaderText = "Purchase Price";
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
            // 
            // isuppid
            // 
            this.isuppid.HeaderText = "Supplier ID";
            this.isuppid.Name = "isuppid";
            this.isuppid.ReadOnly = true;
            this.isuppid.Visible = false;
            // 
            // idel
            // 
            this.idel.HeaderText = "Delivery Date";
            this.idel.Name = "idel";
            this.idel.ReadOnly = true;
            this.idel.Visible = false;
            // 
            // istock
            // 
            this.istock.HeaderText = "Stock in Date";
            this.istock.Name = "istock";
            this.istock.ReadOnly = true;
            this.istock.Visible = false;
            // 
            // iid
            // 
            this.iid.HeaderText = "Item ID";
            this.iid.Name = "iid";
            this.iid.ReadOnly = true;
            this.iid.Visible = false;
            // 
            // ppid
            // 
            this.ppid.HeaderText = "Purch ID";
            this.ppid.Name = "ppid";
            this.ppid.ReadOnly = true;
            this.ppid.Visible = false;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(970, 50);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 142;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(126, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 44);
            this.label3.TabIndex = 141;
            this.label3.Text = "Stock in #";
            // 
            // item_view
            // 
            this.item_view.AllowUserToAddRows = false;
            this.item_view.AllowUserToDeleteRows = false;
            this.item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.item_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_view.DefaultCellStyle = dataGridViewCellStyle20;
            this.item_view.Location = new System.Drawing.Point(57, 262);
            this.item_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.item_view.Name = "item_view";
            this.item_view.ReadOnly = true;
            this.item_view.RowHeadersVisible = false;
            this.item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_view.Size = new System.Drawing.Size(493, 266);
            this.item_view.TabIndex = 143;
            this.item_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_view_CellClick);
            // 
            // selling_price_text
            // 
            this.selling_price_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selling_price_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.selling_price_text.Location = new System.Drawing.Point(829, 296);
            this.selling_price_text.Multiline = true;
            this.selling_price_text.Name = "selling_price_text";
            this.selling_price_text.ReadOnly = true;
            this.selling_price_text.Size = new System.Drawing.Size(244, 26);
            this.selling_price_text.TabIndex = 144;
            this.selling_price_text.TextChanged += new System.EventHandler(this.selling_price_text_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(724, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 145;
            this.label5.Text = "Selling Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(708, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 147;
            this.label6.Text = "Purchase Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // purchase_price_text
            // 
            this.purchase_price_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_price_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.purchase_price_text.Location = new System.Drawing.Point(829, 262);
            this.purchase_price_text.Multiline = true;
            this.purchase_price_text.Name = "purchase_price_text";
            this.purchase_price_text.ReadOnly = true;
            this.purchase_price_text.Size = new System.Drawing.Size(244, 26);
            this.purchase_price_text.TabIndex = 146;
            this.purchase_price_text.TextChanged += new System.EventHandler(this.purchase_price_text_TextChanged);
            // 
            // stock_in_id
            // 
            this.stock_in_id.AutoSize = true;
            this.stock_in_id.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_in_id.ForeColor = System.Drawing.Color.White;
            this.stock_in_id.Location = new System.Drawing.Point(307, 107);
            this.stock_in_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stock_in_id.Name = "stock_in_id";
            this.stock_in_id.Size = new System.Drawing.Size(41, 44);
            this.stock_in_id.TabIndex = 150;
            this.stock_in_id.Text = "x";
            // 
            // item_id
            // 
            this.item_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_id.Location = new System.Drawing.Point(134, 112);
            this.item_id.Multiline = true;
            this.item_id.Name = "item_id";
            this.item_id.Size = new System.Drawing.Size(35, 26);
            this.item_id.TabIndex = 151;
            this.item_id.Visible = false;
            // 
            // supplier_id
            // 
            this.supplier_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_id.Location = new System.Drawing.Point(175, 112);
            this.supplier_id.Multiline = true;
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.Size = new System.Drawing.Size(37, 26);
            this.supplier_id.TabIndex = 153;
            this.supplier_id.Visible = false;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(970, 539);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(104, 27);
            this.cancel.TabIndex = 155;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // stock_in_button
            // 
            this.stock_in_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.stock_in_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stock_in_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_in_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_in_button.ForeColor = System.Drawing.Color.White;
            this.stock_in_button.Location = new System.Drawing.Point(838, 538);
            this.stock_in_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stock_in_button.Name = "stock_in_button";
            this.stock_in_button.Size = new System.Drawing.Size(121, 27);
            this.stock_in_button.TabIndex = 154;
            this.stock_in_button.Text = "Stock in";
            this.stock_in_button.UseVisualStyleBackColor = false;
            this.stock_in_button.Click += new System.EventHandler(this.stock_in_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 167;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 22);
            this.pictureBox1.TabIndex = 166;
            this.pictureBox1.TabStop = false;
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Tomato;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove_button.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.Location = new System.Drawing.Point(909, 330);
            this.remove_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(80, 27);
            this.remove_button.TabIndex = 168;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1101, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 169;
            this.exit.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(53, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 173;
            this.label8.Text = "Purchase Order List";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(204, 238);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 16);
            this.label9.TabIndex = 283;
            this.label9.Text = "* Select supplier to view items from purchase order";
            // 
            // supplier_text
            // 
            this.supplier_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_text.FormattingEnabled = true;
            this.supplier_text.Location = new System.Drawing.Point(305, 197);
            this.supplier_text.Name = "supplier_text";
            this.supplier_text.Size = new System.Drawing.Size(245, 28);
            this.supplier_text.TabIndex = 287;
            this.supplier_text.SelectedIndexChanged += new System.EventHandler(this.supplier_text_SelectedIndexChanged);
            // 
            // item_inventory
            // 
            this.item_inventory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_inventory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item_inventory.Location = new System.Drawing.Point(254, 262);
            this.item_inventory.Multiline = true;
            this.item_inventory.Name = "item_inventory";
            this.item_inventory.ReadOnly = true;
            this.item_inventory.Size = new System.Drawing.Size(243, 26);
            this.item_inventory.TabIndex = 288;
            // 
            // purch_id
            // 
            this.purch_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purch_id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.purch_id.Location = new System.Drawing.Point(831, 366);
            this.purch_id.Multiline = true;
            this.purch_id.Name = "purch_id";
            this.purch_id.ReadOnly = true;
            this.purch_id.Size = new System.Drawing.Size(243, 26);
            this.purch_id.TabIndex = 289;
            // 
            // Stock_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 592);
            this.Controls.Add(this.supplier_text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.stock_in_button);
            this.Controls.Add(this.stock_in_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.purchase_price_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selling_price_text);
            this.Controls.Add(this.item_view);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stock_in_view);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stock_date);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.item_quantity_text);
            this.Controls.Add(this.item_name_text);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.item_name_label);
            this.Controls.Add(this.supplier_id);
            this.Controls.Add(this.item_id);
            this.Controls.Add(this.item_inventory);
            this.Controls.Add(this.purch_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Stock_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stock_in_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker stock_date;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TextBox item_quantity_text;
        private System.Windows.Forms.TextBox item_name_text;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label item_name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker del_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView stock_in_view;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView item_view;
        private System.Windows.Forms.TextBox selling_price_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox purchase_price_text;
        private System.Windows.Forms.Label stock_in_id;
        private System.Windows.Forms.TextBox item_id;
        private System.Windows.Forms.TextBox supplier_id;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button stock_in_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox supplier_text;
        private System.Windows.Forms.TextBox item_inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn iname;
        private System.Windows.Forms.DataGridViewTextBoxColumn isp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipp;
        private System.Windows.Forms.DataGridViewTextBoxColumn iqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn isupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn isuppid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idel;
        private System.Windows.Forms.DataGridViewTextBoxColumn istock;
        private System.Windows.Forms.DataGridViewTextBoxColumn iid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppid;
        private System.Windows.Forms.TextBox purch_id;
    }
}