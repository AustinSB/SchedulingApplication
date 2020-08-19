namespace SchedulingForms
{
    partial class AddCustomer_Form
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
            this.components = new System.ComponentModel.Container();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.save_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.active_Radio = new System.Windows.Forms.RadioButton();
            this.notActive_Radio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressID_ComboBox = new System.Windows.Forms.ComboBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addAddress_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addCountry_Button = new System.Windows.Forms.Button();
            this.countryName_TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addCity_Button = new System.Windows.Forms.Button();
            this.cityName_TextBox = new System.Windows.Forms.TextBox();
            this.countryID_ComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phone_TextBox = new System.Windows.Forms.TextBox();
            this.postal_TextBox = new System.Windows.Forms.TextBox();
            this.address2_TextBox = new System.Windows.Forms.TextBox();
            this.address1_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cityID_ComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(100, 40);
            this.name_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(125, 25);
            this.name_TextBox.TabIndex = 1;
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(150, 344);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(75, 40);
            this.save_Button.TabIndex = 8;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(12, 344);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(75, 40);
            this.cancel_Button.TabIndex = 9;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Active";
            // 
            // active_Radio
            // 
            this.active_Radio.AutoSize = true;
            this.active_Radio.Checked = true;
            this.active_Radio.Location = new System.Drawing.Point(3, 3);
            this.active_Radio.Name = "active_Radio";
            this.active_Radio.Size = new System.Drawing.Size(47, 23);
            this.active_Radio.TabIndex = 0;
            this.active_Radio.TabStop = true;
            this.active_Radio.Text = "Yes";
            this.active_Radio.UseVisualStyleBackColor = true;
            // 
            // notActive_Radio
            // 
            this.notActive_Radio.AutoSize = true;
            this.notActive_Radio.Location = new System.Drawing.Point(71, 3);
            this.notActive_Radio.Name = "notActive_Radio";
            this.notActive_Radio.Size = new System.Drawing.Size(45, 23);
            this.notActive_Radio.TabIndex = 1;
            this.notActive_Radio.Text = "No";
            this.notActive_Radio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.notActive_Radio);
            this.panel1.Controls.Add(this.active_Radio);
            this.panel1.Location = new System.Drawing.Point(100, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 28);
            this.panel1.TabIndex = 18;
            // 
            // addressID_ComboBox
            // 
            this.addressID_ComboBox.FormattingEnabled = true;
            this.addressID_ComboBox.Location = new System.Drawing.Point(100, 80);
            this.addressID_ComboBox.Name = "addressID_ComboBox";
            this.addressID_ComboBox.Size = new System.Drawing.Size(125, 25);
            this.addressID_ComboBox.TabIndex = 19;
            this.addressID_ComboBox.SelectedIndexChanged += new System.EventHandler(this.addressID_ComboBox_SelectedIndexChanged);
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(SchedulingDataModel.address);
            // 
            // addAddress_Button
            // 
            this.addAddress_Button.Location = new System.Drawing.Point(94, 275);
            this.addAddress_Button.Name = "addAddress_Button";
            this.addAddress_Button.Size = new System.Drawing.Size(125, 30);
            this.addAddress_Button.TabIndex = 20;
            this.addAddress_Button.Text = "Add Address";
            this.addAddress_Button.UseVisualStyleBackColor = true;
            this.addAddress_Button.Click += new System.EventHandler(this.addAddress_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addCountry_Button);
            this.panel2.Controls.Add(this.countryName_TextBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(540, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 160);
            this.panel2.TabIndex = 32;
            // 
            // addCountry_Button
            // 
            this.addCountry_Button.Location = new System.Drawing.Point(116, 113);
            this.addCountry_Button.Name = "addCountry_Button";
            this.addCountry_Button.Size = new System.Drawing.Size(125, 30);
            this.addCountry_Button.TabIndex = 3;
            this.addCountry_Button.Text = "Add Country";
            this.addCountry_Button.UseVisualStyleBackColor = true;
            this.addCountry_Button.Click += new System.EventHandler(this.addCountry_Button_Click);
            // 
            // countryName_TextBox
            // 
            this.countryName_TextBox.Location = new System.Drawing.Point(116, 69);
            this.countryName_TextBox.Name = "countryName_TextBox";
            this.countryName_TextBox.Size = new System.Drawing.Size(125, 25);
            this.countryName_TextBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Country Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Add New Country";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addCity_Button);
            this.panel3.Controls.Add(this.cityName_TextBox);
            this.panel3.Controls.Add(this.countryID_ComboBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(540, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 200);
            this.panel3.TabIndex = 31;
            // 
            // addCity_Button
            // 
            this.addCity_Button.Location = new System.Drawing.Point(95, 153);
            this.addCity_Button.Name = "addCity_Button";
            this.addCity_Button.Size = new System.Drawing.Size(125, 30);
            this.addCity_Button.TabIndex = 5;
            this.addCity_Button.Text = "Add City";
            this.addCity_Button.UseVisualStyleBackColor = true;
            this.addCity_Button.Click += new System.EventHandler(this.addCity_Button_Click);
            // 
            // cityName_TextBox
            // 
            this.cityName_TextBox.Location = new System.Drawing.Point(95, 70);
            this.cityName_TextBox.Name = "cityName_TextBox";
            this.cityName_TextBox.Size = new System.Drawing.Size(125, 25);
            this.cityName_TextBox.TabIndex = 4;
            // 
            // countryID_ComboBox
            // 
            this.countryID_ComboBox.FormattingEnabled = true;
            this.countryID_ComboBox.Location = new System.Drawing.Point(95, 113);
            this.countryID_ComboBox.Name = "countryID_ComboBox";
            this.countryID_ComboBox.Size = new System.Drawing.Size(125, 25);
            this.countryID_ComboBox.TabIndex = 3;
            this.countryID_ComboBox.SelectedIndexChanged += new System.EventHandler(this.countryID_ComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Add New City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Country ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "City Name";
            // 
            // phone_TextBox
            // 
            this.phone_TextBox.Location = new System.Drawing.Point(94, 227);
            this.phone_TextBox.Name = "phone_TextBox";
            this.phone_TextBox.Size = new System.Drawing.Size(125, 25);
            this.phone_TextBox.TabIndex = 28;
            this.phone_TextBox.Text = "##########";
            this.phone_TextBox.TextChanged += new System.EventHandler(this.phone_TextBox_TextChanged);
            // 
            // postal_TextBox
            // 
            this.postal_TextBox.Location = new System.Drawing.Point(94, 190);
            this.postal_TextBox.Name = "postal_TextBox";
            this.postal_TextBox.Size = new System.Drawing.Size(125, 25);
            this.postal_TextBox.TabIndex = 27;
            this.postal_TextBox.Text = "#####";
            this.postal_TextBox.Enter += new System.EventHandler(this.postal_TextBox_Enter);
            // 
            // address2_TextBox
            // 
            this.address2_TextBox.Location = new System.Drawing.Point(94, 107);
            this.address2_TextBox.Name = "address2_TextBox";
            this.address2_TextBox.Size = new System.Drawing.Size(125, 25);
            this.address2_TextBox.TabIndex = 24;
            // 
            // address1_TextBox
            // 
            this.address1_TextBox.Location = new System.Drawing.Point(94, 70);
            this.address1_TextBox.Name = "address1_TextBox";
            this.address1_TextBox.Size = new System.Drawing.Size(125, 25);
            this.address1_TextBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Postal Code";
            // 
            // cityID_ComboBox
            // 
            this.cityID_ComboBox.FormattingEnabled = true;
            this.cityID_ComboBox.Location = new System.Drawing.Point(94, 150);
            this.cityID_ComboBox.Name = "cityID_ComboBox";
            this.cityID_ComboBox.Size = new System.Drawing.Size(125, 25);
            this.cityID_ComboBox.TabIndex = 26;
            this.cityID_ComboBox.SelectedIndexChanged += new System.EventHandler(this.cityID_ComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "City ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Address 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "Address";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.addAddress_Button);
            this.panel4.Controls.Add(this.phone_TextBox);
            this.panel4.Controls.Add(this.cityID_ComboBox);
            this.panel4.Controls.Add(this.postal_TextBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.address2_TextBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.address1_TextBox);
            this.panel4.Location = new System.Drawing.Point(275, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 366);
            this.panel4.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 19);
            this.label14.TabIndex = 31;
            this.label14.Text = "Add New Address";
            // 
            // AddCustomer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 407);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.addressID_ComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.name_TextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCustomer_Form";
            this.Text = "Add New Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton active_Radio;
        private System.Windows.Forms.RadioButton notActive_Radio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox addressID_ComboBox;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.Button addAddress_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addCountry_Button;
        private System.Windows.Forms.TextBox countryName_TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addCity_Button;
        private System.Windows.Forms.TextBox cityName_TextBox;
        private System.Windows.Forms.ComboBox countryID_ComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone_TextBox;
        private System.Windows.Forms.TextBox postal_TextBox;
        private System.Windows.Forms.TextBox address2_TextBox;
        private System.Windows.Forms.TextBox address1_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cityID_ComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
    }
}