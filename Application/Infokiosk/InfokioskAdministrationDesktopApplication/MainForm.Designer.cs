namespace InfokioskAdministrationDesktopApplication
{
    partial class MainForm
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
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnManageContentCategories = new System.Windows.Forms.Button();
            this.btnManageArticles = new System.Windows.Forms.Button();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.ColumnCount = 3;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenu.Controls.Add(this.btnManageContentCategories, 1, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.btnManageArticles, 1, 1);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 2;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(1000, 800);
            this.tableLayoutPanelMenu.TabIndex = 0;
            // 
            // btnManageContentCategories
            // 
            this.btnManageContentCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageContentCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageContentCategories.Font = new System.Drawing.Font("FontAwesome", 17.89595F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageContentCategories.Location = new System.Drawing.Point(203, 3);
            this.btnManageContentCategories.Name = "btnManageContentCategories";
            this.btnManageContentCategories.Size = new System.Drawing.Size(594, 394);
            this.btnManageContentCategories.TabIndex = 0;
            this.btnManageContentCategories.Text = " Управление категориями";
            this.btnManageContentCategories.UseVisualStyleBackColor = true;
            this.btnManageContentCategories.Click += new System.EventHandler(this.BtnManageContentCategories_Click);
            // 
            // btnManageArticles
            // 
            this.btnManageArticles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageArticles.Font = new System.Drawing.Font("FontAwesome", 17.89595F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageArticles.Location = new System.Drawing.Point(203, 403);
            this.btnManageArticles.Name = "btnManageArticles";
            this.btnManageArticles.Size = new System.Drawing.Size(594, 394);
            this.btnManageArticles.TabIndex = 1;
            this.btnManageArticles.Text = " Управление статьями";
            this.btnManageArticles.UseVisualStyleBackColor = true;
            this.btnManageArticles.Click += new System.EventHandler(this.BtnManageArticles_Click);
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.lblExit);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelToolbar.Location = new System.Drawing.Point(800, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(200, 800);
            this.panelToolbar.TabIndex = 15;
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
            this.lblExit.Size = new System.Drawing.Size(60, 800);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.tableLayoutPanelMenu);
            this.Font = new System.Drawing.Font("FontAwesome", 7.907515F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование";
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.panelToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.Button btnManageContentCategories;
        private System.Windows.Forms.Button btnManageArticles;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label lblExit;
    }
}