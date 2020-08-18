namespace SchedulingForms
{
    partial class CustomMessageBox_Form
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
            this.message_Label = new System.Windows.Forms.Label();
            this.no_Button = new System.Windows.Forms.Button();
            this.yes_Button = new System.Windows.Forms.Button();
            this.ok_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_Label
            // 
            this.message_Label.AutoSize = true;
            this.message_Label.Location = new System.Drawing.Point(12, 9);
            this.message_Label.MaximumSize = new System.Drawing.Size(275, 0);
            this.message_Label.Name = "message_Label";
            this.message_Label.Size = new System.Drawing.Size(62, 19);
            this.message_Label.TabIndex = 0;
            this.message_Label.Text = "message";
            // 
            // no_Button
            // 
            this.no_Button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.no_Button.Location = new System.Drawing.Point(10, 100);
            this.no_Button.Name = "no_Button";
            this.no_Button.Size = new System.Drawing.Size(75, 30);
            this.no_Button.TabIndex = 1;
            this.no_Button.Text = "No";
            this.no_Button.UseVisualStyleBackColor = true;
            // 
            // yes_Button
            // 
            this.yes_Button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yes_Button.Location = new System.Drawing.Point(200, 100);
            this.yes_Button.Name = "yes_Button";
            this.yes_Button.Size = new System.Drawing.Size(75, 30);
            this.yes_Button.TabIndex = 2;
            this.yes_Button.Text = "Yes";
            this.yes_Button.UseVisualStyleBackColor = true;
            // 
            // ok_Button
            // 
            this.ok_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_Button.Location = new System.Drawing.Point(200, 12);
            this.ok_Button.Name = "ok_Button";
            this.ok_Button.Size = new System.Drawing.Size(75, 30);
            this.ok_Button.TabIndex = 3;
            this.ok_Button.Text = "OK";
            this.ok_Button.UseVisualStyleBackColor = true;
            // 
            // CustomMessageBox_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.ok_Button);
            this.Controls.Add(this.yes_Button);
            this.Controls.Add(this.no_Button);
            this.Controls.Add(this.message_Label);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomMessageBox_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message_Label;
        private System.Windows.Forms.Button no_Button;
        private System.Windows.Forms.Button yes_Button;
        private System.Windows.Forms.Button ok_Button;
    }
}