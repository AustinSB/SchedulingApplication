namespace SchedulingForms
{
    partial class Login_Form
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
            this.username_Label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Location = new System.Drawing.Point(15, 125);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(71, 19);
            this.username_Label.TabIndex = 0;
            this.username_Label.Text = "Username";
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Location = new System.Drawing.Point(15, 275);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(67, 19);
            this.password_Label.TabIndex = 1;
            this.password_Label.Text = "Password";
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(100, 275);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(215, 25);
            this.password_TextBox.TabIndex = 2;
            // 
            // username_TextBox
            // 
            this.username_TextBox.Location = new System.Drawing.Point(100, 125);
            this.username_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(215, 25);
            this.username_TextBox.TabIndex = 1;
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(300, 400);
            this.login_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 50);
            this.login_Button.TabIndex = 4;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(10, 400);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 50);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.username_TextBox);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.username_Label);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login_Form";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_Label;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}