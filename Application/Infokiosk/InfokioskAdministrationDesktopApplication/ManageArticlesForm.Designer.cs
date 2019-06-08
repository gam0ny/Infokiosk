namespace InfokioskAdministrationDesktopApplication
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.panelToolbar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticles)).BeginInit();
            this.panelActions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.lblBack);
            this.panelToolbar.Controls.Add(this.lblExit);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelToolbar.Location = new System.Drawing.Point(1700, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(200, 1200);
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
            this.lblBack.Size = new System.Drawing.Size(80, 1200);
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
            this.lblExit.Size = new System.Drawing.Size(60, 1200);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "";
            this.lblExit.VisibleChanged += new System.EventHandler(this.LblExit_VisibleChanged);
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
            this.panelMainContent.Size = new System.Drawing.Size(1700, 1200);
            this.panelMainContent.TabIndex = 16;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.gvArticles);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 135);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1700, 1065);
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
            this.gvArticles.Size = new System.Drawing.Size(1700, 1065);
            this.gvArticles.TabIndex = 0;
            this.gvArticles.DataSourceChanged += new System.EventHandler(this.GvArticles_DataSourceChanged);
            this.gvArticles.SelectionChanged += new System.EventHandler(this.GvArticles_SelectionChanged);
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.tableLayoutPanel1);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1700, 135);
            this.panelActions.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 654F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1954, 93);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("FontAwesome", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(902, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(396, 94);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = " Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("FontAwesome", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(452, 3);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(396, 94);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = " Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("FontAwesome", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(2, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(396, 94);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = " Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(0, 0);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(1700, 1200);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoading.TabIndex = 4;
            this.pbLoading.TabStop = false;
            // 
            // ManageArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1900, 1200);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageArticlesForm";
            this.Text = "ManageArticlesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelToolbar.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvArticles)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}