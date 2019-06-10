namespace InfokioskAdministrationDesktopApplication
{
    partial class ManageVideoTagForm
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
            this.panelPreview = new System.Windows.Forms.Panel();
            this.lblPreview = new System.Windows.Forms.Label();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxSrc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxStyle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxControls = new System.Windows.Forms.CheckBox();
            this.cbxMediaType = new System.Windows.Forms.ComboBox();
            this.mtbxWidth = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbxHeight = new System.Windows.Forms.MaskedTextBox();
            this.panelPreview.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPreview
            // 
            this.panelPreview.AutoScroll = true;
            this.panelPreview.Controls.Add(this.lblPreview);
            this.panelPreview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPreview.Location = new System.Drawing.Point(0, 805);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(826, 198);
            this.panelPreview.TabIndex = 2;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoEllipsis = true;
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Arial Unicode MS", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPreview.ForeColor = System.Drawing.Color.White;
            this.lblPreview.Location = new System.Drawing.Point(12, 33);
            this.lblPreview.MaximumSize = new System.Drawing.Size(800, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(253, 34);
            this.lblPreview.TabIndex = 0;
            this.lblPreview.Text = "<h1>SomeText</h1>";
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.btnCancel);
            this.flowLayoutPanelButtons.Controls.Add(this.btnAdd);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 1003);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Padding = new System.Windows.Forms.Padding(30, 30, 0, 30);
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(826, 134);
            this.flowLayoutPanelButtons.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("FontAwesome", 14.15029F);
            this.btnCancel.Location = new System.Drawing.Point(593, 33);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 70);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = " Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("FontAwesome", 14.15029F);
            this.btnAdd.Location = new System.Drawing.Point(387, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 70);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = " Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Controls.Add(this.tbxSrc, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxStyle, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxClass, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbxControls, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbxMediaType, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.mtbxWidth, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.mtbxHeight, 3, 13);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 805);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tbxSrc
            // 
            this.tbxSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSrc.Enabled = false;
            this.tbxSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.82081F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSrc.Location = new System.Drawing.Point(241, 23);
            this.tbxSrc.Multiline = true;
            this.tbxSrc.Name = "tbxSrc";
            this.tbxSrc.Size = new System.Drawing.Size(456, 64);
            this.tbxSrc.TabIndex = 1;
            this.tbxSrc.TextChanged += new System.EventHandler(this.TbxSrc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "style = ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 70);
            this.label2.TabIndex = 2;
            this.label2.Text = "src = ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxStyle
            // 
            this.tbxStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.82081F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxStyle.Location = new System.Drawing.Point(241, 113);
            this.tbxStyle.Multiline = true;
            this.tbxStyle.Name = "tbxStyle";
            this.tbxStyle.Size = new System.Drawing.Size(456, 64);
            this.tbxStyle.TabIndex = 3;
            this.tbxStyle.TextChanged += new System.EventHandler(this.TbxStyle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 70);
            this.label3.TabIndex = 4;
            this.label3.Text = "class = ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxClass
            // 
            this.tbxClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.82081F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxClass.Location = new System.Drawing.Point(241, 203);
            this.tbxClass.Multiline = true;
            this.tbxClass.Name = "tbxClass";
            this.tbxClass.Size = new System.Drawing.Size(456, 64);
            this.tbxClass.TabIndex = 5;
            this.tbxClass.TextChanged += new System.EventHandler(this.TbxClass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 70);
            this.label4.TabIndex = 6;
            this.label4.Text = "controls";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.Location = new System.Drawing.Point(703, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 64);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Обзор";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 70);
            this.label5.TabIndex = 8;
            this.label5.Text = "type =";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxControls
            // 
            this.cbxControls.AutoSize = true;
            this.cbxControls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxControls.Location = new System.Drawing.Point(241, 293);
            this.cbxControls.Name = "cbxControls";
            this.cbxControls.Size = new System.Drawing.Size(22, 64);
            this.cbxControls.TabIndex = 11;
            this.cbxControls.UseVisualStyleBackColor = true;
            this.cbxControls.CheckedChanged += new System.EventHandler(this.CbxControls_CheckedChanged);
            // 
            // cbxMediaType
            // 
            this.cbxMediaType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxMediaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMediaType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.82081F);
            this.cbxMediaType.FormattingEnabled = true;
            this.cbxMediaType.Items.AddRange(new object[] {
            "video/mp4",
            "video/webm",
            "video/ogg"});
            this.cbxMediaType.Location = new System.Drawing.Point(241, 383);
            this.cbxMediaType.Name = "cbxMediaType";
            this.cbxMediaType.Size = new System.Drawing.Size(456, 38);
            this.cbxMediaType.TabIndex = 12;
            this.cbxMediaType.SelectedIndexChanged += new System.EventHandler(this.CbxMediaType_SelectedIndexChanged);
            // 
            // mtbxWidth
            // 
            this.mtbxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbxWidth.Location = new System.Drawing.Point(241, 473);
            this.mtbxWidth.Mask = "00000";
            this.mtbxWidth.Name = "mtbxWidth";
            this.mtbxWidth.Size = new System.Drawing.Size(456, 51);
            this.mtbxWidth.TabIndex = 14;
            this.mtbxWidth.ValidatingType = typeof(int);
            this.mtbxWidth.TextChanged += new System.EventHandler(this.MtbxWidth_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 70);
            this.label6.TabIndex = 13;
            this.label6.Text = "width =";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 70);
            this.label7.TabIndex = 15;
            this.label7.Text = "height =";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtbxHeight
            // 
            this.mtbxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbxHeight.Location = new System.Drawing.Point(241, 563);
            this.mtbxHeight.Mask = "00000";
            this.mtbxHeight.Name = "mtbxHeight";
            this.mtbxHeight.Size = new System.Drawing.Size(456, 51);
            this.mtbxHeight.TabIndex = 16;
            this.mtbxHeight.ValidatingType = typeof(int);
            this.mtbxHeight.TextChanged += new System.EventHandler(this.MtbxHeight_TextChanged);
            // 
            // ManageVideoTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(826, 1137);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.flowLayoutPanelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(0, 900);
            this.Name = "ManageVideoTagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxStyle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxControls;
        private System.Windows.Forms.ComboBox cbxMediaType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbxWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbxHeight;
    }
}