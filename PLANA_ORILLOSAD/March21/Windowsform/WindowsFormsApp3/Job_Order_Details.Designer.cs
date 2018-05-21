namespace WindowsFormsApp3
{
    partial class Job_Order_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job_Order_Details));
            this.update = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.plate_number_label = new System.Windows.Forms.Label();
            this.cust_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.job_order_id = new System.Windows.Forms.Label();
            this.problem_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.diagnosis_input = new System.Windows.Forms.TextBox();
            this.diagnosis_label = new System.Windows.Forms.Label();
            this.check_in_date_label = new System.Windows.Forms.Label();
            this.requested_date_label = new System.Windows.Forms.Label();
            this.job_order_serviceid = new System.Windows.Forms.TextBox();
            this.service_id = new System.Windows.Forms.TextBox();
            this.item_id = new System.Windows.Forms.TextBox();
            this.job_order_idx = new System.Windows.Forms.Label();
            this.plate_input = new System.Windows.Forms.TextBox();
            this.status_text = new System.Windows.Forms.TextBox();
            this.cust_input = new System.Windows.Forms.TextBox();
            this.check_out_label = new System.Windows.Forms.Label();
            this.item_view = new System.Windows.Forms.DataGridView();
            this.total_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.job_order_selected_service_view = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.check_in_date_input = new System.Windows.Forms.DateTimePicker();
            this.requested_date_input = new System.Windows.Forms.DateTimePicker();
            this.check_out_input = new System.Windows.Forms.DateTimePicker();
            this.record_payment_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bill_button = new System.Windows.Forms.Button();
            this.bal_text = new System.Windows.Forms.TextBox();
            this.bal_label = new System.Windows.Forms.Label();
            this.prev_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_order_selected_service_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(949, 185);
            this.update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(168, 34);
            this.update.TabIndex = 211;
            this.update.Text = "Update Details";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.ForeColor = System.Drawing.Color.White;
            this.status_label.Location = new System.Drawing.Point(909, 99);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(51, 16);
            this.status_label.TabIndex = 204;
            this.status_label.Text = "Status";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(1009, 41);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 206;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // plate_number_label
            // 
            this.plate_number_label.AutoSize = true;
            this.plate_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plate_number_label.ForeColor = System.Drawing.Color.White;
            this.plate_number_label.Location = new System.Drawing.Point(659, 98);
            this.plate_number_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plate_number_label.Name = "plate_number_label";
            this.plate_number_label.Size = new System.Drawing.Size(102, 16);
            this.plate_number_label.TabIndex = 201;
            this.plate_number_label.Text = "Plate Number";
            // 
            // cust_label
            // 
            this.cust_label.AutoSize = true;
            this.cust_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_label.ForeColor = System.Drawing.Color.White;
            this.cust_label.Location = new System.Drawing.Point(686, 132);
            this.cust_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_label.Name = "cust_label";
            this.cust_label.Size = new System.Drawing.Size(77, 16);
            this.cust_label.TabIndex = 200;
            this.cust_label.Text = "Customer ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 44);
            this.label1.TabIndex = 203;
            this.label1.Text = "Job Order #";
            // 
            // job_order_id
            // 
            this.job_order_id.AutoSize = true;
            this.job_order_id.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_order_id.ForeColor = System.Drawing.Color.White;
            this.job_order_id.Location = new System.Drawing.Point(623, 239);
            this.job_order_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.job_order_id.Name = "job_order_id";
            this.job_order_id.Size = new System.Drawing.Size(0, 44);
            this.job_order_id.TabIndex = 209;
            // 
            // problem_input
            // 
            this.problem_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problem_input.Location = new System.Drawing.Point(254, 292);
            this.problem_input.Multiline = true;
            this.problem_input.Name = "problem_input";
            this.problem_input.ReadOnly = true;
            this.problem_input.Size = new System.Drawing.Size(281, 78);
            this.problem_input.TabIndex = 237;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 236;
            this.label2.Text = "Problems Reported";
            // 
            // diagnosis_input
            // 
            this.diagnosis_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosis_input.Location = new System.Drawing.Point(253, 377);
            this.diagnosis_input.Multiline = true;
            this.diagnosis_input.Name = "diagnosis_input";
            this.diagnosis_input.ReadOnly = true;
            this.diagnosis_input.Size = new System.Drawing.Size(282, 76);
            this.diagnosis_input.TabIndex = 235;
            // 
            // diagnosis_label
            // 
            this.diagnosis_label.AutoSize = true;
            this.diagnosis_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosis_label.ForeColor = System.Drawing.Color.White;
            this.diagnosis_label.Location = new System.Drawing.Point(126, 379);
            this.diagnosis_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diagnosis_label.Name = "diagnosis_label";
            this.diagnosis_label.Size = new System.Drawing.Size(119, 16);
            this.diagnosis_label.TabIndex = 230;
            this.diagnosis_label.Text = "Initial Diagnosis";
            // 
            // check_in_date_label
            // 
            this.check_in_date_label.AutoSize = true;
            this.check_in_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_in_date_label.ForeColor = System.Drawing.Color.White;
            this.check_in_date_label.Location = new System.Drawing.Point(141, 199);
            this.check_in_date_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.check_in_date_label.Name = "check_in_date_label";
            this.check_in_date_label.Size = new System.Drawing.Size(104, 16);
            this.check_in_date_label.TabIndex = 231;
            this.check_in_date_label.Text = "Check In Date";
            // 
            // requested_date_label
            // 
            this.requested_date_label.AutoSize = true;
            this.requested_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requested_date_label.ForeColor = System.Drawing.Color.White;
            this.requested_date_label.Location = new System.Drawing.Point(63, 232);
            this.requested_date_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requested_date_label.Name = "requested_date_label";
            this.requested_date_label.Size = new System.Drawing.Size(184, 16);
            this.requested_date_label.TabIndex = 232;
            this.requested_date_label.Text = "Requested Release Date";
            // 
            // job_order_serviceid
            // 
            this.job_order_serviceid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_order_serviceid.Location = new System.Drawing.Point(271, 106);
            this.job_order_serviceid.Multiline = true;
            this.job_order_serviceid.Name = "job_order_serviceid";
            this.job_order_serviceid.Size = new System.Drawing.Size(33, 26);
            this.job_order_serviceid.TabIndex = 240;
            this.job_order_serviceid.Visible = false;
            // 
            // service_id
            // 
            this.service_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_id.Location = new System.Drawing.Point(175, 106);
            this.service_id.Multiline = true;
            this.service_id.Name = "service_id";
            this.service_id.Size = new System.Drawing.Size(33, 26);
            this.service_id.TabIndex = 239;
            this.service_id.Visible = false;
            // 
            // item_id
            // 
            this.item_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_id.Location = new System.Drawing.Point(232, 106);
            this.item_id.Multiline = true;
            this.item_id.Name = "item_id";
            this.item_id.Size = new System.Drawing.Size(33, 26);
            this.item_id.TabIndex = 238;
            this.item_id.Visible = false;
            // 
            // job_order_idx
            // 
            this.job_order_idx.AutoSize = true;
            this.job_order_idx.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_order_idx.ForeColor = System.Drawing.Color.White;
            this.job_order_idx.Location = new System.Drawing.Point(343, 94);
            this.job_order_idx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.job_order_idx.Name = "job_order_idx";
            this.job_order_idx.Size = new System.Drawing.Size(41, 44);
            this.job_order_idx.TabIndex = 241;
            this.job_order_idx.Text = "x";
            // 
            // plate_input
            // 
            this.plate_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plate_input.Location = new System.Drawing.Point(768, 93);
            this.plate_input.Multiline = true;
            this.plate_input.Name = "plate_input";
            this.plate_input.ReadOnly = true;
            this.plate_input.Size = new System.Drawing.Size(128, 26);
            this.plate_input.TabIndex = 242;
            // 
            // status_text
            // 
            this.status_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_text.Location = new System.Drawing.Point(965, 93);
            this.status_text.Multiline = true;
            this.status_text.Name = "status_text";
            this.status_text.ReadOnly = true;
            this.status_text.Size = new System.Drawing.Size(148, 26);
            this.status_text.TabIndex = 243;
            // 
            // cust_input
            // 
            this.cust_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_input.Location = new System.Drawing.Point(768, 127);
            this.cust_input.Multiline = true;
            this.cust_input.Name = "cust_input";
            this.cust_input.ReadOnly = true;
            this.cust_input.Size = new System.Drawing.Size(346, 26);
            this.cust_input.TabIndex = 244;
            // 
            // check_out_label
            // 
            this.check_out_label.AutoSize = true;
            this.check_out_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out_label.ForeColor = System.Drawing.Color.White;
            this.check_out_label.Location = new System.Drawing.Point(132, 264);
            this.check_out_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.check_out_label.Name = "check_out_label";
            this.check_out_label.Size = new System.Drawing.Size(115, 16);
            this.check_out_label.TabIndex = 261;
            this.check_out_label.Text = "Check Out Date";
            // 
            // item_view
            // 
            this.item_view.AllowUserToDeleteRows = false;
            this.item_view.AllowUserToResizeColumns = false;
            this.item_view.AllowUserToResizeRows = false;
            this.item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.item_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.item_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.item_view.Location = new System.Drawing.Point(576, 277);
            this.item_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.item_view.MultiSelect = false;
            this.item_view.Name = "item_view";
            this.item_view.ReadOnly = true;
            this.item_view.RowHeadersVisible = false;
            this.item_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_view.Size = new System.Drawing.Size(539, 175);
            this.item_view.TabIndex = 274;
            // 
            // total_text
            // 
            this.total_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_text.Location = new System.Drawing.Point(972, 630);
            this.total_text.Multiline = true;
            this.total_text.Name = "total_text";
            this.total_text.ReadOnly = true;
            this.total_text.Size = new System.Drawing.Size(145, 26);
            this.total_text.TabIndex = 271;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(920, 635);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 270;
            this.label9.Text = "Total";
            // 
            // job_order_selected_service_view
            // 
            this.job_order_selected_service_view.AllowUserToDeleteRows = false;
            this.job_order_selected_service_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.job_order_selected_service_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.job_order_selected_service_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.job_order_selected_service_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.job_order_selected_service_view.DefaultCellStyle = dataGridViewCellStyle4;
            this.job_order_selected_service_view.Location = new System.Drawing.Point(69, 489);
            this.job_order_selected_service_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.job_order_selected_service_view.Name = "job_order_selected_service_view";
            this.job_order_selected_service_view.ReadOnly = true;
            this.job_order_selected_service_view.RowHeadersVisible = false;
            this.job_order_selected_service_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.job_order_selected_service_view.Size = new System.Drawing.Size(1048, 135);
            this.job_order_selected_service_view.TabIndex = 265;
            this.job_order_selected_service_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.job_order_selected_service_view_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 277;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1058, 17);
            this.pictureBox1.TabIndex = 276;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1137, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 278;
            this.exit.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 463);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 279;
            this.label3.Text = "Services";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(573, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 280;
            this.label4.Text = "Items ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(141, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 16);
            this.label5.TabIndex = 281;
            this.label5.Text = "* Select service to view all items used";
            // 
            // check_in_date_input
            // 
            this.check_in_date_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.check_in_date_input.CustomFormat = " MM/dd/yyyy";
            this.check_in_date_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_in_date_input.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.check_in_date_input.Location = new System.Drawing.Point(253, 195);
            this.check_in_date_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.check_in_date_input.Name = "check_in_date_input";
            this.check_in_date_input.Size = new System.Drawing.Size(282, 26);
            this.check_in_date_input.TabIndex = 233;
            this.check_in_date_input.ValueChanged += new System.EventHandler(this.check_in_date_input_ValueChanged);
            // 
            // requested_date_input
            // 
            this.requested_date_input.CustomFormat = " MM/dd/yyyy";
            this.requested_date_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requested_date_input.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.requested_date_input.Location = new System.Drawing.Point(254, 227);
            this.requested_date_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.requested_date_input.Name = "requested_date_input";
            this.requested_date_input.Size = new System.Drawing.Size(281, 26);
            this.requested_date_input.TabIndex = 234;
            // 
            // check_out_input
            // 
            this.check_out_input.CustomFormat = " MM/dd/yyyy";
            this.check_out_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out_input.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.check_out_input.Location = new System.Drawing.Point(254, 260);
            this.check_out_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.check_out_input.Name = "check_out_input";
            this.check_out_input.Size = new System.Drawing.Size(281, 26);
            this.check_out_input.TabIndex = 260;
            // 
            // record_payment_button
            // 
            this.record_payment_button.BackColor = System.Drawing.Color.Tomato;
            this.record_payment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.record_payment_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record_payment_button.ForeColor = System.Drawing.Color.White;
            this.record_payment_button.Location = new System.Drawing.Point(772, 184);
            this.record_payment_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.record_payment_button.Name = "record_payment_button";
            this.record_payment_button.Size = new System.Drawing.Size(168, 34);
            this.record_payment_button.TabIndex = 283;
            this.record_payment_button.Text = "Record Payment";
            this.record_payment_button.UseVisualStyleBackColor = false;
            this.record_payment_button.Click += new System.EventHandler(this.record_payment_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(621, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 16);
            this.label6.TabIndex = 283;
            this.label6.Text = "* Displays all items used per service";
            // 
            // bill_button
            // 
            this.bill_button.BackColor = System.Drawing.Color.SeaGreen;
            this.bill_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bill_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_button.ForeColor = System.Drawing.Color.White;
            this.bill_button.Location = new System.Drawing.Point(595, 184);
            this.bill_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bill_button.Name = "bill_button";
            this.bill_button.Size = new System.Drawing.Size(168, 34);
            this.bill_button.TabIndex = 284;
            this.bill_button.Text = "Generate Bill";
            this.bill_button.UseVisualStyleBackColor = false;
            this.bill_button.Visible = false;
            this.bill_button.Click += new System.EventHandler(this.bill_button_Click);
            // 
            // bal_text
            // 
            this.bal_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bal_text.Location = new System.Drawing.Point(972, 227);
            this.bal_text.Multiline = true;
            this.bal_text.Name = "bal_text";
            this.bal_text.ReadOnly = true;
            this.bal_text.Size = new System.Drawing.Size(144, 26);
            this.bal_text.TabIndex = 286;
            this.bal_text.Visible = false;
            // 
            // bal_label
            // 
            this.bal_label.AutoSize = true;
            this.bal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bal_label.ForeColor = System.Drawing.Color.Red;
            this.bal_label.Location = new System.Drawing.Point(819, 232);
            this.bal_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bal_label.Name = "bal_label";
            this.bal_label.Size = new System.Drawing.Size(143, 16);
            this.bal_label.TabIndex = 285;
            this.bal_label.Text = "Remaining Balance";
            this.bal_label.Visible = false;
            // 
            // prev_button
            // 
            this.prev_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.prev_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_button.ForeColor = System.Drawing.Color.White;
            this.prev_button.Location = new System.Drawing.Point(949, 185);
            this.prev_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prev_button.Name = "prev_button";
            this.prev_button.Size = new System.Drawing.Size(168, 34);
            this.prev_button.TabIndex = 294;
            this.prev_button.Text = "View Past Payments";
            this.prev_button.UseVisualStyleBackColor = false;
            this.prev_button.Click += new System.EventHandler(this.prev_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(392, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 34);
            this.button1.TabIndex = 295;
            this.button1.Text = "Set Labor Fee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Job_Order_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1159, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bal_text);
            this.Controls.Add(this.bal_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.item_view);
            this.Controls.Add(this.total_text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.job_order_selected_service_view);
            this.Controls.Add(this.check_out_label);
            this.Controls.Add(this.check_out_input);
            this.Controls.Add(this.cust_input);
            this.Controls.Add(this.status_text);
            this.Controls.Add(this.plate_input);
            this.Controls.Add(this.job_order_idx);
            this.Controls.Add(this.problem_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diagnosis_input);
            this.Controls.Add(this.diagnosis_label);
            this.Controls.Add(this.check_in_date_label);
            this.Controls.Add(this.requested_date_input);
            this.Controls.Add(this.requested_date_label);
            this.Controls.Add(this.check_in_date_input);
            this.Controls.Add(this.update);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.plate_number_label);
            this.Controls.Add(this.cust_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.job_order_id);
            this.Controls.Add(this.job_order_serviceid);
            this.Controls.Add(this.service_id);
            this.Controls.Add(this.item_id);
            this.Controls.Add(this.bill_button);
            this.Controls.Add(this.record_payment_button);
            this.Controls.Add(this.prev_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Job_Order_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job_Order_Details";
            this.Load += new System.EventHandler(this.Job_Order_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_order_selected_service_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label plate_number_label;
        private System.Windows.Forms.Label cust_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label job_order_id;
        private System.Windows.Forms.TextBox problem_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox diagnosis_input;
        private System.Windows.Forms.Label diagnosis_label;
        private System.Windows.Forms.Label check_in_date_label;
        private System.Windows.Forms.Label requested_date_label;
        private System.Windows.Forms.TextBox job_order_serviceid;
        private System.Windows.Forms.TextBox service_id;
        private System.Windows.Forms.TextBox item_id;
        private System.Windows.Forms.Label job_order_idx;
        private System.Windows.Forms.TextBox plate_input;
        private System.Windows.Forms.TextBox status_text;
        private System.Windows.Forms.TextBox cust_input;
        private System.Windows.Forms.Label check_out_label;
        private System.Windows.Forms.DataGridView item_view;
        private System.Windows.Forms.TextBox total_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView job_order_selected_service_view;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker requested_date_input;
        private System.Windows.Forms.DateTimePicker check_out_input;
        private System.Windows.Forms.DateTimePicker check_in_date_input;
        private System.Windows.Forms.Button record_payment_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bill_button;
        private System.Windows.Forms.TextBox bal_text;
        private System.Windows.Forms.Label bal_label;
        private System.Windows.Forms.Button prev_button;
        private System.Windows.Forms.Button button1;
    }
}