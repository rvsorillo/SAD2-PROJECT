namespace WindowsFormsApp3
{
    partial class Reports_Page
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
            this.exit = new System.Windows.Forms.Label();
            this.Sales_Report = new System.Windows.Forms.Button();
            this.StockInReport = new System.Windows.Forms.Button();
            this.JobOrderReport = new System.Windows.Forms.Button();
            this.StockOutReport = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(702, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 155;
            this.exit.Text = "x";
            // 
            // Sales_Report
            // 
            this.Sales_Report.BackColor = System.Drawing.Color.Tomato;
            this.Sales_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sales_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sales_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sales_Report.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Sales_Report.ForeColor = System.Drawing.Color.White;
            this.Sales_Report.Location = new System.Drawing.Point(178, 255);
            this.Sales_Report.Margin = new System.Windows.Forms.Padding(4);
            this.Sales_Report.Name = "Sales_Report";
            this.Sales_Report.Size = new System.Drawing.Size(344, 40);
            this.Sales_Report.TabIndex = 137;
            this.Sales_Report.Text = "SALES REPORT";
            this.Sales_Report.UseVisualStyleBackColor = false;
            this.Sales_Report.Click += new System.EventHandler(this.Sales_Report_Click);
            // 
            // StockInReport
            // 
            this.StockInReport.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.StockInReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StockInReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockInReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockInReport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.StockInReport.ForeColor = System.Drawing.Color.White;
            this.StockInReport.Location = new System.Drawing.Point(178, 316);
            this.StockInReport.Margin = new System.Windows.Forms.Padding(4);
            this.StockInReport.Name = "StockInReport";
            this.StockInReport.Size = new System.Drawing.Size(344, 40);
            this.StockInReport.TabIndex = 157;
            this.StockInReport.Text = "STOCK IN REPORT";
            this.StockInReport.UseVisualStyleBackColor = false;
            this.StockInReport.Click += new System.EventHandler(this.StockInReport_Click);
            // 
            // JobOrderReport
            // 
            this.JobOrderReport.BackColor = System.Drawing.Color.SeaGreen;
            this.JobOrderReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.JobOrderReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JobOrderReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JobOrderReport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.JobOrderReport.ForeColor = System.Drawing.Color.White;
            this.JobOrderReport.Location = new System.Drawing.Point(178, 195);
            this.JobOrderReport.Margin = new System.Windows.Forms.Padding(4);
            this.JobOrderReport.Name = "JobOrderReport";
            this.JobOrderReport.Size = new System.Drawing.Size(344, 40);
            this.JobOrderReport.TabIndex = 158;
            this.JobOrderReport.Text = "JOB ORDER REPORT";
            this.JobOrderReport.UseVisualStyleBackColor = false;
            this.JobOrderReport.Click += new System.EventHandler(this.JobOrderReport_Click);
            // 
            // StockOutReport
            // 
            this.StockOutReport.BackColor = System.Drawing.Color.Sienna;
            this.StockOutReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StockOutReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockOutReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockOutReport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.StockOutReport.ForeColor = System.Drawing.Color.White;
            this.StockOutReport.Location = new System.Drawing.Point(178, 377);
            this.StockOutReport.Margin = new System.Windows.Forms.Padding(4);
            this.StockOutReport.Name = "StockOutReport";
            this.StockOutReport.Size = new System.Drawing.Size(344, 40);
            this.StockOutReport.TabIndex = 159;
            this.StockOutReport.Text = "STOCK OUT REPORT";
            this.StockOutReport.UseVisualStyleBackColor = false;
            this.StockOutReport.Click += new System.EventHandler(this.StockOutReport_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(580, 54);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 160;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Reports_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(738, 592);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.StockOutReport);
            this.Controls.Add(this.JobOrderReport);
            this.Controls.Add(this.StockInReport);
            this.Controls.Add(this.Sales_Report);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports_Page";
            this.Load += new System.EventHandler(this.Reports_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button Sales_Report;
        private System.Windows.Forms.Button StockInReport;
        private System.Windows.Forms.Button JobOrderReport;
        private System.Windows.Forms.Button StockOutReport;
        private System.Windows.Forms.Button back_button;
    }
}