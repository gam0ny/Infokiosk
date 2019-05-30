namespace HTMLEditorCSharp
{
    partial class SettingsForm
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
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.parameterTextBox = new System.Windows.Forms.TextBox();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.specSymbolTextBox = new System.Windows.Forms.TextBox();
            this.tagRadioButton = new System.Windows.Forms.RadioButton();
            this.parameterRadioButton = new System.Windows.Forms.RadioButton();
            this.textRadioButton = new System.Windows.Forms.RadioButton();
            this.commentRadioButton = new System.Windows.Forms.RadioButton();
            this.specSymbolRadioButton = new System.Windows.Forms.RadioButton();
            this.changeButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tagTextBox
            // 
            this.tagTextBox.Enabled = false;
            this.tagTextBox.Location = new System.Drawing.Point(26, 23);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(22, 20);
            this.tagTextBox.TabIndex = 0;
            // 
            // parameterTextBox
            // 
            this.parameterTextBox.Enabled = false;
            this.parameterTextBox.Location = new System.Drawing.Point(26, 59);
            this.parameterTextBox.Name = "parameterTextBox";
            this.parameterTextBox.Size = new System.Drawing.Size(22, 20);
            this.parameterTextBox.TabIndex = 1;
            this.parameterTextBox.TextChanged += new System.EventHandler(this.parameterTextBox_TextChanged);
            // 
            // textTextBox
            // 
            this.textTextBox.Enabled = false;
            this.textTextBox.Location = new System.Drawing.Point(26, 95);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(22, 20);
            this.textTextBox.TabIndex = 2;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Enabled = false;
            this.commentTextBox.Location = new System.Drawing.Point(26, 132);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(22, 20);
            this.commentTextBox.TabIndex = 3;
            // 
            // specSymbolTextBox
            // 
            this.specSymbolTextBox.Enabled = false;
            this.specSymbolTextBox.Location = new System.Drawing.Point(26, 168);
            this.specSymbolTextBox.Name = "specSymbolTextBox";
            this.specSymbolTextBox.Size = new System.Drawing.Size(22, 20);
            this.specSymbolTextBox.TabIndex = 4;
            // 
            // tagRadioButton
            // 
            this.tagRadioButton.AutoSize = true;
            this.tagRadioButton.Location = new System.Drawing.Point(68, 25);
            this.tagRadioButton.Name = "tagRadioButton";
            this.tagRadioButton.Size = new System.Drawing.Size(71, 17);
            this.tagRadioButton.TabIndex = 5;
            this.tagRadioButton.TabStop = true;
            this.tagRadioButton.Text = "Tag Color";
            this.tagRadioButton.UseVisualStyleBackColor = true;
            // 
            // parameterRadioButton
            // 
            this.parameterRadioButton.AutoSize = true;
            this.parameterRadioButton.Location = new System.Drawing.Point(68, 62);
            this.parameterRadioButton.Name = "parameterRadioButton";
            this.parameterRadioButton.Size = new System.Drawing.Size(100, 17);
            this.parameterRadioButton.TabIndex = 6;
            this.parameterRadioButton.TabStop = true;
            this.parameterRadioButton.Text = "Parameter Color";
            this.parameterRadioButton.UseVisualStyleBackColor = true;
            // 
            // textRadioButton
            // 
            this.textRadioButton.AutoSize = true;
            this.textRadioButton.Location = new System.Drawing.Point(68, 98);
            this.textRadioButton.Name = "textRadioButton";
            this.textRadioButton.Size = new System.Drawing.Size(70, 17);
            this.textRadioButton.TabIndex = 7;
            this.textRadioButton.TabStop = true;
            this.textRadioButton.Text = "TextColor";
            this.textRadioButton.UseVisualStyleBackColor = true;
            // 
            // commentRadioButton
            // 
            this.commentRadioButton.AutoSize = true;
            this.commentRadioButton.Location = new System.Drawing.Point(68, 135);
            this.commentRadioButton.Name = "commentRadioButton";
            this.commentRadioButton.Size = new System.Drawing.Size(96, 17);
            this.commentRadioButton.TabIndex = 8;
            this.commentRadioButton.TabStop = true;
            this.commentRadioButton.Text = "Comment Color";
            this.commentRadioButton.UseVisualStyleBackColor = true;
            // 
            // specSymbolRadioButton
            // 
            this.specSymbolRadioButton.AutoSize = true;
            this.specSymbolRadioButton.Location = new System.Drawing.Point(68, 171);
            this.specSymbolRadioButton.Name = "specSymbolRadioButton";
            this.specSymbolRadioButton.Size = new System.Drawing.Size(124, 17);
            this.specSymbolRadioButton.TabIndex = 9;
            this.specSymbolRadioButton.TabStop = true;
            this.specSymbolRadioButton.Text = "Special Symbol Color";
            this.specSymbolRadioButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(243, 92);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(436, 62);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 77);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 216);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.specSymbolRadioButton);
            this.Controls.Add(this.commentRadioButton);
            this.Controls.Add(this.textRadioButton);
            this.Controls.Add(this.parameterRadioButton);
            this.Controls.Add(this.tagRadioButton);
            this.Controls.Add(this.specSymbolTextBox);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.parameterTextBox);
            this.Controls.Add(this.tagTextBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tagTextBox;
        private System.Windows.Forms.TextBox parameterTextBox;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox specSymbolTextBox;
        private System.Windows.Forms.RadioButton tagRadioButton;
        private System.Windows.Forms.RadioButton parameterRadioButton;
        private System.Windows.Forms.RadioButton textRadioButton;
        private System.Windows.Forms.RadioButton commentRadioButton;
        private System.Windows.Forms.RadioButton specSymbolRadioButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button OKButton;
    }
}