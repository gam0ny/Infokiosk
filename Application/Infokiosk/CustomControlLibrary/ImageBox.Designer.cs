namespace CustomControlLibrary
{
    partial class ImageBox
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageBox));
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblHasVideo = new System.Windows.Forms.Label();
            this.lblHasDocuments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCover
            // 
            this.pbCover.Image = ((System.Drawing.Image)(resources.GetObject("pbCover.Image")));
            this.pbCover.InitialImage = null;
            this.pbCover.Location = new System.Drawing.Point(0, 0);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(320, 150);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Yellow;
            this.lblCategory.Font = new System.Drawing.Font("FontAwesome", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(19, 15);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Padding = new System.Windows.Forms.Padding(10);
            this.lblCategory.Size = new System.Drawing.Size(148, 45);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "КАТЕГОРИЯ";
            // 
            // lblHasVideo
            // 
            this.lblHasVideo.AutoSize = true;
            this.lblHasVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblHasVideo.Font = new System.Drawing.Font("FontAwesome", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.lblHasVideo.Location = new System.Drawing.Point(19, 103);
            this.lblHasVideo.Name = "lblHasVideo";
            this.lblHasVideo.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblHasVideo.Size = new System.Drawing.Size(59, 35);
            this.lblHasVideo.TabIndex = 2;
            this.lblHasVideo.Text = "";
            this.lblHasVideo.Visible = false;
            // 
            // lblHasDocuments
            // 
            this.lblHasDocuments.AutoSize = true;
            this.lblHasDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblHasDocuments.Font = new System.Drawing.Font("FontAwesome", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.lblHasDocuments.Location = new System.Drawing.Point(84, 103);
            this.lblHasDocuments.Name = "lblHasDocuments";
            this.lblHasDocuments.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblHasDocuments.Size = new System.Drawing.Size(52, 35);
            this.lblHasDocuments.TabIndex = 3;
            this.lblHasDocuments.Text = "";
            this.lblHasDocuments.Visible = false;
            // 
            // ImageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHasDocuments);
            this.Controls.Add(this.lblHasVideo);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.pbCover);
            this.Name = "ImageBox";
            this.Size = new System.Drawing.Size(320, 150);
            this.Load += new System.EventHandler(this.ImageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblHasVideo;
        private System.Windows.Forms.Label lblHasDocuments;
    }
}
