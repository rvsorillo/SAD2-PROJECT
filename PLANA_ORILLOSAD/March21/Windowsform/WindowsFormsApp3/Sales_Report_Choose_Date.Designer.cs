namespace WindowsFormsApp3
{
    partial class Sales_Report_Choose_Date
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
            this.generate = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.to_date = new System.Windows.Forms.Label();
            this.tod = new System.Windows.Forms.DateTimePicker();
            this.from_date = new System.Windows.Forms.Label();
            this.fromd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.Transparent;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.Color.White;
            this.generate.Location = new System.Drawing.Point(142, 238);
            this.generate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(185, 34);
            this.generate.TabIndex = 295;
            this.generate.Text = "Generate Report";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(343, 32);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 297;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // to_date
            // 
            this.to_date.AutoSize = true;
            this.to_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_date.ForeColor = System.Drawing.Color.White;
            this.to_date.Location = new System.Drawing.Point(77, 174);
            this.to_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.to_date.Name = "to_date";
            this.to_date.Size = new System.Drawing.Size(27, 16);
            this.to_date.TabIndex = 306;
            this.to_date.Text = "To";
            // 
            // tod
            // 
            this.tod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tod.Location = new System.Drawing.Point(120, 168);
            this.tod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tod.Name = "tod";
            this.tod.Size = new System.Drawing.Size(282, 26);
            this.tod.TabIndex = 307;
            // 
            // from_date
            // 
            this.from_date.AutoSize = true;
            this.from_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_date.ForeColor = System.Drawing.Color.White;
            this.from_date.Location = new System.Drawing.Point(65, 139);
            this.from_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.from_date.Name = "from_date";
            this.from_date.Size = new System.Drawing.Size(47, 16);
            this.from_date.TabIndex = 304;
            this.from_date.Text = "From ";
            // 
            // fromd
            // 
            this.fromd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromd.Location = new System.Drawing.Point(120, 136);
            this.fromd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fromd.Name = "fromd";
            this.fromd.Size = new System.Drawing.Size(282, 26);
            this.fromd.TabIndex = 305;
            // 
            // Sales_Report_Choose_Month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(491, 369);
            this.Controls.Add(this.to_date);
            this.Controls.Add(this.tod);
            this.Controls.Add(this.from_date);
            this.Controls.Add(this.fromd);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.generate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Report_Choose_Month";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Report_Choose_Monthcs";
            this.Load += new System.EventHandler(this.Sales_Report_Choose_Month_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label to_date;
        private System.Windows.Forms.DateTimePicker tod;
        private System.Windows.Forms.Label from_date;
        private System.Windows.Forms.DateTimePicker fromd;
    }
}