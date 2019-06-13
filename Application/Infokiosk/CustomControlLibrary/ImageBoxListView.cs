using CustomControlLibrary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CustomControlLibrary
{
    public partial class ImageBoxListView : UserControl, INotifyPropertyChanged
    {
        private List<ImageBoxItem> imageBoxItemList;

        private string title;

        private Color titleForeColor;

        [NotifyParentProperty(true)]
        public string Title { get { return title; } set { title = value; OnPropertyChanged("Title"); } }

        [NotifyParentProperty(true)]
        public List<ImageBoxItem> ImageBoxItemList
        {
            get { return imageBoxItemList; }
            set { imageBoxItemList = value; OnPropertyChanged("ImageBoxItemList"); }
        }

        public Image NoFileImage { get; set; }

        [NotifyParentProperty(true)]
        public Color TitleForeColor {
            get { return titleForeColor; }
            set { titleForeColor = value; OnPropertyChanged("TitleForeColor"); }
        }

        public event EventHandler ImageBoxItemClick;

        public event PropertyChangedEventHandler PropertyChanged;

        public ImageBoxListView()
        {
            InitializeComponent();

            this.PropertyChanged += ImageBoxListView_PropertyChanged;
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ImageBoxListView_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "ImageBoxItemList": DrawImageBoxItemCollection(); break;
                case "Title": DrawTitle(); break;
                case "TitleForeColor": lblTitle.ForeColor = TitleForeColor; break;
            }
        }

        private void DrawTitle()
        {
            if (!string.IsNullOrWhiteSpace(this.Title)) this.lblTitle.Text = this.Title.ToUpper();

            if (!string.IsNullOrWhiteSpace(Title)) lblTitle.Show();
            else lblTitle.Hide();
        }

        private void DrawImageBoxItemCollection()
        {
            this.flowLayoutContentPanel.Controls.Clear();
            var count = ImageBoxItemList == null ? 0 : ImageBoxItemList.Count;
            for (int i = 0; i < count; i++)
            {
                var imageBoxItem = ImageBoxItemList[i];
                var imageBox = new ImageBox();
                imageBox.Id = imageBoxItem.Id;
                imageBox.Category = imageBoxItem.Category.ToUpper();
                imageBox.Title = imageBoxItem.Title;
                imageBox.HasVideo = imageBoxItem.HasVideo;
                imageBox.HasDocuments = imageBoxItem.HasDocuments;

                Image image = null;

                if (File.Exists(imageBoxItem.ImageUrl))
                {
                    image = Image.FromFile(imageBoxItem.ImageUrl);
                }
                else
                {
                    image = NoFileImage;

                }

                imageBox.Image = image;
                imageBox.Cursor = Cursors.Hand;

                imageBox.CustomClick += ImageBox_Click;

                this.flowLayoutContentPanel.Controls.Add(imageBox);
            }

        }

        private void ImageBox_Click(object sender, System.EventArgs e)
        {
            if (ImageBoxItemClick != null) ImageBoxItemClick(sender, e);
        }

        private void FlowLayoutContentPanel_Paint(object sender, PaintEventArgs e)
        {
            this.flowLayoutContentPanel.MaximumSize = this.MaximumSize;
        }
    }
}
