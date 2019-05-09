using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControlLibrary
{
    public partial class ImageBox : UserControl
    {
        public bool HasVideo { get; set; }

        public bool HasDocuments { get; set; }

        public Image Image { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public ImageBox()
        {
            InitializeComponent();
            this.lblTitle.Parent = this.pbCover;
        }

        private void ImageBox_Load(object sender, EventArgs e)
        {
            if (HasVideo) lblHasVideo.Show();
            if (HasDocuments) lblHasDocuments.Show();
            if (Image != null) pbCover.Image = Image;
            this.lblTitle.Text = this.Title;
            if(!string.IsNullOrWhiteSpace(this.Category)) this.lblCategory.Text = this.Category;
        }
    }
}
