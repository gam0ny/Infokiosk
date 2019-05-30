namespace HTMLEditorCSharp
{
    partial class saveChangesInFileDialogForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Changes in File???";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(53, 53);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(120, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Yes, Please...";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(216, 53);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(112, 23);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No, Thank You... ";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // saveChangesInFileDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 98);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Name = "saveChangesInFileDialogForm";
            this.Text = "saveChangesInFileDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button noButton;
    }
}