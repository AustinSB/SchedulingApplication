namespace SchedulingForms
{
    partial class Report_AllCustomers_Form
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
            this.close_Button = new System.Windows.Forms.Button();
            this.display_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // close_Button
            // 
            this.close_Button.Location = new System.Drawing.Point(12, 405);
            this.close_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(75, 40);
            this.close_Button.TabIndex = 5;
            this.close_Button.Text = "Close";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // display_TextBox
            // 
            this.display_TextBox.Location = new System.Drawing.Point(12, 13);
            this.display_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.display_TextBox.Name = "display_TextBox";
            this.display_TextBox.Size = new System.Drawing.Size(558, 384);
            this.display_TextBox.TabIndex = 4;
            this.display_TextBox.Text = "";
            // 
            // Report_AllCustomers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.display_TextBox);
            this.Name = "Report_AllCustomers_Form";
            this.Text = "Report_AllCustomers_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.RichTextBox display_TextBox;
    }
}