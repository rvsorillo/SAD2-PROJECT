namespace WindowsFormsApp3
{
    partial class Inventory_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_List));
            this.inventory_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.job_order_control = new System.Windows.Forms.TabControl();
            this.viewalltab = new System.Windows.Forms.TabPage();
            this.consumablestab = new System.Windows.Forms.TabPage();
            this.con_view = new System.Windows.Forms.DataGridView();
            this.partstab = new System.Windows.Forms.TabPage();
            this.par_view = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.job_order_control.SuspendLayout();
            this.viewalltab.SuspendLayout();
            this.consumablestab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.con_view)).BeginInit();
            this.partstab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.par_view)).BeginInit();
            this.SuspendLayout();
            // 
            // inventory_view
            // 
            this.inventory_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventory_view.ColumnHeadersHeight = 26;
            this.inventory_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.inventory_view.Location = new System.Drawing.Point(19, 26);
            this.inventory_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inventory_view.Name = "inventory_view";
            this.inventory_view.RowHeadersVisible = false;
            this.inventory_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.inventory_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventory_view.Size = new System.Drawing.Size(926, 292);
            this.inventory_view.TabIndex = 103;
            this.inventory_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventory_view_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 44);
            this.label1.TabIndex = 101;
            this.label1.Text = "Inventory";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(942, 49);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 121;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 169;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(972, 22);
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // job_order_control
            // 
            this.job_order_control.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.job_order_control.Controls.Add(this.viewalltab);
            this.job_order_control.Controls.Add(this.consumablestab);
            this.job_order_control.Controls.Add(this.partstab);
            this.job_order_control.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_order_control.Location = new System.Drawing.Point(74, 179);
            this.job_order_control.Name = "job_order_control";
            this.job_order_control.Padding = new System.Drawing.Point(127, 8);
            this.job_order_control.SelectedIndex = 0;
            this.job_order_control.Size = new System.Drawing.Size(972, 390);
            this.job_order_control.TabIndex = 170;
            // 
            // viewalltab
            // 
            this.viewalltab.Controls.Add(this.inventory_view);
            this.viewalltab.Location = new System.Drawing.Point(4, 42);
            this.viewalltab.Name = "viewalltab";
            this.viewalltab.Size = new System.Drawing.Size(964, 344);
            this.viewalltab.TabIndex = 0;
            this.viewalltab.Text = "View All";
            this.viewalltab.UseVisualStyleBackColor = true;
            // 
            // consumablestab
            // 
            this.consumablestab.Controls.Add(this.con_view);
            this.consumablestab.Location = new System.Drawing.Point(4, 42);
            this.consumablestab.Name = "consumablestab";
            this.consumablestab.Size = new System.Drawing.Size(964, 344);
            this.consumablestab.TabIndex = 1;
            this.consumablestab.Text = "Consumables";
            this.consumablestab.UseVisualStyleBackColor = true;
            // 
            // con_view
            // 
            this.con_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.con_view.ColumnHeadersHeight = 26;
            this.con_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.con_view.Location = new System.Drawing.Point(19, 26);
            this.con_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.con_view.Name = "con_view";
            this.con_view.RowHeadersVisible = false;
            this.con_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.con_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.con_view.Size = new System.Drawing.Size(926, 292);
            this.con_view.TabIndex = 104;
            // 
            // partstab
            // 
            this.partstab.Controls.Add(this.par_view);
            this.partstab.Location = new System.Drawing.Point(4, 42);
            this.partstab.Name = "partstab";
            this.partstab.Size = new System.Drawing.Size(964, 344);
            this.partstab.TabIndex = 2;
            this.partstab.Text = "Parts";
            this.partstab.UseVisualStyleBackColor = true;
            // 
            // par_view
            // 
            this.par_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.par_view.ColumnHeadersHeight = 26;
            this.par_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.par_view.Location = new System.Drawing.Point(19, 26);
            this.par_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.par_view.Name = "par_view";
            this.par_view.RowHeadersVisible = false;
            this.par_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.par_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.par_view.Size = new System.Drawing.Size(926, 292);
            this.par_view.TabIndex = 104;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1101, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 171;
            this.exit.Text = "x";
            // 
            // Inventory_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 592);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.job_order_control);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLTP AUTO REPAIR SHOP";
            this.Load += new System.EventHandler(this.Inventory_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.job_order_control.ResumeLayout(false);
            this.viewalltab.ResumeLayout(false);
            this.consumablestab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.con_view)).EndInit();
            this.partstab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.par_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView inventory_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl job_order_control;
        private System.Windows.Forms.TabPage viewalltab;
        private System.Windows.Forms.TabPage consumablestab;
        private System.Windows.Forms.TabPage partstab;
        private System.Windows.Forms.DataGridView con_view;
        private System.Windows.Forms.DataGridView par_view;
        private System.Windows.Forms.Label exit;
    }
}