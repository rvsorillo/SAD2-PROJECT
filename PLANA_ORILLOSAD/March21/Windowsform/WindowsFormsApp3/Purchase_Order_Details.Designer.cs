namespace WindowsFormsApp3
{
    partial class Purchase_Order_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_Order_Details));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.purch_id = new System.Windows.Forms.Label();
            this.purchase_order_view = new System.Windows.Forms.DataGridView();
            this.total_text = new System.Windows.Forms.TextBox();
            this.total_label = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_order_view)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(887, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 321;
            this.exit.Text = "x";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 320;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 22);
            this.pictureBox1.TabIndex = 319;
            this.pictureBox1.TabStop = false;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(775, 58);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 317;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 44);
            this.label3.TabIndex = 316;
            this.label3.Text = "Purchase Order Details #";
            // 
            // purch_id
            // 
            this.purch_id.AutoSize = true;
            this.purch_id.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purch_id.ForeColor = System.Drawing.Color.White;
            this.purch_id.Location = new System.Drawing.Point(115, 110);
            this.purch_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.purch_id.Name = "purch_id";
            this.purch_id.Size = new System.Drawing.Size(41, 44);
            this.purch_id.TabIndex = 318;
            this.purch_id.Text = "x";
            // 
            // purchase_order_view
            // 
            this.purchase_order_view.AllowUserToAddRows = false;
            this.purchase_order_view.AllowUserToDeleteRows = false;
            this.purchase_order_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchase_order_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.purchase_order_view.ColumnHeadersHeight = 26;
            this.purchase_order_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchase_order_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.purchase_order_view.Location = new System.Drawing.Point(41, 188);
            this.purchase_order_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.purchase_order_view.Name = "purchase_order_view";
            this.purchase_order_view.ReadOnly = true;
            this.purchase_order_view.RowHeadersVisible = false;
            this.purchase_order_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.purchase_order_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchase_order_view.Size = new System.Drawing.Size(833, 281);
            this.purchase_order_view.TabIndex = 322;
            // 
            // total_text
            // 
            this.total_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_text.Location = new System.Drawing.Point(761, 476);
            this.total_text.Multiline = true;
            this.total_text.Name = "total_text";
            this.total_text.Size = new System.Drawing.Size(112, 26);
            this.total_text.TabIndex = 324;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.Color.White;
            this.total_label.Location = new System.Drawing.Point(710, 481);
            this.total_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(44, 16);
            this.total_label.TabIndex = 323;
            this.total_label.Text = "Total";
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.White;
            this.txtid.Location = new System.Drawing.Point(566, 110);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(41, 44);
            this.txtid.TabIndex = 325;
            this.txtid.Text = "x";
            // 
            // Purchase_Order_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.total_text);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.purchase_order_view);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.purch_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase_Order_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase_Order_Details";
            this.Load += new System.EventHandler(this.Purchase_Order_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_order_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label purch_id;
        private System.Windows.Forms.DataGridView purchase_order_view;
        private System.Windows.Forms.TextBox total_text;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label txtid;
    }
}