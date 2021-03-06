﻿namespace SchedulingForms
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
            this.end_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.start_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(15, 215);
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
            this.save_Button.Location = new System.Drawing.Point(289, 215);
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
            // end_TimePicker
            // 
            this.end_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end_TimePicker.Location = new System.Drawing.Point(614, 227);
            this.end_TimePicker.Name = "end_TimePicker";
            this.end_TimePicker.Size = new System.Drawing.Size(150, 25);
            this.end_TimePicker.TabIndex = 65;
            this.end_TimePicker.Value = new System.DateTime(2020, 8, 18, 17, 0, 0, 0);
            // 
            // start_TimePicker
            // 
            this.start_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.start_TimePicker.Location = new System.Drawing.Point(614, 158);
            this.start_TimePicker.Name = "start_TimePicker";
            this.start_TimePicker.Size = new System.Drawing.Size(150, 25);
            this.start_TimePicker.TabIndex = 64;
            this.start_TimePicker.Value = new System.DateTime(2020, 8, 17, 8, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 63;
            this.label9.Text = "End Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(610, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 19);
            this.label11.TabIndex = 62;
            this.label11.Text = "Start Time";
            // 
            // AddAppointment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 291);
            this.Controls.Add(this.end_TimePicker);
            this.Controls.Add(this.start_TimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
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
        private System.Windows.Forms.DateTimePicker end_TimePicker;
        private System.Windows.Forms.DateTimePicker start_TimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}