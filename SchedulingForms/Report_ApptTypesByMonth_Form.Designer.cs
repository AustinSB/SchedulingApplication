namespace SchedulingForms
{
    partial class Report_ApptTypesByMonth_Form
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
            this.display_TextBox = new System.Windows.Forms.RichTextBox();
            this.close_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display_TextBox
            // 
            this.display_TextBox.Location = new System.Drawing.Point(14, 16);
            this.display_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.display_TextBox.Name = "display_TextBox";
            this.display_TextBox.Size = new System.Drawing.Size(558, 384);
            this.display_TextBox.TabIndex = 0;
            this.display_TextBox.Text = "";
            // 
            // close_Button
            // 
            this.close_Button.Location = new System.Drawing.Point(14, 408);
            this.close_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(75, 40);
            this.close_Button.TabIndex = 1;
            this.close_Button.Text = "Close";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // Report_ApptTypesByMonth_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 457);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.display_TextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Report_ApptTypesByMonth_Form";
            this.Text = "Appointment Types by Month";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox display_TextBox;
        private System.Windows.Forms.Button close_Button;
    }
}