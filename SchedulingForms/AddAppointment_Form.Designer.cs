namespace SchedulingForms
{
    partial class AddAppointment_Form
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
            this.cancel_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerID_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.title_TextBox = new System.Windows.Forms.TextBox();
            this.description_TextBox = new System.Windows.Forms.TextBox();
            this.location_TextBox = new System.Windows.Forms.TextBox();
            this.contact_TextBox = new System.Windows.Forms.TextBox();
            this.type_TextBox = new System.Windows.Forms.TextBox();
            this.url_TextBox = new System.Windows.Forms.TextBox();
            this.date_MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.startTime_TextBox = new System.Windows.Forms.TextBox();
            this.endTime_TextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(15, 375);
            this.cancel_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(75, 40);
            this.cancel_Button.TabIndex = 0;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(175, 375);
            this.save_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(75, 40);
            this.save_Button.TabIndex = 1;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // customerID_ComboBox
            // 
            this.customerID_ComboBox.FormattingEnabled = true;
            this.customerID_ComboBox.Location = new System.Drawing.Point(15, 67);
            this.customerID_ComboBox.Name = "customerID_ComboBox";
            this.customerID_ComboBox.Size = new System.Drawing.Size(150, 25);
            this.customerID_ComboBox.TabIndex = 3;
            this.customerID_ComboBox.SelectedIndexChanged += new System.EventHandler(this.customerID_ComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Url";
            // 
            // title_TextBox
            // 
            this.title_TextBox.Location = new System.Drawing.Point(214, 67);
            this.title_TextBox.Name = "title_TextBox";
            this.title_TextBox.Size = new System.Drawing.Size(150, 25);
            this.title_TextBox.TabIndex = 12;
            // 
            // description_TextBox
            // 
            this.description_TextBox.Location = new System.Drawing.Point(414, 152);
            this.description_TextBox.Multiline = true;
            this.description_TextBox.Name = "description_TextBox";
            this.description_TextBox.Size = new System.Drawing.Size(175, 100);
            this.description_TextBox.TabIndex = 13;
            // 
            // location_TextBox
            // 
            this.location_TextBox.Location = new System.Drawing.Point(414, 67);
            this.location_TextBox.Name = "location_TextBox";
            this.location_TextBox.Size = new System.Drawing.Size(150, 25);
            this.location_TextBox.TabIndex = 14;
            // 
            // contact_TextBox
            // 
            this.contact_TextBox.Location = new System.Drawing.Point(614, 67);
            this.contact_TextBox.Name = "contact_TextBox";
            this.contact_TextBox.Size = new System.Drawing.Size(150, 25);
            this.contact_TextBox.TabIndex = 15;
            // 
            // type_TextBox
            // 
            this.type_TextBox.Location = new System.Drawing.Point(15, 152);
            this.type_TextBox.Name = "type_TextBox";
            this.type_TextBox.Size = new System.Drawing.Size(150, 25);
            this.type_TextBox.TabIndex = 16;
            // 
            // url_TextBox
            // 
            this.url_TextBox.Location = new System.Drawing.Point(214, 152);
            this.url_TextBox.Name = "url_TextBox";
            this.url_TextBox.Size = new System.Drawing.Size(150, 25);
            this.url_TextBox.TabIndex = 17;
            // 
            // date_MonthCalendar
            // 
            this.date_MonthCalendar.Location = new System.Drawing.Point(614, 152);
            this.date_MonthCalendar.MaxSelectionCount = 1;
            this.date_MonthCalendar.Name = "date_MonthCalendar";
            this.date_MonthCalendar.ShowTodayCircle = false;
            this.date_MonthCalendar.TabIndex = 26;
            this.date_MonthCalendar.TrailingForeColor = System.Drawing.Color.Silver;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(610, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Appointment Time";
            // 
            // startTime_TextBox
            // 
            this.startTime_TextBox.Location = new System.Drawing.Point(614, 375);
            this.startTime_TextBox.Name = "startTime_TextBox";
            this.startTime_TextBox.Size = new System.Drawing.Size(67, 25);
            this.startTime_TextBox.TabIndex = 35;
            this.startTime_TextBox.Text = "08:00";
            this.startTime_TextBox.Enter += new System.EventHandler(this.startTime_TextBox_Enter);
            // 
            // endTime_TextBox
            // 
            this.endTime_TextBox.Location = new System.Drawing.Point(780, 375);
            this.endTime_TextBox.Name = "endTime_TextBox";
            this.endTime_TextBox.Size = new System.Drawing.Size(61, 25);
            this.endTime_TextBox.TabIndex = 36;
            this.endTime_TextBox.Text = "17:00";
            this.endTime_TextBox.Enter += new System.EventHandler(this.endTime_TextBox_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(610, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "Start Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(776, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 38;
            this.label13.Text = "End Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(660, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Time is in 24-hour format";
            // 
            // AddAppointment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 431);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.endTime_TextBox);
            this.Controls.Add(this.startTime_TextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.date_MonthCalendar);
            this.Controls.Add(this.url_TextBox);
            this.Controls.Add(this.type_TextBox);
            this.Controls.Add(this.contact_TextBox);
            this.Controls.Add(this.location_TextBox);
            this.Controls.Add(this.description_TextBox);
            this.Controls.Add(this.title_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerID_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.cancel_Button);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddAppointment_Form";
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerID_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox title_TextBox;
        private System.Windows.Forms.TextBox description_TextBox;
        private System.Windows.Forms.TextBox location_TextBox;
        private System.Windows.Forms.TextBox contact_TextBox;
        private System.Windows.Forms.TextBox type_TextBox;
        private System.Windows.Forms.TextBox url_TextBox;
        private System.Windows.Forms.MonthCalendar date_MonthCalendar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox startTime_TextBox;
        private System.Windows.Forms.TextBox endTime_TextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
    }
}