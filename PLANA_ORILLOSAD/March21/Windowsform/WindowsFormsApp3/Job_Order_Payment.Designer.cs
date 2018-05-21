namespace WindowsFormsApp3
{
    partial class Job_Order_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job_Order_Payment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.total_text = new System.Windows.Forms.TextBox();
            this.paid_text = new System.Windows.Forms.TextBox();
            this.cust_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.balance_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.record_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.prev_button = new System.Windows.Forms.Button();
            this.payment_panel = new System.Windows.Forms.Panel();
            this.payment_view = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_pay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.payment_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_view)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 279;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 44);
            this.label1.TabIndex = 278;
            this.label1.Text = "Record Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 22);
            this.pictureBox1.TabIndex = 280;
            this.pictureBox1.TabStop = false;
            // 
            // total_text
            // 
            this.total_text.Enabled = false;
            this.total_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_text.Location = new System.Drawing.Point(283, 190);
            this.total_text.Multiline = true;
            this.total_text.Name = "total_text";
            this.total_text.ReadOnly = true;
            this.total_text.Size = new System.Drawing.Size(214, 30);
            this.total_text.TabIndex = 281;
            this.total_text.TabStop = false;
            // 
            // paid_text
            // 
            this.paid_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_text.Location = new System.Drawing.Point(283, 227);
            this.paid_text.MaxLength = 12;
            this.paid_text.Multiline = true;
            this.paid_text.Name = "paid_text";
            this.paid_text.Size = new System.Drawing.Size(214, 30);
            this.paid_text.TabIndex = 282;
            this.paid_text.TextChanged += new System.EventHandler(this.paid_text_TextChanged);
            this.paid_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paid_text_KeyPress);
            // 
            // cust_label
            // 
            this.cust_label.AutoSize = true;
            this.cust_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_label.ForeColor = System.Drawing.Color.White;
            this.cust_label.Location = new System.Drawing.Point(206, 197);
            this.cust_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_label.Name = "cust_label";
            this.cust_label.Size = new System.Drawing.Size(70, 16);
            this.cust_label.TabIndex = 283;
            this.cust_label.Text = "Total Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 284;
            this.label2.Text = "Amount Paid";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(184, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(313, 13);
            this.pictureBox3.TabIndex = 285;
            this.pictureBox3.TabStop = false;
            // 
            // balance_text
            // 
            this.balance_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_text.Location = new System.Drawing.Point(283, 279);
            this.balance_text.Multiline = true;
            this.balance_text.Name = "balance_text";
            this.balance_text.ReadOnly = true;
            this.balance_text.Size = new System.Drawing.Size(214, 30);
            this.balance_text.TabIndex = 286;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(210, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 287;
            this.label3.Text = "Balance";
            // 
            // record_button
            // 
            this.record_button.BackColor = System.Drawing.Color.SeaGreen;
            this.record_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.record_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record_button.ForeColor = System.Drawing.Color.White;
            this.record_button.Location = new System.Drawing.Point(194, 347);
            this.record_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.record_button.Name = "record_button";
            this.record_button.Size = new System.Drawing.Size(303, 34);
            this.record_button.TabIndex = 291;
            this.record_button.Text = "Record Payment";
            this.record_button.UseVisualStyleBackColor = false;
            this.record_button.Click += new System.EventHandler(this.record_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.DimGray;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(450, 34);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(104, 27);
            this.cancel_button.TabIndex = 292;
            this.cancel_button.Text = "Back";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // prev_button
            // 
            this.prev_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.prev_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_button.ForeColor = System.Drawing.Color.White;
            this.prev_button.Location = new System.Drawing.Point(194, 387);
            this.prev_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prev_button.Name = "prev_button";
            this.prev_button.Size = new System.Drawing.Size(304, 34);
            this.prev_button.TabIndex = 293;
            this.prev_button.Text = "View Past Payments";
            this.prev_button.UseVisualStyleBackColor = false;
            this.prev_button.Click += new System.EventHandler(this.prev_button_Click);
            // 
            // payment_panel
            // 
            this.payment_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payment_panel.Controls.Add(this.payment_view);
            this.payment_panel.Controls.Add(this.exit);
            this.payment_panel.Controls.Add(this.label4);
            this.payment_panel.Location = new System.Drawing.Point(13, 12);
            this.payment_panel.Name = "payment_panel";
            this.payment_panel.Size = new System.Drawing.Size(542, 479);
            this.payment_panel.TabIndex = 294;
            this.payment_panel.Visible = false;
            // 
            // payment_view
            // 
            this.payment_view.AllowUserToAddRows = false;
            this.payment_view.AllowUserToDeleteRows = false;
            this.payment_view.AllowUserToResizeColumns = false;
            this.payment_view.AllowUserToResizeRows = false;
            this.payment_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payment_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.payment_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payment_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.payment_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payment_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.payment_view.Location = new System.Drawing.Point(48, 150);
            this.payment_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.payment_view.MultiSelect = false;
            this.payment_view.Name = "payment_view";
            this.payment_view.ReadOnly = true;
            this.payment_view.RowHeadersVisible = false;
            this.payment_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.payment_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payment_view.Size = new System.Drawing.Size(435, 274);
            this.payment_view.TabIndex = 281;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(509, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 280;
            this.exit.Text = "x";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 44);
            this.label4.TabIndex = 279;
            this.label4.Text = "Payment History";
            // 
            // date_pay
            // 
            this.date_pay.CustomFormat = " yyyy-MM-dd hh:mm:ss";
            this.date_pay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_pay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_pay.Location = new System.Drawing.Point(117, 91);
            this.date_pay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date_pay.Name = "date_pay";
            this.date_pay.Size = new System.Drawing.Size(282, 26);
            this.date_pay.TabIndex = 295;
            this.date_pay.Visible = false;
            // 
            // Job_Order_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(581, 521);
            this.Controls.Add(this.payment_panel);
            this.Controls.Add(this.prev_button);
            this.Controls.Add(this.record_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balance_text);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cust_label);
            this.Controls.Add(this.paid_text);
            this.Controls.Add(this.total_text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_pay);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Job_Order_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.payment_panel.ResumeLayout(false);
            this.payment_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox paid_text;
        private System.Windows.Forms.Label cust_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox balance_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button record_button;
        private System.Windows.Forms.TextBox total_text;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button prev_button;
        private System.Windows.Forms.Panel payment_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.DateTimePicker date_pay;
        private System.Windows.Forms.DataGridView payment_view;
    }
}