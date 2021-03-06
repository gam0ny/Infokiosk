﻿namespace InfokioskDesktopApplication
{
    partial class InfokioskArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfokioskArticleForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.flowLayoutTitlePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.lblEmailMessage = new System.Windows.Forms.Label();
            this.pbEmailSendingLoading = new System.Windows.Forms.PictureBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.flowLayoutTitlePanel.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailSendingLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("FontAwesome", 24.13873F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 59);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Заголовок";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(10, 86);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Yellow;
            this.lblCategory.Font = new System.Drawing.Font("FontAwesome", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(261, 10);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(10);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Padding = new System.Windows.Forms.Padding(10);
            this.lblCategory.Size = new System.Drawing.Size(148, 45);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "КАТЕГОРИЯ";
            // 
            // pbLoading
            // 
            this.pbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(0, 0);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(916, 737);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoading.TabIndex = 6;
            this.pbLoading.TabStop = false;
            // 
            // flowLayoutTitlePanel
            // 
            this.flowLayoutTitlePanel.AutoSize = true;
            this.flowLayoutTitlePanel.Controls.Add(this.lblTitle);
            this.flowLayoutTitlePanel.Controls.Add(this.lblCategory);
            this.flowLayoutTitlePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.flowLayoutTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutTitlePanel.Name = "flowLayoutTitlePanel";
            this.flowLayoutTitlePanel.Size = new System.Drawing.Size(419, 100);
            this.flowLayoutTitlePanel.TabIndex = 7;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.lblBack);
            this.panelToolbar.Controls.Add(this.lblExit);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelToolbar.Location = new System.Drawing.Point(926, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(200, 737);
            this.panelToolbar.TabIndex = 13;
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBack.Font = new System.Drawing.Font("FontAwesome", 14.98266F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.lblBack.Location = new System.Drawing.Point(60, 0);
            this.lblBack.Margin = new System.Windows.Forms.Padding(0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.lblBack.Size = new System.Drawing.Size(80, 737);
            this.lblBack.TabIndex = 7;
            this.lblBack.Text = "";
            this.lblBack.Click += new System.EventHandler(this.LblBack_Click);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("FontAwesome", 14.98266F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.lblExit.Location = new System.Drawing.Point(140, 0);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.lblExit.Size = new System.Drawing.Size(60, 737);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.pbLoading);
            this.panelContent.Controls.Add(this.webBrowser1);
            this.panelContent.Controls.Add(this.flowLayoutTitlePanel);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(10, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(916, 737);
            this.panelContent.TabIndex = 14;
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.lblEmailMessage);
            this.panelEmail.Controls.Add(this.pbEmailSendingLoading);
            this.panelEmail.Controls.Add(this.btnSendEmail);
            this.panelEmail.Controls.Add(this.tbxEmail);
            this.panelEmail.Controls.Add(this.label1);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEmail.Location = new System.Drawing.Point(10, 557);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.panelEmail.Size = new System.Drawing.Size(916, 180);
            this.panelEmail.TabIndex = 8;
            // 
            // lblEmailMessage
            // 
            this.lblEmailMessage.AutoSize = true;
            this.lblEmailMessage.Font = new System.Drawing.Font("FontAwesome", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailMessage.ForeColor = System.Drawing.Color.Lime;
            this.lblEmailMessage.Location = new System.Drawing.Point(1450, 30);
            this.lblEmailMessage.Name = "lblEmailMessage";
            this.lblEmailMessage.Size = new System.Drawing.Size(400, 39);
            this.lblEmailMessage.TabIndex = 9;
            this.lblEmailMessage.Text = " Отправлено успешно";
            this.lblEmailMessage.Visible = false;
            // 
            // pbEmailSendingLoading
            // 
            this.pbEmailSendingLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbEmailSendingLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbEmailSendingLoading.Image")));
            this.pbEmailSendingLoading.Location = new System.Drawing.Point(1415, 25);
            this.pbEmailSendingLoading.Name = "pbEmailSendingLoading";
            this.pbEmailSendingLoading.Size = new System.Drawing.Size(50, 50);
            this.pbEmailSendingLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmailSendingLoading.TabIndex = 8;
            this.pbEmailSendingLoading.TabStop = false;
            this.pbEmailSendingLoading.Visible = false;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Enabled = false;
            this.btnSendEmail.Location = new System.Drawing.Point(1250, 34);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(145, 40);
            this.btnSendEmail.TabIndex = 8;
            this.btnSendEmail.Text = "Отправить";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.BtnSendEmail_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(713, 35);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(500, 29);
            this.tbxEmail.TabIndex = 1;
            this.tbxEmail.TextChanged += new System.EventHandler(this.TbxEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FontAwesome", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нравится статья? Отправь себе на e-mail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfokioskArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 737);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelToolbar);
            this.Name = "InfokioskArticleForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 50, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статья";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfokioskArticleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.flowLayoutTitlePanel.ResumeLayout(false);
            this.flowLayoutTitlePanel.PerformLayout();
            this.panelToolbar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailSendingLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTitlePanel;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.PictureBox pbEmailSendingLoading;
        private System.Windows.Forms.Label lblEmailMessage;
    }
}