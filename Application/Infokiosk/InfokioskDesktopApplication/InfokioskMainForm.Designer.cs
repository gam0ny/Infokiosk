namespace InfokioskDesktopApplication
{
    partial class InfokioskMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfokioskMainForm));
            this.lblExit = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.ForeColor = System.Drawing.Color.Yellow;
            this.lblExit.Location = new System.Drawing.Point(1103, 0);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.lblExit.Size = new System.Drawing.Size(73, 737);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(0, 0);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(1103, 737);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoading.TabIndex = 1;
            this.pbLoading.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lblSearch.Location = new System.Drawing.Point(1053, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblSearch.Size = new System.Drawing.Size(50, 737);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "";
            this.lblSearch.Click += new System.EventHandler(this.LblSearch_Click);
            // 
            // InfokioskMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1176, 737);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.lblExit);
            this.Font = new System.Drawing.Font("FontAwesome", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfokioskMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Инфокиоск";
            this.Load += new System.EventHandler(this.InfokioskMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lblSearch;
    }
}

