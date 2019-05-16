﻿using CustomControlLibrary;
using CustomControlLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskMainForm : Form
    {
        public List<ImageBoxItem> NewArticles { get; set; }
        public List<ArticleByCategory> ArticleByCategoriesCollection { get; set; }

        #region Dynamic controls
        private InfokioskArticleForm infokioskArticleForm { get; set; }

        private ImageBoxListView newArticlesImageBoxView;

        private FlowLayoutPanel flowLayoutPanel;
        #endregion

        public InfokioskMainForm()
        {
            InitializeComponent();

            InitializeDynamicComponents();
        }

        private void InitializeDynamicComponents()
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];

            this.NewArticles = new List<ImageBoxItem> {
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

            this.ArticleByCategoriesCollection = new List<ArticleByCategory> {
                new ArticleByCategory {
                    Category = "IXX Век",
                    Articles = new List<ImageBoxItem> {
                    new ImageBoxItem { Id="1", Category="IXX Век", Title = "Тема 1", ImageUrl=string.Format("{0}1.jpg", contentPath), HasDocuments = true, HasVideo = false },
                    new ImageBoxItem { Id="6", Category="IXX Век", Title = "Тема 1", ImageUrl=string.Format("{0}2.jpg", contentPath), HasDocuments = true, HasVideo = false },
                    },
                },
                new ArticleByCategory {
                    Category = "Искусство",
                    Articles = new List<ImageBoxItem> {
                    new ImageBoxItem { Id="1", Category="Искусство", Title = "Тема 1", ImageUrl=string.Format("{0}1.jpg", contentPath), HasDocuments = true, HasVideo = false },
                    new ImageBoxItem { Id="6", Category="Искусство", Title = "Тема 1", ImageUrl=string.Format("{0}2.jpg", contentPath), HasDocuments = true, HasVideo = false },
                    },
                },
                new ArticleByCategory {
                    Category = "Золотой Век",
                    Articles = new List<ImageBoxItem> {
                    new ImageBoxItem { Id="1", Category="Золотой Век", Title = "Тема 1", ImageUrl=string.Format("{0}1.jpg", contentPath), HasDocuments = true, HasVideo = false },
                    new ImageBoxItem { Id="6", Category="Золотой Век", Title = "Тема 1", ImageUrl=string.Format("{0}2.jpg", contentPath), HasDocuments = true, HasVideo = false },
                    },
                },
                new ArticleByCategory {
                    Category = "Наука",
                    Articles = new List<ImageBoxItem> {
                    new ImageBoxItem { Id="1", Category="Наука", Title = "Тема 1", ImageUrl=string.Format("{0}1.jpg", contentPath), HasDocuments = true, HasVideo = false },
                    new ImageBoxItem { Id="6", Category="Наука", Title = "Тема 1", ImageUrl=string.Format("{0}2.jpg", contentPath), HasDocuments = true, HasVideo = false },
                    },
                },
            };

            this.newArticlesImageBoxView = new ImageBoxListView
            {
                Title = "Новое",
                CountItemsPerLine = 5,
                ImageBoxItemList = NewArticles
            };

            this.newArticlesImageBoxView.ImageBoxItemClick += HandleImageBoxItemClick;
            this.Controls.Add(newArticlesImageBoxView);

            this.flowLayoutPanel = new FlowLayoutPanel();
            this.flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowOnly;
            this.flowLayoutPanel.WrapContents = false;
            this.flowLayoutPanel.AutoScroll = true;
            this.Controls.Add(flowLayoutPanel);

            foreach (var category in ArticleByCategoriesCollection)
            {
                ImageBoxListView imageBoxListView = new ImageBoxListView();
                imageBoxListView.Title = category.Category;
                imageBoxListView.CountItemsPerLine = 5;
                imageBoxListView.ImageBoxItemList = category.Articles;
                imageBoxListView.ImageBoxItemClick += HandleImageBoxItemClick;
                this.flowLayoutPanel.Controls.Add(imageBoxListView);
            }
        }

        private void HandleImageBoxItemClick(object sender, EventArgs e)
        {
            var args = (CustomClickEventArgs)e;
            var ImageBox = args.ImageBox;
            infokioskArticleForm = new InfokioskArticleForm(this);
            infokioskArticleForm.ArticleId = ImageBox.Id;
            infokioskArticleForm.Title = ImageBox.Title;
            infokioskArticleForm.Category = ImageBox.Category;
            infokioskArticleForm.Show();
            this.Hide();
        }

        private void InfokioskMainForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.flowLayoutPanel.MinimumSize = new Size(this.Width - 80, this.Height - this.newArticlesImageBoxView.Height - 80);
            this.flowLayoutPanel.Location = new Point(-3, this.newArticlesImageBoxView.Height);
            this.flowLayoutPanel.Focus();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
