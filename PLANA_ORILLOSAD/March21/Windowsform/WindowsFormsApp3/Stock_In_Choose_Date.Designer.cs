﻿namespace WindowsFormsApp3
{
    partial class Stock_In_Choose_Date
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
            this.save_button = new System.Windows.Forms.Button();
            this.to_date = new System.Windows.Forms.Label();
            this.tod = new System.Windows.Forms.DateTimePicker();
            this.from_date = new System.Windows.Forms.Label();
            this.fromd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(386, 97);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 305;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Transparent;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.Location = new System.Drawing.Point(220, 230);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(145, 37);
            this.save_button.TabIndex = 304;
            this.save_button.Text = "Generate Report";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // to_date
            // 
            this.to_date.AutoSize = true;
            this.to_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_date.ForeColor = System.Drawing.Color.White;
            this.to_date.Location = new System.Drawing.Point(120, 191);
            this.to_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.to_date.Name = "to_date";
            this.to_date.Size = new System.Drawing.Size(27, 16);
            this.to_date.TabIndex = 302;
            this.to_date.Text = "To";
            // 
            // tod
            // 
            this.tod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tod.Location = new System.Drawing.Point(163, 185);
            this.tod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tod.Name = "tod";
            this.tod.Size = new System.Drawing.Size(282, 26);
            this.tod.TabIndex = 303;
            // 
            // from_date
            // 
            this.from_date.AutoSize = true;
            this.from_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_date.ForeColor = System.Drawing.Color.White;
            this.from_date.Location = new System.Drawing.Point(108, 156);
            this.from_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.from_date.Name = "from_date";
            this.from_date.Size = new System.Drawing.Size(47, 16);
            this.from_date.TabIndex = 300;
            this.from_date.Text = "From ";
            // 
            // fromd
            // 
            this.fromd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromd.Location = new System.Drawing.Point(163, 153);
            this.fromd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fromd.Name = "fromd";
            this.fromd.Size = new System.Drawing.Size(282, 26);
            this.fromd.TabIndex = 301;
            // 
            // Stock_In_Choose_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(599, 365);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.to_date);
            this.Controls.Add(this.tod);
            this.Controls.Add(this.from_date);
            this.Controls.Add(this.fromd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock_In_Choose_Date";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Stock_In_Choose_Day_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label to_date;
        private System.Windows.Forms.DateTimePicker tod;
        private System.Windows.Forms.Label from_date;
        private System.Windows.Forms.DateTimePicker fromd;
    }
}