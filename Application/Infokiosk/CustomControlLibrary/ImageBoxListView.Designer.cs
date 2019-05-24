namespace CustomControlLibrary
{
    partial class ImageBoxListView
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("FontAwesome", 14.15029F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblTitle.Size = new System.Drawing.Size(164, 75);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Заголовок";
            // 
            // flowLayoutMainPanel
            // 
            this.flowLayoutMainPanel.AutoSize = true;
            this.flowLayoutMainPanel.Controls.Add(this.lblTitle);
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutContentPanel);
            this.flowLayoutMainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutMainPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutMainPanel.Name = "flowLayoutMainPanel";
            this.flowLayoutMainPanel.Size = new System.Drawing.Size(360, 218);
            this.flowLayoutMainPanel.TabIndex = 1;
            // 
            // flowLayoutContentPanel
            // 
            this.flowLayoutContentPanel.AutoSize = true;
            this.flowLayoutContentPanel.Location = new System.Drawing.Point(0, 75);
            this.flowLayoutContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutContentPanel.Name = "flowLayoutContentPanel";
            this.flowLayoutContentPanel.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutContentPanel.TabIndex = 1;
            this.flowLayoutContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutContentPanel_Paint);
            // 
            // ImageBoxListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutMainPanel);
            this.Name = "ImageBoxListView";
            this.Size = new System.Drawing.Size(360, 218);
            this.flowLayoutMainPanel.ResumeLayout(false);
            this.flowLayoutMainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMainPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutContentPanel;
    }
}
