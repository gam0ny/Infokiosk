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

        public ImageBox()
        {
            InitializeComponent();
        }

        private void ImageBox_Load(object sender, EventArgs e)
        {
            if (HasVideo) lblHasVideo.Show();
            if (HasDocuments) lblHasDocuments.Show();
            if (Image != null) pbCover.Image = Image;
        }
    }
}
