﻿namespace InfokioskAdministrationDesktopApplication
{
    partial class ManageArticlesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageArticlesForm));
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.gvArticles = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.panelToolbar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticles)).BeginInit();
            this.panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.lblBack);
            this.panelToolbar.Controls.Add(this.lblExit);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelToolbar.Location = new System.Drawing.Point(1000, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(200, 800);
            this.panelToolbar.TabIndex = 15;
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBack.Font = new System.Drawing.Font("FontAwesome", 14.98266F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Yellow;
            this.lblBack.Location = new System.Drawing.Point(60, 0);
            this.lblBack.Margin = new System.Windows.Forms.Padding(0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.lblBack.Size = new System.Drawing.Size(80, 800);
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
            this.lblExit.ForeColor = System.Drawing.Color.Yellow;
            this.lblExit.Location = new System.Drawing.Point(140, 0);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.lblExit.Size = new System.Drawing.Size(60, 800);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // panelMainContent
            // 
            this.panelMainContent.Controls.Add(this.panelContent);
            this.panelMainContent.Controls.Add(this.panelActions);
            this.panelMainContent.Controls.Add(this.pbLoading);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1000, 800);
            this.panelMainContent.TabIndex = 16;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.gvArticles);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 135);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1000, 665);
            this.panelContent.TabIndex = 6;
            // 
            // gvArticles
            // 
            this.gvArticles.AllowUserToAddRows = false;
            this.gvArticles.AllowUserToDeleteRows = false;
            this.gvArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvArticles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.gvArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvArticles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvArticles.Location = new System.Drawing.Point(0, 0);
            this.gvArticles.MultiSelect = false;
            this.gvArticles.Name = "gvArticles";
            this.gvArticles.RowHeadersWidth = 40;
            this.gvArticles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvArticles.RowTemplate.Height = 100;
            this.gvArticles.Size = new System.Drawing.Size(1000, 665);
            this.gvArticles.TabIndex = 0;
            this.gvArticles.DataSourceChanged += new System.EventHandler(this.GvArticles_DataSourceChanged);
            this.gvArticles.Paint += new System.Windows.Forms.PaintEventHandler(this.GvArticles_Paint);
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnAdd);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1000, 135);
            this.panelActions.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("FontAwesome", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(20, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(400, 80);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = " Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pbLoading
            // 
            this.pbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(0, 0);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(1000, 800);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoading.TabIndex = 4;
            this.pbLoading.TabStop = false;
            this.pbLoading.Click += new System.EventHandler(this.PbLoading_Click);
            // 
            // ManageArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageArticlesForm";
            this.Text = "ManageArticlesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageArticlesForm_Load);
            this.panelToolbar.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvArticles)).EndInit();
            this.panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.DataGridView gvArticles;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelContent;
    }
}