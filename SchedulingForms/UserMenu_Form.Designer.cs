namespace SchedulingForms
{
    partial class UserMenu_Form
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
            this.userMenu_Label = new System.Windows.Forms.Label();
            this.exitApp_Button = new System.Windows.Forms.Button();
            this.appointments_DataGrid = new System.Windows.Forms.DataGridView();
            this.yourAppoint_Label = new System.Windows.Forms.Label();
            this.customer_DataGrid = new System.Windows.Forms.DataGridView();
            this.yourCust_Label = new System.Windows.Forms.Label();
            this.custAdd_Button = new System.Windows.Forms.Button();
            this.custUpdate_Button = new System.Windows.Forms.Button();
            this.custDelete_Button = new System.Windows.Forms.Button();
            this.apptAdd_Button = new System.Windows.Forms.Button();
            this.apptUpdate_Button = new System.Windows.Forms.Button();
            this.apptDelete_Button = new System.Windows.Forms.Button();
            this.print_Button = new System.Windows.Forms.Button();
            this.report_ComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.week_Radio = new System.Windows.Forms.RadioButton();
            this.month_Radio = new System.Windows.Forms.RadioButton();
            this.all_Radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userMenu_Label
            // 
            this.userMenu_Label.AutoSize = true;
            this.userMenu_Label.Location = new System.Drawing.Point(15, 9);
            this.userMenu_Label.Name = "userMenu_Label";
            this.userMenu_Label.Size = new System.Drawing.Size(86, 19);
            this.userMenu_Label.TabIndex = 0;
            this.userMenu_Label.Text = "User\'s Menu";
            // 
            // exitApp_Button
            // 
            this.exitApp_Button.Location = new System.Drawing.Point(15, 559);
            this.exitApp_Button.Name = "exitApp_Button";
            this.exitApp_Button.Size = new System.Drawing.Size(75, 40);
            this.exitApp_Button.TabIndex = 1;
            this.exitApp_Button.Text = "Exit";
            this.exitApp_Button.UseVisualStyleBackColor = true;
            this.exitApp_Button.Click += new System.EventHandler(this.exitApp_Button_Click);
            // 
            // appointments_DataGrid
            // 
            this.appointments_DataGrid.AllowUserToAddRows = false;
            this.appointments_DataGrid.AllowUserToDeleteRows = false;
            this.appointments_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointments_DataGrid.Location = new System.Drawing.Point(15, 100);
            this.appointments_DataGrid.MultiSelect = false;
            this.appointments_DataGrid.Name = "appointments_DataGrid";
            this.appointments_DataGrid.ReadOnly = true;
            this.appointments_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.appointments_DataGrid.RowHeadersVisible = false;
            this.appointments_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointments_DataGrid.Size = new System.Drawing.Size(893, 150);
            this.appointments_DataGrid.TabIndex = 2;
            this.appointments_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointments_DataGrid_CellClick);
            // 
            // yourAppoint_Label
            // 
            this.yourAppoint_Label.AutoSize = true;
            this.yourAppoint_Label.Location = new System.Drawing.Point(15, 78);
            this.yourAppoint_Label.Name = "yourAppoint_Label";
            this.yourAppoint_Label.Size = new System.Drawing.Size(128, 19);
            this.yourAppoint_Label.TabIndex = 3;
            this.yourAppoint_Label.Text = "Your Appointments";
            // 
            // customer_DataGrid
            // 
            this.customer_DataGrid.AllowUserToAddRows = false;
            this.customer_DataGrid.AllowUserToDeleteRows = false;
            this.customer_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customer_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_DataGrid.Location = new System.Drawing.Point(15, 350);
            this.customer_DataGrid.MultiSelect = false;
            this.customer_DataGrid.Name = "customer_DataGrid";
            this.customer_DataGrid.ReadOnly = true;
            this.customer_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customer_DataGrid.RowHeadersVisible = false;
            this.customer_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customer_DataGrid.Size = new System.Drawing.Size(893, 150);
            this.customer_DataGrid.TabIndex = 4;
            this.customer_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_DataGrid_CellClick);
            // 
            // yourCust_Label
            // 
            this.yourCust_Label.AutoSize = true;
            this.yourCust_Label.Location = new System.Drawing.Point(15, 328);
            this.yourCust_Label.Name = "yourCust_Label";
            this.yourCust_Label.Size = new System.Drawing.Size(107, 19);
            this.yourCust_Label.TabIndex = 5;
            this.yourCust_Label.Text = "Your Customers";
            // 
            // custAdd_Button
            // 
            this.custAdd_Button.Location = new System.Drawing.Point(920, 350);
            this.custAdd_Button.Name = "custAdd_Button";
            this.custAdd_Button.Size = new System.Drawing.Size(75, 40);
            this.custAdd_Button.TabIndex = 6;
            this.custAdd_Button.Text = "Add";
            this.custAdd_Button.UseVisualStyleBackColor = true;
            this.custAdd_Button.Click += new System.EventHandler(this.custAdd_Button_Click);
            // 
            // custUpdate_Button
            // 
            this.custUpdate_Button.Location = new System.Drawing.Point(920, 400);
            this.custUpdate_Button.Name = "custUpdate_Button";
            this.custUpdate_Button.Size = new System.Drawing.Size(75, 40);
            this.custUpdate_Button.TabIndex = 7;
            this.custUpdate_Button.Text = "Update";
            this.custUpdate_Button.UseVisualStyleBackColor = true;
            this.custUpdate_Button.Click += new System.EventHandler(this.custUpdate_Button_Click);
            // 
            // custDelete_Button
            // 
            this.custDelete_Button.Location = new System.Drawing.Point(920, 450);
            this.custDelete_Button.Name = "custDelete_Button";
            this.custDelete_Button.Size = new System.Drawing.Size(75, 40);
            this.custDelete_Button.TabIndex = 8;
            this.custDelete_Button.Text = "Delete";
            this.custDelete_Button.UseVisualStyleBackColor = true;
            this.custDelete_Button.Click += new System.EventHandler(this.custDelete_Button_Click);
            // 
            // apptAdd_Button
            // 
            this.apptAdd_Button.Location = new System.Drawing.Point(920, 100);
            this.apptAdd_Button.Name = "apptAdd_Button";
            this.apptAdd_Button.Size = new System.Drawing.Size(75, 40);
            this.apptAdd_Button.TabIndex = 9;
            this.apptAdd_Button.Text = "Add";
            this.apptAdd_Button.UseVisualStyleBackColor = true;
            this.apptAdd_Button.Click += new System.EventHandler(this.apptAdd_Button_Click);
            // 
            // apptUpdate_Button
            // 
            this.apptUpdate_Button.Location = new System.Drawing.Point(920, 146);
            this.apptUpdate_Button.Name = "apptUpdate_Button";
            this.apptUpdate_Button.Size = new System.Drawing.Size(75, 40);
            this.apptUpdate_Button.TabIndex = 10;
            this.apptUpdate_Button.Text = "Update";
            this.apptUpdate_Button.UseVisualStyleBackColor = true;
            this.apptUpdate_Button.Click += new System.EventHandler(this.apptUpdate_Button_Click);
            // 
            // apptDelete_Button
            // 
            this.apptDelete_Button.Location = new System.Drawing.Point(920, 192);
            this.apptDelete_Button.Name = "apptDelete_Button";
            this.apptDelete_Button.Size = new System.Drawing.Size(75, 40);
            this.apptDelete_Button.TabIndex = 11;
            this.apptDelete_Button.Text = "Delete";
            this.apptDelete_Button.UseVisualStyleBackColor = true;
            this.apptDelete_Button.Click += new System.EventHandler(this.apptDelete_Button_Click);
            // 
            // print_Button
            // 
            this.print_Button.Location = new System.Drawing.Point(795, 559);
            this.print_Button.Name = "print_Button";
            this.print_Button.Size = new System.Drawing.Size(120, 40);
            this.print_Button.TabIndex = 12;
            this.print_Button.Text = "Print Report";
            this.print_Button.UseVisualStyleBackColor = true;
            this.print_Button.Click += new System.EventHandler(this.print_Button_Click);
            // 
            // report_ComboBox
            // 
            this.report_ComboBox.FormattingEnabled = true;
            this.report_ComboBox.Location = new System.Drawing.Point(564, 559);
            this.report_ComboBox.Name = "report_ComboBox";
            this.report_ComboBox.Size = new System.Drawing.Size(225, 25);
            this.report_ComboBox.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.all_Radio);
            this.panel1.Controls.Add(this.month_Radio);
            this.panel1.Controls.Add(this.week_Radio);
            this.panel1.Location = new System.Drawing.Point(435, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 31);
            this.panel1.TabIndex = 14;
            // 
            // week_Radio
            // 
            this.week_Radio.AutoSize = true;
            this.week_Radio.Location = new System.Drawing.Point(90, 3);
            this.week_Radio.Name = "week_Radio";
            this.week_Radio.Size = new System.Drawing.Size(88, 23);
            this.week_Radio.TabIndex = 0;
            this.week_Radio.Text = "This Week";
            this.week_Radio.UseVisualStyleBackColor = true;
            this.week_Radio.CheckedChanged += new System.EventHandler(this.CalendarRadioButtonSelection_Click);
            // 
            // month_Radio
            // 
            this.month_Radio.AutoSize = true;
            this.month_Radio.Location = new System.Drawing.Point(217, 3);
            this.month_Radio.Name = "month_Radio";
            this.month_Radio.Size = new System.Drawing.Size(97, 23);
            this.month_Radio.TabIndex = 1;
            this.month_Radio.Text = "This Month";
            this.month_Radio.UseVisualStyleBackColor = true;
            this.month_Radio.CheckedChanged += new System.EventHandler(this.CalendarRadioButtonSelection_Click);
            // 
            // all_Radio
            // 
            this.all_Radio.AutoSize = true;
            this.all_Radio.Checked = true;
            this.all_Radio.Location = new System.Drawing.Point(3, 3);
            this.all_Radio.Name = "all_Radio";
            this.all_Radio.Size = new System.Drawing.Size(42, 23);
            this.all_Radio.TabIndex = 2;
            this.all_Radio.TabStop = true;
            this.all_Radio.Text = "All";
            this.all_Radio.UseVisualStyleBackColor = true;
            this.all_Radio.CheckedChanged += new System.EventHandler(this.CalendarRadioButtonSelection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Calendar";
            // 
            // UserMenu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.report_ComboBox);
            this.Controls.Add(this.print_Button);
            this.Controls.Add(this.apptDelete_Button);
            this.Controls.Add(this.apptUpdate_Button);
            this.Controls.Add(this.apptAdd_Button);
            this.Controls.Add(this.custDelete_Button);
            this.Controls.Add(this.custUpdate_Button);
            this.Controls.Add(this.custAdd_Button);
            this.Controls.Add(this.yourCust_Label);
            this.Controls.Add(this.customer_DataGrid);
            this.Controls.Add(this.yourAppoint_Label);
            this.Controls.Add(this.appointments_DataGrid);
            this.Controls.Add(this.exitApp_Button);
            this.Controls.Add(this.userMenu_Label);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserMenu_Form";
            this.Text = "User\'s Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMenu_Form_FormClosed);
            this.Load += new System.EventHandler(this.UserMenu_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointments_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userMenu_Label;
        private System.Windows.Forms.Button exitApp_Button;
        private System.Windows.Forms.DataGridView appointments_DataGrid;
        private System.Windows.Forms.Label yourAppoint_Label;
        private System.Windows.Forms.DataGridView customer_DataGrid;
        private System.Windows.Forms.Label yourCust_Label;
        private System.Windows.Forms.Button custAdd_Button;
        private System.Windows.Forms.Button custUpdate_Button;
        private System.Windows.Forms.Button custDelete_Button;
        private System.Windows.Forms.Button apptAdd_Button;
        private System.Windows.Forms.Button apptUpdate_Button;
        private System.Windows.Forms.Button apptDelete_Button;
        private System.Windows.Forms.Button print_Button;
        private System.Windows.Forms.ComboBox report_ComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton all_Radio;
        private System.Windows.Forms.RadioButton month_Radio;
        private System.Windows.Forms.RadioButton week_Radio;
        private System.Windows.Forms.Label label1;
    }
}