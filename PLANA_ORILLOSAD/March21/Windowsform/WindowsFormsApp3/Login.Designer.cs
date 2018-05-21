namespace WindowsFormsApp3
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.login_button = new System.Windows.Forms.Button();
            this.label_pass = new System.Windows.Forms.Label();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.text_user = new System.Windows.Forms.TextBox();
            this.job_order_view = new System.Windows.Forms.DataGridView();
            this.cancel_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventory_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.job_order_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_view)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.SeaGreen;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(584, 300);
            this.login_button.Margin = new System.Windows.Forms.Padding(4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(101, 32);
            this.login_button.TabIndex = 38;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.BackColor = System.Drawing.Color.Transparent;
            this.label_pass.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label_pass.ForeColor = System.Drawing.Color.White;
            this.label_pass.Location = new System.Drawing.Point(489, 248);
            this.label_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(88, 21);
            this.label_pass.TabIndex = 36;
            this.label_pass.Text = "Password";
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password.Location = new System.Drawing.Point(585, 244);
            this.text_password.Margin = new System.Windows.Forms.Padding(4);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(226, 31);
            this.text_password.TabIndex = 35;
            this.text_password.UseSystemPasswordChar = true;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.BackColor = System.Drawing.Color.Transparent;
            this.label_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_user.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(486, 193);
            this.label_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(93, 21);
            this.label_user.TabIndex = 33;
            this.label_user.Text = "Username";
            // 
            // text_user
            // 
            this.text_user.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_user.Location = new System.Drawing.Point(585, 190);
            this.text_user.Margin = new System.Windows.Forms.Padding(4);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(226, 31);
            this.text_user.TabIndex = 32;
            // 
            // job_order_view
            // 
            this.job_order_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.job_order_view.ColumnHeadersHeight = 25;
            this.job_order_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.job_order_view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_order_view.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.job_order_view.Location = new System.Drawing.Point(53, 152);
            this.job_order_view.Name = "job_order_view";
            this.job_order_view.RowHeadersVisible = false;
            this.job_order_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.job_order_view.Size = new System.Drawing.Size(10, 10);
            this.job_order_view.TabIndex = 41;
            this.job_order_view.Visible = false;
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Tomato;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(707, 300);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(105, 32);
            this.cancel_button.TabIndex = 39;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(53, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 188);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // inventory_view
            // 
            this.inventory_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventory_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventory_view.ColumnHeadersHeight = 26;
            this.inventory_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventory_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.inventory_view.Location = new System.Drawing.Point(70, 164);
            this.inventory_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inventory_view.Name = "inventory_view";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventory_view.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inventory_view.RowHeadersVisible = false;
            this.inventory_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.inventory_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventory_view.Size = new System.Drawing.Size(10, 10);
            this.inventory_view.TabIndex = 104;
            // 
            // Login_Form
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(869, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.job_order_view);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.inventory_view);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.job_order_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.DataGridView job_order_view;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView inventory_view;
    }
}

