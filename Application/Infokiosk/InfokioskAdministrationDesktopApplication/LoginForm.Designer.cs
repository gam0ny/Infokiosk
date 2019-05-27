namespace InfokioskAdministrationDesktopApplication
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.tbxPassword = new CustomControlLibrary.CustomTextbox();
            this.tbxUsername = new CustomControlLibrary.CustomTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(111, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход (только для администраторов)";
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthenticate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthenticate.ForeColor = System.Drawing.Color.Yellow;
            this.btnAuthenticate.Location = new System.Drawing.Point(118, 325);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(150, 60);
            this.btnAuthenticate.TabIndex = 4;
            this.btnAuthenticate.Text = "Войти";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.BtnAuthenticate_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("FontAwesome", 10.90751F);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(118, 292);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 27);
            this.lblErrorMessage.TabIndex = 5;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxPassword.FontAwesomeIcon = "";
            this.tbxPassword.IsPasswordField = true;
            this.tbxPassword.Location = new System.Drawing.Point(118, 232);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Placeholder = "Placeholder";
            this.tbxPassword.Size = new System.Drawing.Size(320, 60);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.Value = "";
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxUsername.FontAwesomeIcon = "";
            this.tbxUsername.IsPasswordField = false;
            this.tbxUsername.Location = new System.Drawing.Point(118, 173);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Placeholder = "Username";
            this.tbxUsername.Size = new System.Drawing.Size(320, 60);
            this.tbxUsername.TabIndex = 2;
            this.tbxUsername.Value = "";
            this.tbxUsername.CustomTextChanged += new System.EventHandler(this.TbxUsername_CustomTextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(576, 637);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnAuthenticate);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("FontAwesome", 15.90751F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControlLibrary.CustomTextbox tbxUsername;
        private CustomControlLibrary.CustomTextbox tbxPassword;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

