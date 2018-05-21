namespace WindowsFormsApp3
{
    partial class Profile_Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.emp_position_text = new System.Windows.Forms.ComboBox();
            this.emp_position_label = new System.Windows.Forms.Label();
            this.emp_address_text = new System.Windows.Forms.TextBox();
            this.emp_address_label = new System.Windows.Forms.Label();
            this.emp_contact_text = new System.Windows.Forms.TextBox();
            this.emp_contact_label = new System.Windows.Forms.Label();
            this.emp_lastname_text = new System.Windows.Forms.TextBox();
            this.emp_lastname_label = new System.Windows.Forms.Label();
            this.emp_firstname_text = new System.Windows.Forms.TextBox();
            this.emp_firstname_label = new System.Windows.Forms.Label();
            this.employee_label = new System.Windows.Forms.Label();
            this.employee_view = new System.Windows.Forms.DataGridView();
            this.update_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.admin_panel = new System.Windows.Forms.Panel();
            this.task_view = new System.Windows.Forms.DataGridView();
            this.task_label = new System.Windows.Forms.Label();
            this.skills_label = new System.Windows.Forms.Label();
            this.skills_text = new System.Windows.Forms.TextBox();
            this.skills_panel = new System.Windows.Forms.Panel();
            this.positionid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_input = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.view_task_history_button = new System.Windows.Forms.Button();
            this.task_panel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.customer_label = new System.Windows.Forms.Label();
            this.all_tasks = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.status_text = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employee_view)).BeginInit();
            this.admin_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.task_view)).BeginInit();
            this.skills_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.task_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_position_text
            // 
            this.emp_position_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_position_text.FormattingEnabled = true;
            this.emp_position_text.Location = new System.Drawing.Point(852, 344);
            this.emp_position_text.Name = "emp_position_text";
            this.emp_position_text.Size = new System.Drawing.Size(221, 28);
            this.emp_position_text.TabIndex = 108;
            this.emp_position_text.SelectedIndexChanged += new System.EventHandler(this.emp_position_text_SelectedIndexChanged);
            // 
            // emp_position_label
            // 
            this.emp_position_label.AutoSize = true;
            this.emp_position_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_position_label.ForeColor = System.Drawing.Color.White;
            this.emp_position_label.Location = new System.Drawing.Point(774, 351);
            this.emp_position_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emp_position_label.Name = "emp_position_label";
            this.emp_position_label.Size = new System.Drawing.Size(64, 16);
            this.emp_position_label.TabIndex = 106;
            this.emp_position_label.Text = "Position";
            // 
            // emp_address_text
            // 
            this.emp_address_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_address_text.Location = new System.Drawing.Point(852, 312);
            this.emp_address_text.Margin = new System.Windows.Forms.Padding(4);
            this.emp_address_text.Name = "emp_address_text";
            this.emp_address_text.Size = new System.Drawing.Size(221, 26);
            this.emp_address_text.TabIndex = 104;
            // 
            // emp_address_label
            // 
            this.emp_address_label.AutoSize = true;
            this.emp_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_address_label.ForeColor = System.Drawing.Color.White;
            this.emp_address_label.Location = new System.Drawing.Point(771, 319);
            this.emp_address_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emp_address_label.Name = "emp_address_label";
            this.emp_address_label.Size = new System.Drawing.Size(66, 16);
            this.emp_address_label.TabIndex = 103;
            this.emp_address_label.Text = "Address";
            // 
            // emp_contact_text
            // 
            this.emp_contact_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_contact_text.Location = new System.Drawing.Point(852, 250);
            this.emp_contact_text.Margin = new System.Windows.Forms.Padding(4);
            this.emp_contact_text.MaxLength = 11;
            this.emp_contact_text.Name = "emp_contact_text";
            this.emp_contact_text.Size = new System.Drawing.Size(221, 26);
            this.emp_contact_text.TabIndex = 102;
            this.emp_contact_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emp_contact_text_KeyPress);
            // 
            // emp_contact_label
            // 
            this.emp_contact_label.AutoSize = true;
            this.emp_contact_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_contact_label.ForeColor = System.Drawing.Color.White;
            this.emp_contact_label.Location = new System.Drawing.Point(720, 255);
            this.emp_contact_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emp_contact_label.Name = "emp_contact_label";
            this.emp_contact_label.Size = new System.Drawing.Size(118, 16);
            this.emp_contact_label.TabIndex = 101;
            this.emp_contact_label.Text = "Contact Number";
            // 
            // emp_lastname_text
            // 
            this.emp_lastname_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_lastname_text.Location = new System.Drawing.Point(852, 219);
            this.emp_lastname_text.Margin = new System.Windows.Forms.Padding(4);
            this.emp_lastname_text.Name = "emp_lastname_text";
            this.emp_lastname_text.Size = new System.Drawing.Size(221, 26);
            this.emp_lastname_text.TabIndex = 100;
            // 
            // emp_lastname_label
            // 
            this.emp_lastname_label.AutoSize = true;
            this.emp_lastname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_lastname_label.ForeColor = System.Drawing.Color.White;
            this.emp_lastname_label.Location = new System.Drawing.Point(763, 225);
            this.emp_lastname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emp_lastname_label.Name = "emp_lastname_label";
            this.emp_lastname_label.Size = new System.Drawing.Size(75, 16);
            this.emp_lastname_label.TabIndex = 99;
            this.emp_lastname_label.Text = "Lastname";
            // 
            // emp_firstname_text
            // 
            this.emp_firstname_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_firstname_text.Location = new System.Drawing.Point(852, 188);
            this.emp_firstname_text.Margin = new System.Windows.Forms.Padding(4);
            this.emp_firstname_text.Name = "emp_firstname_text";
            this.emp_firstname_text.Size = new System.Drawing.Size(221, 26);
            this.emp_firstname_text.TabIndex = 98;
            // 
            // emp_firstname_label
            // 
            this.emp_firstname_label.AutoSize = true;
            this.emp_firstname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_firstname_label.ForeColor = System.Drawing.Color.White;
            this.emp_firstname_label.Location = new System.Drawing.Point(763, 193);
            this.emp_firstname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emp_firstname_label.Name = "emp_firstname_label";
            this.emp_firstname_label.Size = new System.Drawing.Size(76, 16);
            this.emp_firstname_label.TabIndex = 97;
            this.emp_firstname_label.Text = "Firstname";
            // 
            // employee_label
            // 
            this.employee_label.AutoSize = true;
            this.employee_label.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_label.ForeColor = System.Drawing.Color.White;
            this.employee_label.Location = new System.Drawing.Point(122, 88);
            this.employee_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employee_label.Name = "employee_label";
            this.employee_label.Size = new System.Drawing.Size(200, 44);
            this.employee_label.TabIndex = 93;
            this.employee_label.Text = "Employee";
            // 
            // employee_view
            // 
            this.employee_view.AllowUserToAddRows = false;
            this.employee_view.AllowUserToDeleteRows = false;
            this.employee_view.AllowUserToResizeColumns = false;
            this.employee_view.AllowUserToResizeRows = false;
            this.employee_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employee_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.employee_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employee_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.employee_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_view.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employee_view.DefaultCellStyle = dataGridViewCellStyle10;
            this.employee_view.Location = new System.Drawing.Point(48, 190);
            this.employee_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.employee_view.MultiSelect = false;
            this.employee_view.Name = "employee_view";
            this.employee_view.ReadOnly = true;
            this.employee_view.RowHeadersVisible = false;
            this.employee_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.employee_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employee_view.Size = new System.Drawing.Size(639, 190);
            this.employee_view.TabIndex = 137;
            this.employee_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_view_CellClick);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(865, 527);
            this.update_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(98, 27);
            this.update_button.TabIndex = 141;
            this.update_button.Text = "Update ";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.Tomato;
            this.reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(975, 527);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(104, 27);
            this.reset_button.TabIndex = 140;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.SeaGreen;
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(753, 527);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 27);
            this.add_button.TabIndex = 139;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DimGray;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(980, 48);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 27);
            this.back_button.TabIndex = 142;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 156;
            this.label1.Text = "Password";
            // 
            // password_text
            // 
            this.password_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.Location = new System.Drawing.Point(133, 35);
            this.password_text.Margin = new System.Windows.Forms.Padding(4);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(221, 26);
            this.password_text.TabIndex = 158;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 155;
            this.label2.Text = "Username";
            // 
            // username_text
            // 
            this.username_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_text.Location = new System.Drawing.Point(133, 3);
            this.username_text.Margin = new System.Windows.Forms.Padding(4);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(221, 26);
            this.username_text.TabIndex = 156;
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textid.Location = new System.Drawing.Point(163, 105);
            this.textid.Margin = new System.Windows.Forms.Padding(4);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(32, 26);
            this.textid.TabIndex = 154;
            // 
            // admin_panel
            // 
            this.admin_panel.Controls.Add(this.label2);
            this.admin_panel.Controls.Add(this.username_text);
            this.admin_panel.Controls.Add(this.label1);
            this.admin_panel.Controls.Add(this.password_text);
            this.admin_panel.Location = new System.Drawing.Point(719, 375);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(365, 108);
            this.admin_panel.TabIndex = 107;
            this.admin_panel.Visible = false;
            // 
            // task_view
            // 
            this.task_view.AllowUserToAddRows = false;
            this.task_view.AllowUserToDeleteRows = false;
            this.task_view.AllowUserToResizeColumns = false;
            this.task_view.AllowUserToResizeRows = false;
            this.task_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.task_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.task_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.task_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.task_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.task_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.task_view.DefaultCellStyle = dataGridViewCellStyle12;
            this.task_view.Location = new System.Drawing.Point(48, 424);
            this.task_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.task_view.MultiSelect = false;
            this.task_view.Name = "task_view";
            this.task_view.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.task_view.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.task_view.RowHeadersVisible = false;
            this.task_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.task_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.task_view.Size = new System.Drawing.Size(639, 128);
            this.task_view.TabIndex = 161;
            // 
            // task_label
            // 
            this.task_label.AutoSize = true;
            this.task_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.task_label.ForeColor = System.Drawing.Color.White;
            this.task_label.Location = new System.Drawing.Point(47, 401);
            this.task_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.task_label.Name = "task_label";
            this.task_label.Size = new System.Drawing.Size(104, 16);
            this.task_label.TabIndex = 162;
            this.task_label.Text = "Current Tasks";
            // 
            // skills_label
            // 
            this.skills_label.AutoSize = true;
            this.skills_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skills_label.ForeColor = System.Drawing.Color.White;
            this.skills_label.Location = new System.Drawing.Point(71, 10);
            this.skills_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skills_label.Name = "skills_label";
            this.skills_label.Size = new System.Drawing.Size(46, 16);
            this.skills_label.TabIndex = 163;
            this.skills_label.Text = "Skills";
            // 
            // skills_text
            // 
            this.skills_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skills_text.Location = new System.Drawing.Point(133, 5);
            this.skills_text.Margin = new System.Windows.Forms.Padding(4);
            this.skills_text.Multiline = true;
            this.skills_text.Name = "skills_text";
            this.skills_text.Size = new System.Drawing.Size(221, 105);
            this.skills_text.TabIndex = 164;
            this.skills_text.TextChanged += new System.EventHandler(this.skills_text_TextChanged);
            // 
            // skills_panel
            // 
            this.skills_panel.Controls.Add(this.skills_label);
            this.skills_panel.Controls.Add(this.skills_text);
            this.skills_panel.Location = new System.Drawing.Point(719, 373);
            this.skills_panel.Name = "skills_panel";
            this.skills_panel.Size = new System.Drawing.Size(362, 110);
            this.skills_panel.TabIndex = 159;
            this.skills_panel.Visible = false;
            // 
            // positionid
            // 
            this.positionid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionid.Location = new System.Drawing.Point(234, 105);
            this.positionid.Margin = new System.Windows.Forms.Padding(4);
            this.positionid.Name = "positionid";
            this.positionid.Size = new System.Drawing.Size(36, 26);
            this.positionid.TabIndex = 163;
            this.positionid.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(772, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 167;
            this.label3.Text = "Birthday";
            // 
            // date_input
            // 
            this.date_input.Checked = false;
            this.date_input.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.date_input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_input.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_input.Location = new System.Drawing.Point(852, 281);
            this.date_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date_input.Name = "date_input";
            this.date_input.Size = new System.Drawing.Size(221, 26);
            this.date_input.TabIndex = 166;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.TabIndex = 169;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1025, 15);
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1101, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 170;
            this.exit.Text = "x";
            // 
            // view_task_history_button
            // 
            this.view_task_history_button.BackColor = System.Drawing.Color.Gray;
            this.view_task_history_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_task_history_button.Enabled = false;
            this.view_task_history_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view_task_history_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_task_history_button.ForeColor = System.Drawing.Color.White;
            this.view_task_history_button.Location = new System.Drawing.Point(520, 388);
            this.view_task_history_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.view_task_history_button.Name = "view_task_history_button";
            this.view_task_history_button.Size = new System.Drawing.Size(167, 27);
            this.view_task_history_button.TabIndex = 171;
            this.view_task_history_button.Text = "View Task History";
            this.view_task_history_button.UseVisualStyleBackColor = false;
            this.view_task_history_button.Click += new System.EventHandler(this.view_task_history_button_Click);
            // 
            // task_panel
            // 
            this.task_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.task_panel.Controls.Add(this.pictureBox3);
            this.task_panel.Controls.Add(this.customer_label);
            this.task_panel.Controls.Add(this.all_tasks);
            this.task_panel.Controls.Add(this.button1);
            this.task_panel.Location = new System.Drawing.Point(48, 77);
            this.task_panel.Name = "task_panel";
            this.task_panel.Size = new System.Drawing.Size(639, 484);
            this.task_panel.TabIndex = 172;
            this.task_panel.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(628, 15);
            this.pictureBox3.TabIndex = 173;
            this.pictureBox3.TabStop = false;
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_label.ForeColor = System.Drawing.Color.White;
            this.customer_label.Location = new System.Drawing.Point(13, 24);
            this.customer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(196, 38);
            this.customer_label.TabIndex = 164;
            this.customer_label.Text = "Task History";
            // 
            // all_tasks
            // 
            this.all_tasks.AllowUserToAddRows = false;
            this.all_tasks.AllowUserToDeleteRows = false;
            this.all_tasks.AllowUserToResizeColumns = false;
            this.all_tasks.AllowUserToResizeRows = false;
            this.all_tasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.all_tasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.all_tasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.all_tasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.all_tasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.all_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.all_tasks.DefaultCellStyle = dataGridViewCellStyle15;
            this.all_tasks.Location = new System.Drawing.Point(14, 94);
            this.all_tasks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.all_tasks.MultiSelect = false;
            this.all_tasks.Name = "all_tasks";
            this.all_tasks.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.all_tasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.all_tasks.RowHeadersVisible = false;
            this.all_tasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.all_tasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.all_tasks.Size = new System.Drawing.Size(608, 346);
            this.all_tasks.TabIndex = 162;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(517, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 163;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // status_text
            // 
            this.status_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_text.FormattingEnabled = true;
            this.status_text.Location = new System.Drawing.Point(852, 488);
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(221, 28);
            this.status_text.TabIndex = 177;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(788, 494);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 176;
            this.label4.Text = "Status";
            // 
            // Profile_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 592);
            this.Controls.Add(this.task_panel);
            this.Controls.Add(this.status_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.view_task_history_button);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.employee_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_input);
            this.Controls.Add(this.positionid);
            this.Controls.Add(this.task_label);
            this.Controls.Add(this.task_view);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.employee_view);
            this.Controls.Add(this.emp_position_text);
            this.Controls.Add(this.emp_position_label);
            this.Controls.Add(this.emp_address_text);
            this.Controls.Add(this.emp_address_label);
            this.Controls.Add(this.emp_contact_text);
            this.Controls.Add(this.emp_contact_label);
            this.Controls.Add(this.emp_lastname_text);
            this.Controls.Add(this.emp_lastname_label);
            this.Controls.Add(this.emp_firstname_text);
            this.Controls.Add(this.emp_firstname_label);
            this.Controls.Add(this.skills_panel);
            this.Controls.Add(this.admin_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLTP AUTO REPAIR SHOP";
            this.Load += new System.EventHandler(this.Profile_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_view)).EndInit();
            this.admin_panel.ResumeLayout(false);
            this.admin_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.task_view)).EndInit();
            this.skills_panel.ResumeLayout(false);
            this.skills_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.task_panel.ResumeLayout(false);
            this.task_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_tasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox emp_position_text;
        private System.Windows.Forms.Label emp_position_label;
        private System.Windows.Forms.TextBox emp_address_text;
        private System.Windows.Forms.Label emp_address_label;
        private System.Windows.Forms.TextBox emp_contact_text;
        private System.Windows.Forms.Label emp_contact_label;
        private System.Windows.Forms.TextBox emp_lastname_text;
        private System.Windows.Forms.Label emp_lastname_label;
        private System.Windows.Forms.TextBox emp_firstname_text;
        private System.Windows.Forms.Label emp_firstname_label;
        private System.Windows.Forms.Label employee_label;
        private System.Windows.Forms.DataGridView employee_view;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel admin_panel;
        private System.Windows.Forms.DataGridView task_view;
        private System.Windows.Forms.Label task_label;
        private System.Windows.Forms.Label skills_label;
        private System.Windows.Forms.TextBox skills_text;
        private System.Windows.Forms.Panel skills_panel;
        private System.Windows.Forms.TextBox positionid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_input;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button view_task_history_button;
        private System.Windows.Forms.Panel task_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView all_tasks;
        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox status_text;
        private System.Windows.Forms.Label label4;
    }
}