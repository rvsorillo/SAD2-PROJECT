namespace WindowsFormsApp3
{
    partial class Sales_Page
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
            this.back_button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.Create_Link = new System.Windows.Forms.Button();
            this.View_All = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(312, 57);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 149;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(454, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 150;
            this.exit.Text = "x";
            // 
            // Create_Link
            // 
            this.Create_Link.BackColor = System.Drawing.Color.SeaGreen;
            this.Create_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Create_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Create_Link.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Create_Link.ForeColor = System.Drawing.Color.White;
            this.Create_Link.Location = new System.Drawing.Point(102, 165);
            this.Create_Link.Margin = new System.Windows.Forms.Padding(4);
            this.Create_Link.Name = "Create_Link";
            this.Create_Link.Size = new System.Drawing.Size(229, 40);
            this.Create_Link.TabIndex = 152;
            this.Create_Link.Text = "CREATE ";
            this.Create_Link.UseVisualStyleBackColor = false;
            this.Create_Link.Click += new System.EventHandler(this.Create_Link_Click);
            // 
            // View_All
            // 
            this.View_All.BackColor = System.Drawing.Color.Tomato;
            this.View_All.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.View_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.View_All.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.View_All.ForeColor = System.Drawing.Color.White;
            this.View_All.Location = new System.Drawing.Point(102, 217);
            this.View_All.Margin = new System.Windows.Forms.Padding(4);
            this.View_All.Name = "View_All";
            this.View_All.Size = new System.Drawing.Size(229, 40);
            this.View_All.TabIndex = 153;
            this.View_All.Text = "VIEW ALL";
            this.View_All.UseVisualStyleBackColor = false;
            this.View_All.Click += new System.EventHandler(this.View_All_Click);
            // 
            // Sales_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(476, 398);
            this.Controls.Add(this.View_All);
            this.Controls.Add(this.Create_Link);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button Create_Link;
        private System.Windows.Forms.Button View_All;
    }
}