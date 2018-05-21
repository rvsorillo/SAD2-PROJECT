namespace WindowsFormsApp3
{
    partial class Job_Order_Labor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labor_view = new System.Windows.Forms.DataGridView();
            this.labor_fee_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.views = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.fee_number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.labor_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.views)).BeginInit();
            this.SuspendLayout();
            // 
            // labor_view
            // 
            this.labor_view.AllowUserToAddRows = false;
            this.labor_view.AllowUserToDeleteRows = false;
            this.labor_view.AllowUserToResizeColumns = false;
            this.labor_view.AllowUserToResizeRows = false;
            this.labor_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.labor_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.labor_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labor_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.labor_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.labor_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labor_view.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.labor_view.DefaultCellStyle = dataGridViewCellStyle6;
            this.labor_view.Location = new System.Drawing.Point(42, 175);
            this.labor_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labor_view.MultiSelect = false;
            this.labor_view.Name = "labor_view";
            this.labor_view.RowHeadersVisible = false;
            this.labor_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.labor_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.labor_view.Size = new System.Drawing.Size(445, 215);
            this.labor_view.TabIndex = 137;
            this.labor_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.labor_view_CellContentClick);
            // 
            // labor_fee_button
            // 
            this.labor_fee_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.labor_fee_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labor_fee_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labor_fee_button.ForeColor = System.Drawing.Color.White;
            this.labor_fee_button.Location = new System.Drawing.Point(178, 411);
            this.labor_fee_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labor_fee_button.Name = "labor_fee_button";
            this.labor_fee_button.Size = new System.Drawing.Size(152, 34);
            this.labor_fee_button.TabIndex = 285;
            this.labor_fee_button.Text = "Generate";
            this.labor_fee_button.UseVisualStyleBackColor = false;
            this.labor_fee_button.Click += new System.EventHandler(this.labor_fee_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 44);
            this.label4.TabIndex = 286;
            this.label4.Text = "Set Labor Fees";
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Tomato;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(338, 411);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(148, 34);
            this.cancel_button.TabIndex = 293;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // views
            // 
            this.views.AllowUserToAddRows = false;
            this.views.AllowUserToDeleteRows = false;
            this.views.AllowUserToResizeColumns = false;
            this.views.AllowUserToResizeRows = false;
            this.views.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.views.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.views.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.views.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.views.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.views.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.views.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.views.DefaultCellStyle = dataGridViewCellStyle8;
            this.views.Location = new System.Drawing.Point(277, 182);
            this.views.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.views.MultiSelect = false;
            this.views.Name = "views";
            this.views.RowHeadersVisible = false;
            this.views.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.views.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.views.Size = new System.Drawing.Size(210, 104);
            this.views.TabIndex = 294;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(333, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 33);
            this.button1.TabIndex = 295;
            this.button1.Text = "Set Labor Fee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fee_number
            // 
            this.fee_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fee_number.Location = new System.Drawing.Point(219, 136);
            this.fee_number.Multiline = true;
            this.fee_number.Name = "fee_number";
            this.fee_number.Size = new System.Drawing.Size(107, 33);
            this.fee_number.TabIndex = 296;
            // 
            // Job_Order_Labor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.fee_number);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labor_fee_button);
            this.Controls.Add(this.labor_view);
            this.Controls.Add(this.views);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Job_Order_Labor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job_Order_Labor";
            this.Load += new System.EventHandler(this.Job_Order_Labor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labor_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.views)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView labor_view;
        private System.Windows.Forms.Button labor_fee_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.DataGridView views;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fee_number;
    }
}