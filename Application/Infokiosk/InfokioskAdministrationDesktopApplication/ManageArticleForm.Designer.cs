namespace InfokioskAdministrationDesktopApplication
{
    partial class ManageArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageArticleForm));
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelManageContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContentEditing = new System.Windows.Forms.TableLayoutPanel();
            this.tbxHeader = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tbxFooter = new System.Windows.Forms.TextBox();
            this.rtbxContent = new System.Windows.Forms.RichTextBox();
            this.panelManagePreview = new System.Windows.Forms.Panel();
            this.tableLayoutPanelPreviewControls = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.ibArticlePreview = new CustomControlLibrary.ImageBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelUpload = new System.Windows.Forms.TableLayoutPanel();
            this.tbxFileUpload = new System.Windows.Forms.TextBox();
            this.btnFileUpload = new System.Windows.Forms.Button();
            this.cbxIsPublish = new System.Windows.Forms.CheckBox();
            this.panelToolbar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelManageContent.SuspendLayout();
            this.tableLayoutPanelContentEditing.SuspendLayout();
            this.panelManagePreview.SuspendLayout();
            this.tableLayoutPanelPreviewControls.SuspendLayout();
            this.tableLayoutPanelUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.btnCancel);
            this.panelToolbar.Controls.Add(this.btnSave);
            this.panelToolbar.Controls.Add(this.lblBack);
            this.panelToolbar.Controls.Add(this.lblExit);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelToolbar.Location = new System.Drawing.Point(1000, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(200, 439);
            this.panelToolbar.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("FontAwesome", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(0, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 70);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = " Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("FontAwesome", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 70);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = " Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("FontAwesome", 14.98266F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Yellow;
            this.lblBack.Location = new System.Drawing.Point(60, 0);
            this.lblBack.Margin = new System.Windows.Forms.Padding(0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.lblBack.Size = new System.Drawing.Size(80, 665);
            this.lblBack.TabIndex = 7;
            this.lblBack.Text = "";
            this.lblBack.Click += new System.EventHandler(this.LblBack_Click);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("FontAwesome", 14.98266F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Yellow;
            this.lblExit.Location = new System.Drawing.Point(140, 0);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.lblExit.Size = new System.Drawing.Size(60, 665);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelManageContent);
            this.panelMain.Controls.Add(this.panelManagePreview);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1200, 800);
            this.panelMain.TabIndex = 17;
            // 
            // panelManageContent
            // 
            this.panelManageContent.Controls.Add(this.tableLayoutPanelContentEditing);
            this.panelManageContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageContent.Location = new System.Drawing.Point(0, 439);
            this.panelManageContent.Name = "panelManageContent";
            this.panelManageContent.Size = new System.Drawing.Size(1200, 361);
            this.panelManageContent.TabIndex = 1;
            // 
            // tableLayoutPanelContentEditing
            // 
            this.tableLayoutPanelContentEditing.ColumnCount = 6;
            this.tableLayoutPanelContentEditing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelContentEditing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelContentEditing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelContentEditing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelContentEditing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelContentEditing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelContentEditing.Controls.Add(this.tbxHeader, 2, 0);
            this.tableLayoutPanelContentEditing.Controls.Add(this.webBrowser1, 4, 0);
            this.tableLayoutPanelContentEditing.Controls.Add(this.tbxFooter, 2, 2);
            this.tableLayoutPanelContentEditing.Controls.Add(this.rtbxContent, 2, 1);
            this.tableLayoutPanelContentEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContentEditing.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContentEditing.Name = "tableLayoutPanelContentEditing";
            this.tableLayoutPanelContentEditing.RowCount = 3;
            this.tableLayoutPanelContentEditing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanelContentEditing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContentEditing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelContentEditing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContentEditing.Size = new System.Drawing.Size(1200, 361);
            this.tableLayoutPanelContentEditing.TabIndex = 3;
            // 
            // tbxHeader
            // 
            this.tbxHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxHeader.Enabled = false;
            this.tbxHeader.Font = new System.Drawing.Font("Arial Unicode MS", 7.907515F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHeader.Location = new System.Drawing.Point(113, 3);
            this.tbxHeader.Multiline = true;
            this.tbxHeader.Name = "tbxHeader";
            this.tbxHeader.Size = new System.Drawing.Size(406, 344);
            this.tbxHeader.TabIndex = 0;
            this.tbxHeader.Text = resources.GetString("tbxHeader.Text");
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(555, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.tableLayoutPanelContentEditing.SetRowSpan(this.webBrowser1, 3);
            this.webBrowser1.Size = new System.Drawing.Size(612, 355);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            // 
            // tbxFooter
            // 
            this.tbxFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFooter.Enabled = false;
            this.tbxFooter.Font = new System.Drawing.Font("Arial Unicode MS", 7.907515F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFooter.Location = new System.Drawing.Point(113, 264);
            this.tbxFooter.Multiline = true;
            this.tbxFooter.Name = "tbxFooter";
            this.tbxFooter.Size = new System.Drawing.Size(406, 94);
            this.tbxFooter.TabIndex = 1;
            this.tbxFooter.Text = "</body>\r\n</html>";
            // 
            // rtbxContent
            // 
            this.rtbxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbxContent.Location = new System.Drawing.Point(113, 353);
            this.rtbxContent.Name = "rtbxContent";
            this.rtbxContent.Size = new System.Drawing.Size(406, 1);
            this.rtbxContent.TabIndex = 3;
            this.rtbxContent.Text = "";
            this.rtbxContent.TextChanged += new System.EventHandler(this.RtbxContent_TextChanged);
            // 
            // panelManagePreview
            // 
            this.panelManagePreview.Controls.Add(this.panelToolbar);
            this.panelManagePreview.Controls.Add(this.tableLayoutPanelPreviewControls);
            this.panelManagePreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManagePreview.Location = new System.Drawing.Point(0, 0);
            this.panelManagePreview.Name = "panelManagePreview";
            this.panelManagePreview.Size = new System.Drawing.Size(1200, 439);
            this.panelManagePreview.TabIndex = 0;
            // 
            // tableLayoutPanelPreviewControls
            // 
            this.tableLayoutPanelPreviewControls.ColumnCount = 5;
            this.tableLayoutPanelPreviewControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPreviewControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanelPreviewControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanelPreviewControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelPreviewControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPreviewControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPreviewControls.Controls.Add(this.label4, 1, 7);
            this.tableLayoutPanelPreviewControls.Controls.Add(this.ibArticlePreview, 4, 1);
            this.tableLayoutPanelPreviewControls.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanelPreviewControls.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanelPreviewControls.Controls.Add(this.tbxTitle, 2, 1);
            this.tableLayoutPanelPreviewControls.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanelPreviewControls.Controls.Add(this.cbCategories, 2, 3);
            this.tableLayoutPanelPreviewControls.Controls.Add(this.tableLayoutPanelUpload, 2, 5);
            this.tableLayoutPanelPreviewControls.Controls.Add(this.cbxIsPublish, 2, 7);
            this.tableLayoutPanelPreviewControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPreviewControls.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPreviewControls.Name = "tableLayoutPanelPreviewControls";
            this.tableLayoutPanelPreviewControls.RowCount = 9;
            this.tableLayoutPanelPreviewControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPreviewControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelPreviewControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPreviewControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelPreviewControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPreviewControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelPreviewControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPreviewControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelPreviewControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelPreviewControls.Size = new System.Drawing.Size(1200, 439);
            this.tableLayoutPanelPreviewControls.TabIndex = 0;
            this.tableLayoutPanelPreviewControls.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanelPreviewControls_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("FontAwesome", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 70);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сразу публикуем?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ibArticlePreview
            // 
            this.ibArticlePreview.Category = null;
            this.ibArticlePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibArticlePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ibArticlePreview.HasDocuments = false;
            this.ibArticlePreview.HasVideo = false;
            this.ibArticlePreview.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ibArticlePreview.Image = null;
            this.ibArticlePreview.Location = new System.Drawing.Point(1370, 30);
            this.ibArticlePreview.Margin = new System.Windows.Forms.Padding(0);
            this.ibArticlePreview.Name = "ibArticlePreview";
            this.tableLayoutPanelPreviewControls.SetRowSpan(this.ibArticlePreview, 6);
            this.ibArticlePreview.Size = new System.Drawing.Size(400, 290);
            this.ibArticlePreview.TabIndex = 0;
            this.ibArticlePreview.Title = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("FontAwesome", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 70);
            this.label3.TabIndex = 2;
            this.label3.Text = "Картинка";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("FontAwesome", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxTitle.Location = new System.Drawing.Point(373, 33);
            this.tbxTitle.Multiline = true;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(794, 64);
            this.tbxTitle.TabIndex = 1;
            this.tbxTitle.TextChanged += new System.EventHandler(this.TbxTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("FontAwesome", 15.81503F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCategories
            // 
            this.cbCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(373, 133);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(794, 47);
            this.cbCategories.TabIndex = 2;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.CbCategories_SelectedIndexChanged);
            // 
            // tableLayoutPanelUpload
            // 
            this.tableLayoutPanelUpload.ColumnCount = 2;
            this.tableLayoutPanelUpload.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelUpload.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelUpload.Controls.Add(this.tbxFileUpload, 0, 0);
            this.tableLayoutPanelUpload.Controls.Add(this.btnFileUpload, 1, 0);
            this.tableLayoutPanelUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUpload.Location = new System.Drawing.Point(373, 233);
            this.tableLayoutPanelUpload.Name = "tableLayoutPanelUpload";
            this.tableLayoutPanelUpload.RowCount = 1;
            this.tableLayoutPanelUpload.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUpload.Size = new System.Drawing.Size(794, 64);
            this.tableLayoutPanelUpload.TabIndex = 0;
            // 
            // tbxFileUpload
            // 
            this.tbxFileUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFileUpload.Enabled = false;
            this.tbxFileUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFileUpload.Location = new System.Drawing.Point(3, 3);
            this.tbxFileUpload.Multiline = true;
            this.tbxFileUpload.Name = "tbxFileUpload";
            this.tbxFileUpload.Size = new System.Drawing.Size(629, 58);
            this.tbxFileUpload.TabIndex = 0;
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFileUpload.Font = new System.Drawing.Font("FontAwesome", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileUpload.Location = new System.Drawing.Point(638, 3);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Size = new System.Drawing.Size(153, 58);
            this.btnFileUpload.TabIndex = 1;
            this.btnFileUpload.Text = "Обзор";
            this.btnFileUpload.UseVisualStyleBackColor = true;
            this.btnFileUpload.Click += new System.EventHandler(this.BtnFileUpload_Click);
            // 
            // cbxIsPublish
            // 
            this.cbxIsPublish.AutoSize = true;
            this.cbxIsPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxIsPublish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxIsPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.15029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxIsPublish.Location = new System.Drawing.Point(373, 323);
            this.cbxIsPublish.Name = "cbxIsPublish";
            this.cbxIsPublish.Size = new System.Drawing.Size(794, 64);
            this.cbxIsPublish.TabIndex = 4;
            this.cbxIsPublish.UseVisualStyleBackColor = true;
            this.cbxIsPublish.CheckedChanged += new System.EventHandler(this.CbxIsPublish_CheckedChanged);
            // 
            // ManageArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageArticleForm";
            this.Text = "ManageArticle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageArticleForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ManageArticleForm_Paint);
            this.panelToolbar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelManageContent.ResumeLayout(false);
            this.tableLayoutPanelContentEditing.ResumeLayout(false);
            this.tableLayoutPanelContentEditing.PerformLayout();
            this.panelManagePreview.ResumeLayout(false);
            this.tableLayoutPanelPreviewControls.ResumeLayout(false);
            this.tableLayoutPanelPreviewControls.PerformLayout();
            this.tableLayoutPanelUpload.ResumeLayout(false);
            this.tableLayoutPanelUpload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelManageContent;
        private System.Windows.Forms.Panel panelManagePreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPreviewControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpload;
        private System.Windows.Forms.TextBox tbxFileUpload;
        private System.Windows.Forms.Button btnFileUpload;
        private CustomControlLibrary.ImageBox ibArticlePreview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxIsPublish;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tbxFooter;
        private System.Windows.Forms.TextBox tbxHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContentEditing;
        private System.Windows.Forms.RichTextBox rtbxContent;
    }
}