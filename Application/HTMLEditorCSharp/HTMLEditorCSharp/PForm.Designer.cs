namespace HTMLEditorCSharp
{
    partial class PForm
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
            this.OKBUtton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "align";
            // 
            // OKBUtton
            // 
            this.OKBUtton.Location = new System.Drawing.Point(216, 21);
            this.OKBUtton.Name = "OKBUtton";
            this.OKBUtton.Size = new System.Drawing.Size(75, 23);
            this.OKBUtton.TabIndex = 2;
            this.OKBUtton.Text = "OK";
            this.OKBUtton.UseVisualStyleBackColor = true;
            this.OKBUtton.Click += new System.EventHandler(this.OKBUtton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "none",
            "right",
            "left",
            "center",
            "justify"});
            this.listBox1.Location = new System.Drawing.Point(59, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 69);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 107);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.OKBUtton);
            this.Controls.Add(this.label1);
            this.Name = "PForm";
            this.Text = "PForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKBUtton;
        private System.Windows.Forms.ListBox listBox1;
    }
}