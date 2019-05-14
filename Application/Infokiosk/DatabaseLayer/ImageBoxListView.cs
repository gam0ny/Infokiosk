using CustomControlLibrary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControlLibrary
{
    public partial class ImageBoxListView : UserControl
    {
        public string Title { get; set; }

        public int CountItemsPerLine { get; set; }

        public int CountItemsToDisplay { get; set; }

        public List<ImageBoxItem> ImageBoxItemList { get; set; }

        public event EventHandler ImageBoxItemClick;

        public ImageBoxListView()
        {
            InitializeComponent();
        }

        private void ImageBoxListView_Load(object sender, System.EventArgs e)
        {
            int xPoint = 0;
            int yPoint = 0;
            int spaceForTitleYPoint = 45;

            if (string.IsNullOrWhiteSpace(this.Title))
            {
                lblTitle.Hide();
            }
            else
            {
                lblTitle.Show();
                yPoint = spaceForTitleYPoint;
            }

            if (!string.IsNullOrWhiteSpace(this.Title)) this.lblTitle.Text = this.Title.ToUpper();

            if (this.CountItemsPerLine > 0)
            {
                for (int i = 0; i < ImageBoxItemList.Count; i++)
                {
                    var imageBoxItem = ImageBoxItemList[i];
                    var imageBox = new ImageBox();
                    imageBox.Category = imageBoxItem.Category.ToUpper();
                    imageBox.Title = imageBoxItem.Title;
                    imageBox.HasVideo = imageBoxItem.HasVideo;
                    imageBox.HasDocuments = imageBoxItem.HasDocuments;
                    imageBox.Image = Image.FromFile(imageBoxItem.ImageUrl);

                    if (i != 0 && i % this.CountItemsPerLine == 0)
                    {
                        xPoint = 0;
                        yPoint += imageBox.Size.Height;
                    }

                    imageBox.Location = new Point(xPoint, yPoint);
                    xPoint += imageBox.Size.Width;
                    imageBox.Cursor = Cursors.Hand;

                    imageBox.CustomClick += ImageBox_Click;

                    this.Controls.Add(imageBox);
                }
            }


        }

        private void ImageBox_Click(object sender, System.EventArgs e)
        {
            if (ImageBoxItemClick != null) ImageBoxItemClick(sender, e);
        }
    }
}
