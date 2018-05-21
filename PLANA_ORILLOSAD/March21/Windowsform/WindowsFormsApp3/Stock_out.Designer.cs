namespace WindowsFormsApp3
{
    partial class Stock_out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_out));
            this.supplier_id_1 = new System.Windows.Forms.TextBox();
            this.item_id_1 = new System.Windows.Forms.TextBox();
            this.item_view_1 = new System.Windows.Forms.DataGridView();
            this.cancel = new System.Windows.Forms.Button();
            this.stock_out_button = new System.Windows.Forms.Button();
            this.stock_out_view = new System.Windows.Forms.DataGridView();
            this.iname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isupp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isuppid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.purchase_price_text_1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selling_price_text_1 = new System.Windows.Forms.TextBox();
            this.supplier_text_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.item_quantity_text_1 = new System.Windows.Forms.TextBox();
            this.item_name_text_1 = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.item_name_label = new System.Windows.Forms.Label();
            this.stock_out_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stock_out_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.item_inventory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.item_view_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_out_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // supplier_id_1
            // 
            this.supplier_id_1.Location = new System.Drawing.Point(242, 117);
            this.supplier_id_1.Name = "supplier_id_1";
            this.supplier_id_1.Size = new System.Drawing.Size(94, 20);
            this.supplier_id_1.TabIndex = 241;
            // 
            // item_id_1
            // 
            this.item_id_1.Location = new System.Drawing.Point(133, 117);
            this.item_id_1.Name = "item_id_1";
            this.item_id_1.Size = new System.Drawing.Size(94, 20);
            this.item_id_1.TabIndex = 240;
            // 
            // item_view_1
            // 
            this.item_view_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.item_view_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.item_view_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_view_1.DefaultCellStyle = dataGridViewCellStyle2;
            this.item_view_1.Location = new System.Drawing.Point(40, 186);
            this.item_view_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.item_view_1.Name = "item_view_1";
            this.item_view_1.RowHeadersVisible = false;
            this.item_view_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_view_1.Size = new System.Drawing.Size(515, 143);
            this.item_view_1.TabIndex = 239;
            this.item_view_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_view_1_CellClick);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(981, 527);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(104, 27);
            this.cancel.TabIndex = 238;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // stock_out_button
            // 
            this.stock_out_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.stock_out_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stock_out_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_out_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_out_button.ForeColor = System.Drawing.Color.White;
            this.stock_out_button.Location = new System.Drawing.Point(840, 527);
            this.stock_out_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stock_out_button.Name = "stock_out_button";
            this.stock_out_button.Size = new System.Drawing.Size(121, 27);
            this.stock_out_button.TabIndex = 237;
            this.stock_out_button.Text = "Stock out";
            this.stock_out_button.UseVisualStyleBackColor = false;
            this.stock_out_button.Click += new System.EventHandler(this.stock_out_button_Click);
            // 
            // stock_out_view
            // 
            this.stock_out_view.AllowUserToAddRows = false;
            this.stock_out_view.AllowUserToDeleteRows = false;
            this.stock_out_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stock_out_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.stock_out_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iname,
            this.isp,
            this.ipp,
            this.iqty,
            this.isupp,
            this.isuppid,
            this.idel,
            this.istock,
            this.iid});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stock_out_view.DefaultCellStyle = dataGridViewCellStyle4;
            this.stock_out_view.Location = new System.Drawing.Point(563, 187);
            this.stock_out_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stock_out_view.Name = "stock_out_view";
            this.stock_out_view.RowHeadersVisible = false;
            this.stock_out_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stock_out_view.Size = new System.Drawing.Size(520, 316);
            this.stock_out_view.TabIndex = 236;
            // 
            // iname
            // 
            this.iname.HeaderText = "Item Name";
            this.iname.Name = "iname";
            // 
            // isp
            // 
            this.isp.HeaderText = "Selling Price";
            this.isp.Name = "isp";
            // 
            // ipp
            // 
            this.ipp.HeaderText = "Purchase Price";
            this.ipp.Name = "ipp";
            // 
            // iqty
            // 
            this.iqty.HeaderText = "Quantity";
            this.iqty.Name = "iqty";
            // 
            // isupp
            // 
            this.isupp.HeaderText = "Supplier";
            this.isupp.Name = "isupp";
            // 
            // isuppid
            // 
            this.isuppid.HeaderText = "Supplier ID";
            this.isuppid.Name = "isuppid";
            this.isuppid.Visible = false;
            // 
            // idel
            // 
            this.idel.HeaderText = "Delivery Date";
            this.idel.Name = "idel";
            this.idel.Visible = false;
            // 
            // istock
            // 
            this.istock.HeaderText = "Stock in Date";
            this.istock.Name = "istock";
            this.istock.Visible = false;
            // 
            // iid
            // 
            this.iid.HeaderText = "Item ID";
            this.iid.Name = "iid";
            this.iid.Visible = false;
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Tomato;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove_button.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.Location = new System.Drawing.Point(385, 527);
            this.remove_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(80, 27);
            this.remove_button.TabIndex = 235;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click_1);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_button.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(473, 527);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(80, 27);
            this.reset_button.TabIndex = 234;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(300, 527);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(77, 27);
            this.add_button.TabIndex = 233;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(178, 415);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 232;
            this.label6.Text = "Purchase Price";
            // 
            // purchase_price_text_1
            // 
            this.purchase_price_text_1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_price_text_1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.purchase_price_text_1.Location = new System.Drawing.Point(300, 408);
            this.purchase_price_text_1.Multiline = true;
            this.purchase_price_text_1.Name = "purchase_price_text_1";
            this.purchase_price_text_1.ReadOnly = true;
            this.purchase_price_text_1.Size = new System.Drawing.Size(253, 26);
            this.purchase_price_text_1.TabIndex = 231;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 230;
            this.label5.Text = "Selling Price";
            // 
            // selling_price_text_1
            // 
            this.selling_price_text_1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selling_price_text_1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.selling_price_text_1.Location = new System.Drawing.Point(301, 442);
            this.selling_price_text_1.Multiline = true;
            this.selling_price_text_1.Name = "selling_price_text_1";
            this.selling_price_text_1.ReadOnly = true;
            this.selling_price_text_1.Size = new System.Drawing.Size(253, 26);
            this.selling_price_text_1.TabIndex = 229;
            // 
            // supplier_text_1
            // 
            this.supplier_text_1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_text_1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.supplier_text_1.Location = new System.Drawing.Point(301, 475);
            this.supplier_text_1.Multiline = true;
            this.supplier_text_1.Name = "supplier_text_1";
            this.supplier_text_1.ReadOnly = true;
            this.supplier_text_1.Size = new System.Drawing.Size(253, 26);
            this.supplier_text_1.TabIndex = 228;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(225, 483);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 227;
            this.label4.Text = "Supplier";
            // 
            // item_quantity_text_1
            // 
            this.item_quantity_text_1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity_text_1.Location = new System.Drawing.Point(300, 374);
            this.item_quantity_text_1.Multiline = true;
            this.item_quantity_text_1.Name = "item_quantity_text_1";
            this.item_quantity_text_1.Size = new System.Drawing.Size(253, 26);
            this.item_quantity_text_1.TabIndex = 226;
            this.item_quantity_text_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item_quantity_text_1_KeyPress);
            // 
            // item_name_text_1
            // 
            this.item_name_text_1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_text_1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item_name_text_1.Location = new System.Drawing.Point(300, 340);
            this.item_name_text_1.Multiline = true;
            this.item_name_text_1.Name = "item_name_text_1";
            this.item_name_text_1.ReadOnly = true;
            this.item_name_text_1.Size = new System.Drawing.Size(252, 26);
            this.item_name_text_1.TabIndex = 225;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.ForeColor = System.Drawing.Color.White;
            this.quantity_label.Location = new System.Drawing.Point(226, 382);
            this.quantity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(64, 16);
            this.quantity_label.TabIndex = 224;
            this.quantity_label.Text = "Quantity";
            // 
            // item_name_label
            // 
            this.item_name_label.AutoSize = true;
            this.item_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_label.ForeColor = System.Drawing.Color.White;
            this.item_name_label.Location = new System.Drawing.Point(211, 346);
            this.item_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item_name_label.Name = "item_name_label";
            this.item_name_label.Size = new System.Drawing.Size(82, 16);
            this.item_name_label.TabIndex = 223;
            this.item_name_label.Text = "Item Name";
            // 
            // stock_out_id
            // 
            this.stock_out_id.AutoSize = true;
            this.stock_out_id.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_out_id.ForeColor = System.Drawing.Color.White;
            this.stock_out_id.Location = new System.Drawing.Point(323, 106);
            this.stock_out_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stock_out_id.Name = "stock_out_id";
            this.stock_out_id.Size = new System.Drawing.Size(41, 44);
            this.stock_out_id.TabIndex = 222;
            this.stock_out_id.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(697, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 221;
            this.label2.Text = "Stock out Date";
            // 
            // stock_out_date
            // 
            this.stock_out_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_out_date.Location = new System.Drawing.Point(814, 121);
            this.stock_out_date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stock_out_date.Name = "stock_out_date";
            this.stock_out_date.Size = new System.Drawing.Size(270, 26);
            this.stock_out_date.TabIndex = 219;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 44);
            this.label3.TabIndex = 218;
            this.label3.Text = "Stock out #";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 217;
            this.pictureBox2.TabStop = false;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(981, 21);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 220;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1043, 22);
            this.pictureBox1.TabIndex = 242;
            this.pictureBox1.TabStop = false;
            // 
            // item_inventory
            // 
            this.item_inventory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_inventory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item_inventory.Location = new System.Drawing.Point(831, 187);
            this.item_inventory.Multiline = true;
            this.item_inventory.Name = "item_inventory";
            this.item_inventory.ReadOnly = true;
            this.item_inventory.Size = new System.Drawing.Size(252, 26);
            this.item_inventory.TabIndex = 243;
            // 
            // Stock_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 592);
            this.Controls.Add(this.item_view_1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.stock_out_button);
            this.Controls.Add(this.stock_out_view);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.purchase_price_text_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selling_price_text_1);
            this.Controls.Add(this.supplier_text_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.item_quantity_text_1);
            this.Controls.Add(this.item_name_text_1);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.item_name_label);
            this.Controls.Add(this.stock_out_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stock_out_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.supplier_id_1);
            this.Controls.Add(this.item_id_1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.item_inventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock_out";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stockout";
            this.Load += new System.EventHandler(this.Stockout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.item_view_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_out_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox supplier_id_1;
        private System.Windows.Forms.TextBox item_id_1;
        private System.Windows.Forms.DataGridView item_view_1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button stock_out_button;
        private System.Windows.Forms.DataGridView stock_out_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn iname;
        private System.Windows.Forms.DataGridViewTextBoxColumn isp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipp;
        private System.Windows.Forms.DataGridViewTextBoxColumn iqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn isupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn isuppid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idel;
        private System.Windows.Forms.DataGridViewTextBoxColumn istock;
        private System.Windows.Forms.DataGridViewTextBoxColumn iid;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox purchase_price_text_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox selling_price_text_1;
        private System.Windows.Forms.TextBox supplier_text_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox item_quantity_text_1;
        private System.Windows.Forms.TextBox item_name_text_1;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label item_name_label;
        private System.Windows.Forms.Label stock_out_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker stock_out_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox item_inventory;
        private System.Windows.Forms.Button remove_button;
    }
}