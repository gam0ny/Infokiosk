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
            this.imageBox1 = new CustomControlLibrary.ImageBox();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Font = new System.Drawing.Font("FontAwesome", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox1.Location = new System.Drawing.Point(13, 22);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(320, 150);
            this.imageBox1.TabIndex = 0;
            // 
            // InfokioskMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1176, 737);
            this.Controls.Add(this.imageBox1);
            this.Font = new System.Drawing.Font("FontAwesome", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfokioskMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Инфокиоск";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlLibrary.ImageBox imageBox1;
    }
}

