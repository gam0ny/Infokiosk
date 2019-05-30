namespace HTMLEditorCSharp
{
    partial class FontForm
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
            this.faceTextBox = new System.Windows.Forms.TextBox();
            this.faceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eqRadioButton = new System.Windows.Forms.RadioButton();
            this.plusRadioButton = new System.Windows.Forms.RadioButton();
            this.minusRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.colorChangeButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "face";
            // 
            // faceTextBox
            // 
            this.faceTextBox.Location = new System.Drawing.Point(30, 50);
            this.faceTextBox.Name = "faceTextBox";
            this.faceTextBox.ReadOnly = true;
            this.faceTextBox.Size = new System.Drawing.Size(150, 20);
            this.faceTextBox.TabIndex = 1;
            this.faceTextBox.TextChanged += new System.EventHandler(this.faceTextBox_TextChanged);
            // 
            // faceButton
            // 
            this.faceButton.Location = new System.Drawing.Point(30, 77);
            this.faceButton.Name = "faceButton";
            this.faceButton.Size = new System.Drawing.Size(75, 23);
            this.faceButton.TabIndex = 2;
            this.faceButton.Text = "Change";
            this.faceButton.UseVisualStyleBackColor = true;
            this.faceButton.Click += new System.EventHandler(this.faceButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "size";
            // 
            // eqRadioButton
            // 
            this.eqRadioButton.AutoSize = true;
            this.eqRadioButton.Location = new System.Drawing.Point(197, 50);
            this.eqRadioButton.Name = "eqRadioButton";
            this.eqRadioButton.Size = new System.Drawing.Size(31, 17);
            this.eqRadioButton.TabIndex = 4;
            this.eqRadioButton.TabStop = true;
            this.eqRadioButton.Text = "=";
            this.eqRadioButton.UseVisualStyleBackColor = true;
            // 
            // plusRadioButton
            // 
            this.plusRadioButton.AutoSize = true;
            this.plusRadioButton.Location = new System.Drawing.Point(197, 77);
            this.plusRadioButton.Name = "plusRadioButton";
            this.plusRadioButton.Size = new System.Drawing.Size(31, 17);
            this.plusRadioButton.TabIndex = 5;
            this.plusRadioButton.TabStop = true;
            this.plusRadioButton.Text = "+";
            this.plusRadioButton.UseVisualStyleBackColor = true;
            this.plusRadioButton.CheckedChanged += new System.EventHandler(this.plusRadioButton_CheckedChanged);
            // 
            // minusRadioButton
            // 
            this.minusRadioButton.AutoSize = true;
            this.minusRadioButton.Location = new System.Drawing.Point(197, 100);
            this.minusRadioButton.Name = "minusRadioButton";
            this.minusRadioButton.Size = new System.Drawing.Size(28, 17);
            this.minusRadioButton.TabIndex = 6;
            this.minusRadioButton.TabStop = true;
            this.minusRadioButton.Text = "-";
            this.minusRadioButton.UseVisualStyleBackColor = true;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(235, 77);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(35, 20);
            this.sizeTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "color";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Enabled = false;
            this.colorTextBox.Location = new System.Drawing.Point(324, 49);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(19, 20);
            this.colorTextBox.TabIndex = 9;
            // 
            // colorChangeButton
            // 
            this.colorChangeButton.Location = new System.Drawing.Point(324, 77);
            this.colorChangeButton.Name = "colorChangeButton";
            this.colorChangeButton.Size = new System.Drawing.Size(75, 23);
            this.colorChangeButton.TabIndex = 10;
            this.colorChangeButton.Text = "Change";
            this.colorChangeButton.UseVisualStyleBackColor = true;
            this.colorChangeButton.Click += new System.EventHandler(this.colorChangeButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(472, 49);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 158);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.colorChangeButton);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.minusRadioButton);
            this.Controls.Add(this.plusRadioButton);
            this.Controls.Add(this.eqRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.faceButton);
            this.Controls.Add(this.faceTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FontForm";
            this.Text = "FontForm";
            this.Load += new System.EventHandler(this.FontForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox faceTextBox;
        private System.Windows.Forms.Button faceButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton eqRadioButton;
        private System.Windows.Forms.RadioButton plusRadioButton;
        private System.Windows.Forms.RadioButton minusRadioButton;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Button colorChangeButton;
        private System.Windows.Forms.Button OKButton;
    }
}