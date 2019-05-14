﻿using CustomControlLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskMainForm : Form
    {
        public InfokioskArticleForm InfokioskArticleForm { get; set; }
        public InfokioskMainForm()
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];

            InitializeComponent();

            this.iblvRecentlyAdded.Title = "Новое";
            this.iblvRecentlyAdded.CountItemsPerLine = 5;
            this.iblvRecentlyAdded.ImageBoxItemList = new List<ImageBoxItem> {
                new ImageBoxItem { Id="1", Category="IXX Век", Title = "Тема 1", ImageUrl=string.Format("{0}1.jpg", contentPath), HasDocuments = true, HasVideo = false },
                new ImageBoxItem { Id="2", Category="Золотой Век", Title = "Тема 2", ImageUrl=string.Format("{0}2.jpg", contentPath), HasDocuments = true, HasVideo = true },
                new ImageBoxItem { Id="3", Category="Искусство", Title = "Тема 3", ImageUrl=string.Format("{0}3.jpg", contentPath), HasDocuments = false, HasVideo = false },
                new ImageBoxItem { Id="4", Category="XVI Век", Title = "Тема 4", ImageUrl=string.Format("{0}4.jpg", contentPath), HasDocuments = false, HasVideo = false },
                new ImageBoxItem { Id="5", Category="Наука", Title = "Тема 5", ImageUrl=string.Format("{0}5.jpg", contentPath), HasDocuments = true, HasVideo = false },
                new ImageBoxItem { Id="6", Category="IXX Век", Title = "Тема 1", ImageUrl=string.Format("{0}1.jpg", contentPath), HasDocuments = true, HasVideo = false },
                new ImageBoxItem { Id="7", Category="Золотой Век", Title = "Тема 2", ImageUrl=string.Format("{0}2.jpg", contentPath), HasDocuments = true, HasVideo = true },
                new ImageBoxItem { Id="8", Category="Искусство", Title = "Тема 3", ImageUrl=string.Format("{0}3.jpg", contentPath), HasDocuments = false, HasVideo = false },
                new ImageBoxItem {  Id="9", Category="XVI Век", Title = "Тема 4", ImageUrl=string.Format("{0}4.jpg", contentPath), HasDocuments = false, HasVideo = false },
                new ImageBoxItem {  Id="10", Category="Наука", Title = "Тема 5", ImageUrl=string.Format("{0}5.jpg", contentPath), HasDocuments = true, HasVideo = false },
            };
            this.iblvRecentlyAdded.ImageBoxItemClick += HandleImageBoxItemClick;

            this.iblvPerCategory.Title = "IXX Век";
            this.iblvPerCategory.CountItemsPerLine = 5;
            this.iblvPerCategory.ImageBoxItemList = new List<ImageBoxItem> {
                new ImageBoxItem { Id="1", Category="IXX Век", Title = "Тема 1", ImageUrl=string.Format("{0}1.jpg", contentPath), HasDocuments = true, HasVideo = false },
                new ImageBoxItem { Id="6", Category="IXX Век", Title = "Тема 1", ImageUrl=string.Format("{0}2.jpg", contentPath), HasDocuments = true, HasVideo = false },
            };
        }

        private void HandleImageBoxItemClick(object sender, EventArgs e)
        {
            var args = (CustomClickEventArgs)e;
            var ImageBox = args.ImageBox;
            InfokioskArticleForm = new InfokioskArticleForm(this);
            InfokioskArticleForm.ArticleId = ImageBox.Id;
            InfokioskArticleForm.Title = ImageBox.Title;
            InfokioskArticleForm.Show();
            this.Hide();
        }

        private void InfokioskMainForm_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.iblvPerCategory.Location = new Point(0, this.iblvRecentlyAdded.Size.Height);
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
