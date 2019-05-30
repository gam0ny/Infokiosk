namespace HTMLEditorCSharp
{
    partial class AForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "link to: ";
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(71, 18);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(189, 20);
            this.linkTextBox.TabIndex = 1;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(267, 18);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 20);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(391, 12);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 43);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 67);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AForm";
            this.Text = "AForm";
            this.Load += new System.EventHandler(this.AForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button OKButton;
    }
}