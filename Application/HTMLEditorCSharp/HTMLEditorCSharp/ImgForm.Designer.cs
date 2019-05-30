namespace HTMLEditorCSharp
{
    partial class ImgForm
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
            this.scrTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.altTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lowsrcTextBox = new System.Windows.Forms.TextBox();
            this.scrButton = new System.Windows.Forms.Button();
            this.lowsrcButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.pixelRadioButton = new System.Windows.Forms.RadioButton();
            this.percentRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "src=";
            // 
            // scrTextBox
            // 
            this.scrTextBox.Location = new System.Drawing.Point(64, 5);
            this.scrTextBox.Name = "scrTextBox";
            this.scrTextBox.Size = new System.Drawing.Size(232, 20);
            this.scrTextBox.TabIndex = 1;
            this.scrTextBox.TextChanged += new System.EventHandler(this.scrTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "alt=";
            // 
            // altTextBox
            // 
            this.altTextBox.Location = new System.Drawing.Point(64, 33);
            this.altTextBox.Name = "altTextBox";
            this.altTextBox.Size = new System.Drawing.Size(232, 20);
            this.altTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "lowsrc=";
            // 
            // lowsrcTextBox
            // 
            this.lowsrcTextBox.Location = new System.Drawing.Point(64, 58);
            this.lowsrcTextBox.Name = "lowsrcTextBox";
            this.lowsrcTextBox.Size = new System.Drawing.Size(232, 20);
            this.lowsrcTextBox.TabIndex = 5;
            this.lowsrcTextBox.TextChanged += new System.EventHandler(this.lowsrcTextBox_TextChanged);
            // 
            // scrButton
            // 
            this.scrButton.Location = new System.Drawing.Point(302, 5);
            this.scrButton.Name = "scrButton";
            this.scrButton.Size = new System.Drawing.Size(75, 21);
            this.scrButton.TabIndex = 6;
            this.scrButton.Text = "change";
            this.scrButton.UseVisualStyleBackColor = true;
            this.scrButton.Click += new System.EventHandler(this.scrButton_Click);
            // 
            // lowsrcButton
            // 
            this.lowsrcButton.Location = new System.Drawing.Point(302, 58);
            this.lowsrcButton.Name = "lowsrcButton";
            this.lowsrcButton.Size = new System.Drawing.Size(75, 20);
            this.lowsrcButton.TabIndex = 7;
            this.lowsrcButton.Text = "change";
            this.lowsrcButton.UseVisualStyleBackColor = true;
            this.lowsrcButton.Click += new System.EventHandler(this.lowsrcButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "width=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "height=";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(64, 97);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(44, 20);
            this.widthTextBox.TabIndex = 10;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(64, 127);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(44, 20);
            this.heightTextBox.TabIndex = 11;
            // 
            // pixelRadioButton
            // 
            this.pixelRadioButton.AutoSize = true;
            this.pixelRadioButton.Location = new System.Drawing.Point(125, 115);
            this.pixelRadioButton.Name = "pixelRadioButton";
            this.pixelRadioButton.Size = new System.Drawing.Size(51, 17);
            this.pixelRadioButton.TabIndex = 12;
            this.pixelRadioButton.TabStop = true;
            this.pixelRadioButton.Text = "pixels";
            this.pixelRadioButton.UseVisualStyleBackColor = true;
            // 
            // percentRadioButton
            // 
            this.percentRadioButton.AutoSize = true;
            this.percentRadioButton.Location = new System.Drawing.Point(183, 115);
            this.percentRadioButton.Name = "percentRadioButton";
            this.percentRadioButton.Size = new System.Drawing.Size(69, 17);
            this.percentRadioButton.TabIndex = 13;
            this.percentRadioButton.TabStop = true;
            this.percentRadioButton.Text = "per cents";
            this.percentRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "align";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "none",
            "absbottom",
            "adsbottom",
            "baseline",
            "bottom",
            "middle",
            "texttop",
            "top"});
            this.listBox1.Location = new System.Drawing.Point(24, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 15;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "none",
            "left",
            "right"});
            this.listBox2.Location = new System.Drawing.Point(150, 182);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 43);
            this.listBox2.TabIndex = 16;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(341, 182);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(101, 94);
            this.OKButton.TabIndex = 17;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ImgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 330);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.percentRadioButton);
            this.Controls.Add(this.pixelRadioButton);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lowsrcButton);
            this.Controls.Add(this.scrButton);
            this.Controls.Add(this.lowsrcTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.altTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scrTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ImgForm";
            this.Text = "ImgForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scrTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox altTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lowsrcTextBox;
        private System.Windows.Forms.Button scrButton;
        private System.Windows.Forms.Button lowsrcButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.RadioButton pixelRadioButton;
        private System.Windows.Forms.RadioButton percentRadioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button OKButton;
    }
}