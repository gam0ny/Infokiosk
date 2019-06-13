using CustomControlLibrary.Entities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControlLibrary
{
    public partial class ImageBox : UserControl, INotifyPropertyChanged
    {
        private string title;

        private Image image;

        private string category;

        private bool hasVideo;

        public Guid Id { get; set; }

        [NotifyParentProperty(true)]
        public bool HasVideo { get { return hasVideo; } set { hasVideo = value; OnPropertyChanged("HasVideo"); } }

        public bool HasDocuments { get; set; }

        [NotifyParentProperty(true)]
        public Image Image { get { return image; } set { image = value; OnPropertyChanged("Image"); } }

        [NotifyParentProperty(true)]
        public string Title { get { return title; } set { title = value; OnPropertyChanged("Title"); } }

        [NotifyParentProperty(true)]
        public string Category { get { return category; } set { category = value; OnPropertyChanged("Category"); } }

        public event EventHandler<CustomClickEventArgs> CustomClick;

        public event PropertyChangedEventHandler PropertyChanged;

        public ImageBox()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                control.Click += ImageBox_Click;
            }
            foreach (Control control in this.pbCover.Controls)
            {
                control.Click += ImageBox_Click;
            }

            this.PropertyChanged += ImageBox_PropertyChanged;
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ImageBox_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Title": {
                        lblTitle.Text = this.Title;
                        lblShadow.Text = this.Title;

                        var coefficient = lblTitle.Size.Height % lblTitle.MinimumSize.Height;
                        lblTitle.Font = new Font(lblTitle.Font.FontFamily, lblTitle.Font.Size - coefficient, lblTitle.Font.Style);
                        lblShadow.Font = new Font(lblShadow.Font.FontFamily, lblShadow.Font.Size - coefficient, lblShadow.Font.Style);
                    } break;
                case "Image": pbCover.Image = this.Image; break;
                case "Category": lblCategory.Text = this.Category != null ? this.Category.ToUpper() : lblCategory.Text; break;
                case "HasVideo": lblHasVideo.Visible = this.HasVideo; break;
            }
        }

        private void ImageBox_Load(object sender, EventArgs e)
        {
            if (HasVideo) lblHasVideo.Show();
            if (HasDocuments) lblHasDocuments.Show();
            if (Image != null) pbCover.Image = Image;
            this.lblTitle.Text = this.Title;
            if (!string.IsNullOrWhiteSpace(this.Category)) this.lblCategory.Text = this.Category;
            flowLayoutPanelIcons.Parent = pbCover;
            this.lblShadow.Parent = this.pbCover;
            lblTitle.Parent = lblShadow;
        }

        private void ImageBox_Click(object sender, EventArgs e)
        {
            if (CustomClick != null) CustomClick(sender, new CustomClickEventArgs(this));
        }
    }
}
