namespace WindowsFormsApp3
{
    partial class Job_Order_ChooseDate
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
            this.from_date = new System.Windows.Forms.Label();
            this.fromd = new System.Windows.Forms.DateTimePicker();
            this.to_date = new System.Windows.Forms.Label();
            this.tod = new System.Windows.Forms.DateTimePicker();
            this.save_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // from_date
            // 
            this.from_date.AutoSize = true;
            this.from_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_date.ForeColor = System.Drawing.Color.White;
            this.from_date.Location = new System.Drawing.Point(66, 94);
            this.from_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.from_date.Name = "from_date";
            this.from_date.Size = new System.Drawing.Size(47, 16);
            this.from_date.TabIndex = 13;
            this.from_date.Text = "From ";
            // 
            // fromd
            // 
            this.fromd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromd.Location = new System.Drawing.Point(121, 91);
            this.fromd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fromd.Name = "fromd";
            this.fromd.Size = new System.Drawing.Size(282, 26);
            this.fromd.TabIndex = 14;
            // 
            // to_date
            // 
            this.to_date.AutoSize = true;
            this.to_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_date.ForeColor = System.Drawing.Color.White;
            this.to_date.Location = new System.Drawing.Point(78, 129);
            this.to_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.to_date.Name = "to_date";
            this.to_date.Size = new System.Drawing.Size(27, 16);
            this.to_date.TabIndex = 15;
            this.to_date.Text = "To";
            // 
            // tod
            // 
            this.tod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tod.Location = new System.Drawing.Point(121, 123);
            this.tod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tod.Name = "tod";
            this.tod.Size = new System.Drawing.Size(282, 26);
            this.tod.TabIndex = 16;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Transparent;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.Location = new System.Drawing.Point(178, 168);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(145, 37);
            this.save_button.TabIndex = 147;
            this.save_button.Text = "Generate Report";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(344, 35);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 299;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Job_Order_ChooseDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(497, 261);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.to_date);
            this.Controls.Add(this.tod);
            this.Controls.Add(this.from_date);
            this.Controls.Add(this.fromd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Job_Order_ChooseDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Job_Order_ChooseDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label from_date;
        private System.Windows.Forms.DateTimePicker fromd;
        private System.Windows.Forms.Label to_date;
        private System.Windows.Forms.DateTimePicker tod;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button back_button;
    }
}