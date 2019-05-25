﻿namespace InfokioskDesktopApplication
{
    partial class InfokioskSearchArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfokioskSearchArticleForm));
            this.lblBack = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.tableLayoutPanelSearchCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.panelSearchCriteria = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbContent = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.panelSearchResult = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelSearchCriteria.SuspendLayout();
            this.panelSearchCriteria.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBack.Font = new System.Drawing.Font("FontAwesome", 14.98266F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Yellow;
            this.lblBack.Location = new System.Drawing.Point(1026, 0);
            this.lblBack.Margin = new System.Windows.Forms.Padding(0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.lblBack.Size = new System.Drawing.Size(50, 737);
            this.lblBack.TabIndex = 6;
            this.lblBack.Text = "";
            this.lblBack.Click += new System.EventHandler(this.LblBack_Click);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("FontAwesome", 14.98266F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Yellow;
            this.lblExit.Location = new System.Drawing.Point(1076, 0);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.lblExit.Size = new System.Drawing.Size(50, 737);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // tableLayoutPanelSearchCriteria
            // 
            this.tableLayoutPanelSearchCriteria.ColumnCount = 2;
            this.tableLayoutPanelSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSearchCriteria.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanelSearchCriteria.Controls.Add(this.tbxSearch, 0, 0);
            this.tableLayoutPanelSearchCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelSearchCriteria.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSearchCriteria.Name = "tableLayoutPanelSearchCriteria";
            this.tableLayoutPanelSearchCriteria.RowCount = 1;
            this.tableLayoutPanelSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelSearchCriteria.Size = new System.Drawing.Size(1026, 100);
            this.tableLayoutPanelSearchCriteria.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(926, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 94);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSearch.Location = new System.Drawing.Point(3, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(917, 29);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.TbxSearch_TextChanged);
            // 
            // panelSearchCriteria
            // 
            this.panelSearchCriteria.Controls.Add(this.groupBox1);
            this.panelSearchCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchCriteria.Location = new System.Drawing.Point(0, 100);
            this.panelSearchCriteria.Name = "panelSearchCriteria";
            this.panelSearchCriteria.Size = new System.Drawing.Size(1026, 100);
            this.panelSearchCriteria.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbContent);
            this.groupBox1.Controls.Add(this.rbName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по";
            // 
            // rbContent
            // 
            this.rbContent.AutoSize = true;
            this.rbContent.Location = new System.Drawing.Point(190, 42);
            this.rbContent.Name = "rbContent";
            this.rbContent.Size = new System.Drawing.Size(174, 29);
            this.rbContent.TabIndex = 1;
            this.rbContent.Text = "содержимому";
            this.rbContent.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Checked = true;
            this.rbName.Location = new System.Drawing.Point(21, 42);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(98, 29);
            this.rbName.TabIndex = 0;
            this.rbName.TabStop = true;
            this.rbName.Text = "имени";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // panelSearchResult
            // 
            this.panelSearchResult.Controls.Add(this.pbLoading);
            this.panelSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchResult.Location = new System.Drawing.Point(0, 200);
            this.panelSearchResult.Name = "panelSearchResult";
            this.panelSearchResult.Size = new System.Drawing.Size(1026, 537);
            this.panelSearchResult.TabIndex = 8;
            // 
            // pbLoading
            // 
            this.pbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(0, 0);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(1026, 537);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoading.TabIndex = 4;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // InfokioskSearchArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1176, 737);
            this.Controls.Add(this.panelSearchResult);
            this.Controls.Add(this.panelSearchCriteria);
            this.Controls.Add(this.tableLayoutPanelSearchCriteria);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblExit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "InfokioskSearchArticleForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.Text = "Поиск статьи";
            this.tableLayoutPanelSearchCriteria.ResumeLayout(false);
            this.tableLayoutPanelSearchCriteria.PerformLayout();
            this.panelSearchCriteria.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearchCriteria;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Panel panelSearchCriteria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbContent;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.Panel panelSearchResult;
        private System.Windows.Forms.PictureBox pbLoading;
    }
}