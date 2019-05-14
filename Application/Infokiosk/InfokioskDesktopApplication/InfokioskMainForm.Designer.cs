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
            this.lblExit = new System.Windows.Forms.Label();
            this.iblvRecentlyAdded = new CustomControlLibrary.ImageBoxListView();
            this.iblvPerCategory = new CustomControlLibrary.ImageBoxListView();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.ForeColor = System.Drawing.Color.Yellow;
            this.lblExit.Location = new System.Drawing.Point(1126, 0);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblExit.Size = new System.Drawing.Size(50, 737);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // iblvRecentlyAdded
            // 
            this.iblvRecentlyAdded.AutoSize = true;
            this.iblvRecentlyAdded.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iblvRecentlyAdded.BackColor = System.Drawing.Color.Transparent;
            this.iblvRecentlyAdded.CountItemsPerLine = 0;
            this.iblvRecentlyAdded.CountItemsToDisplay = 0;
            this.iblvRecentlyAdded.ImageBoxItemList = null;
            this.iblvRecentlyAdded.Location = new System.Drawing.Point(-1, 0);
            this.iblvRecentlyAdded.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iblvRecentlyAdded.Name = "iblvRecentlyAdded";
            this.iblvRecentlyAdded.Size = new System.Drawing.Size(187, 78);
            this.iblvRecentlyAdded.TabIndex = 1;
            this.iblvRecentlyAdded.Title = "Новое";
            // 
            // iblvPerCategory
            // 
            this.iblvPerCategory.AutoSize = true;
            this.iblvPerCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iblvPerCategory.BackColor = System.Drawing.Color.Transparent;
            this.iblvPerCategory.CountItemsPerLine = 0;
            this.iblvPerCategory.CountItemsToDisplay = 0;
            this.iblvPerCategory.ImageBoxItemList = null;
            this.iblvPerCategory.Location = new System.Drawing.Point(10, 379);
            this.iblvPerCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iblvPerCategory.Name = "iblvPerCategory";
            this.iblvPerCategory.Size = new System.Drawing.Size(196, 78);
            this.iblvPerCategory.TabIndex = 2;
            this.iblvPerCategory.Title = "IXX ВЕК";
            // 
            // InfokioskMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1176, 737);
            this.Controls.Add(this.iblvPerCategory);
            this.Controls.Add(this.iblvRecentlyAdded);
            this.Controls.Add(this.lblExit);
            this.Font = new System.Drawing.Font("FontAwesome", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfokioskMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Инфокиоск";
            this.Load += new System.EventHandler(this.InfokioskMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private CustomControlLibrary.ImageBoxListView iblvRecentlyAdded;
        private CustomControlLibrary.ImageBoxListView iblvPerCategory;
    }
}

