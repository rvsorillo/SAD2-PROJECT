namespace WindowsFormsApp3
{
    partial class Job_Order_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job_Order_List));
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.job_order_control = new System.Windows.Forms.TabControl();
            this.view_all_tab = new System.Windows.Forms.TabPage();
            this.job_order_view = new System.Windows.Forms.DataGridView();
            this.past_deadline_tab = new System.Windows.Forms.TabPage();
            this.past_deadline_view = new System.Windows.Forms.DataGridView();
            this.on_progress_tab = new System.Windows.Forms.TabPage();
            this.on_progress_view = new System.Windows.Forms.DataGridView();
            this.finished_tab = new System.Windows.Forms.TabPage();
            this.finished_view = new System.Windows.Forms.DataGridView();
            this.released_tab = new System.Windows.Forms.TabPage();
            this.released_view = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.job_order_control.SuspendLayout();
            this.view_all_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.job_order_view)).BeginInit();
            this.past_deadline_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.past_deadline_view)).BeginInit();
            this.on_progress_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.on_progress_view)).BeginInit();
            this.finished_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finished_view)).BeginInit();
            this.released_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.released_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 44);
            this.label1.TabIndex = 68;
            this.label1.Text = "Job Order Schedules";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(983, 46);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 122;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(871, 46);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(104, 27);
            this.add_button.TabIndex = 124;
            this.add_button.Text = "Create ";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // job_order_control
            // 
            this.job_order_control.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.job_order_control.Controls.Add(this.view_all_tab);
            this.job_order_control.Controls.Add(this.past_deadline_tab);
            this.job_order_control.Controls.Add(this.on_progress_tab);
            this.job_order_control.Controls.Add(this.finished_tab);
            this.job_order_control.Controls.Add(this.released_tab);
            this.job_order_control.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_order_control.Location = new System.Drawing.Point(61, 196);
            this.job_order_control.Name = "job_order_control";
            this.job_order_control.Padding = new System.Drawing.Point(64, 8);
            this.job_order_control.SelectedIndex = 0;
            this.job_order_control.Size = new System.Drawing.Size(1028, 455);
            this.job_order_control.TabIndex = 157;
            // 
            // view_all_tab
            // 
            this.view_all_tab.Controls.Add(this.job_order_view);
            this.view_all_tab.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all_tab.Location = new System.Drawing.Point(4, 42);
            this.view_all_tab.Name = "view_all_tab";
            this.view_all_tab.Padding = new System.Windows.Forms.Padding(3);
            this.view_all_tab.Size = new System.Drawing.Size(1020, 409);
            this.view_all_tab.TabIndex = 0;
            this.view_all_tab.Text = "View All";
            this.view_all_tab.UseVisualStyleBackColor = true;
            // 
            // job_order_view
            // 
            this.job_order_view.AllowUserToAddRows = false;
            this.job_order_view.AllowUserToDeleteRows = false;
            this.job_order_view.AllowUserToResizeColumns = false;
            this.job_order_view.AllowUserToResizeRows = false;
            this.job_order_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.job_order_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.job_order_view.ColumnHeadersHeight = 25;
            this.job_order_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.job_order_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.job_order_view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_order_view.Location = new System.Drawing.Point(23, 21);
            this.job_order_view.Name = "job_order_view";
            this.job_order_view.ReadOnly = true;
            this.job_order_view.RowHeadersVisible = false;
            this.job_order_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.job_order_view.Size = new System.Drawing.Size(976, 367);
            this.job_order_view.TabIndex = 0;
            this.job_order_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.job_order_view_CellDoubleClick);
            // 
            // past_deadline_tab
            // 
            this.past_deadline_tab.Controls.Add(this.past_deadline_view);
            this.past_deadline_tab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.past_deadline_tab.Location = new System.Drawing.Point(4, 42);
            this.past_deadline_tab.Name = "past_deadline_tab";
            this.past_deadline_tab.Size = new System.Drawing.Size(1020, 409);
            this.past_deadline_tab.TabIndex = 1;
            this.past_deadline_tab.Text = "Past Deadline";
            this.past_deadline_tab.UseVisualStyleBackColor = true;
            // 
            // past_deadline_view
            // 
            this.past_deadline_view.AllowUserToAddRows = false;
            this.past_deadline_view.AllowUserToDeleteRows = false;
            this.past_deadline_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.past_deadline_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.past_deadline_view.ColumnHeadersHeight = 25;
            this.past_deadline_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.past_deadline_view.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.past_deadline_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.past_deadline_view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.past_deadline_view.Location = new System.Drawing.Point(23, 21);
            this.past_deadline_view.Name = "past_deadline_view";
            this.past_deadline_view.ReadOnly = true;
            this.past_deadline_view.RowHeadersVisible = false;
            this.past_deadline_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.past_deadline_view.Size = new System.Drawing.Size(976, 367);
            this.past_deadline_view.TabIndex = 1;
            this.past_deadline_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.past_deadline_view_CellDoubleClick);
            // 
            // on_progress_tab
            // 
            this.on_progress_tab.Controls.Add(this.on_progress_view);
            this.on_progress_tab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.on_progress_tab.Location = new System.Drawing.Point(4, 42);
            this.on_progress_tab.Name = "on_progress_tab";
            this.on_progress_tab.Size = new System.Drawing.Size(1020, 409);
            this.on_progress_tab.TabIndex = 2;
            this.on_progress_tab.Text = "On Progress";
            this.on_progress_tab.UseVisualStyleBackColor = true;
            // 
            // on_progress_view
            // 
            this.on_progress_view.AllowUserToAddRows = false;
            this.on_progress_view.AllowUserToDeleteRows = false;
            this.on_progress_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.on_progress_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.on_progress_view.ColumnHeadersHeight = 25;
            this.on_progress_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.on_progress_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.on_progress_view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.on_progress_view.Location = new System.Drawing.Point(23, 21);
            this.on_progress_view.Name = "on_progress_view";
            this.on_progress_view.ReadOnly = true;
            this.on_progress_view.RowHeadersVisible = false;
            this.on_progress_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.on_progress_view.Size = new System.Drawing.Size(976, 367);
            this.on_progress_view.TabIndex = 1;
            this.on_progress_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.on_progress_view_CellDoubleClick);
            // 
            // finished_tab
            // 
            this.finished_tab.Controls.Add(this.finished_view);
            this.finished_tab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finished_tab.Location = new System.Drawing.Point(4, 42);
            this.finished_tab.Name = "finished_tab";
            this.finished_tab.Size = new System.Drawing.Size(1020, 409);
            this.finished_tab.TabIndex = 3;
            this.finished_tab.Text = "Finished";
            this.finished_tab.UseVisualStyleBackColor = true;
            // 
            // finished_view
            // 
            this.finished_view.AllowUserToAddRows = false;
            this.finished_view.AllowUserToDeleteRows = false;
            this.finished_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.finished_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.finished_view.ColumnHeadersHeight = 25;
            this.finished_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.finished_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finished_view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finished_view.Location = new System.Drawing.Point(23, 21);
            this.finished_view.Name = "finished_view";
            this.finished_view.ReadOnly = true;
            this.finished_view.RowHeadersVisible = false;
            this.finished_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.finished_view.Size = new System.Drawing.Size(976, 367);
            this.finished_view.TabIndex = 1;
            this.finished_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.finished_view_CellDoubleClick);
            // 
            // released_tab
            // 
            this.released_tab.Controls.Add(this.released_view);
            this.released_tab.Location = new System.Drawing.Point(4, 42);
            this.released_tab.Name = "released_tab";
            this.released_tab.Size = new System.Drawing.Size(1020, 409);
            this.released_tab.TabIndex = 4;
            this.released_tab.Text = "Released";
            this.released_tab.UseVisualStyleBackColor = true;
            // 
            // released_view
            // 
            this.released_view.AllowUserToAddRows = false;
            this.released_view.AllowUserToDeleteRows = false;
            this.released_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.released_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.released_view.ColumnHeadersHeight = 25;
            this.released_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.released_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.released_view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.released_view.Location = new System.Drawing.Point(23, 21);
            this.released_view.Name = "released_view";
            this.released_view.ReadOnly = true;
            this.released_view.RowHeadersVisible = false;
            this.released_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.released_view.Size = new System.Drawing.Size(976, 367);
            this.released_view.TabIndex = 1;
            this.released_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.released_view_CellDoubleClick);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(360, 115);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.ShortcutsEnabled = false;
            this.txtid.Size = new System.Drawing.Size(44, 24);
            this.txtid.TabIndex = 151;
            this.txtid.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 167;
            this.pictureBox2.TabStop = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1122, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 168;
            this.exit.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(62, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 16);
            this.label5.TabIndex = 282;
            this.label5.Text = "* Double click a row to view Job Order Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 22);
            this.pictureBox1.TabIndex = 166;
            this.pictureBox1.TabStop = false;
            // 
            // Job_Order_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.job_order_control);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Job_Order_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Job_Order_List_Load);
            this.job_order_control.ResumeLayout(false);
            this.view_all_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.job_order_view)).EndInit();
            this.past_deadline_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.past_deadline_view)).EndInit();
            this.on_progress_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.on_progress_view)).EndInit();
            this.finished_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finished_view)).EndInit();
            this.released_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.released_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TabControl job_order_control;
        private System.Windows.Forms.TabPage view_all_tab;
        private System.Windows.Forms.TabPage past_deadline_tab;
        private System.Windows.Forms.TabPage on_progress_tab;
        private System.Windows.Forms.TabPage finished_tab;
        private System.Windows.Forms.DataGridView job_order_view;
        private System.Windows.Forms.DataGridView past_deadline_view;
        private System.Windows.Forms.DataGridView on_progress_view;
        private System.Windows.Forms.DataGridView finished_view;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.TabPage released_tab;
        private System.Windows.Forms.DataGridView released_view;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}