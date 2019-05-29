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

        public Guid Id { get; set; }
        public bool HasVideo { get; set; }

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
            this.lblTitle.Parent = this.pbCover;
            foreach (Control control in this.Controls)
            {
                control.Click += ImageBox_Click;
            }
            foreach(Control control in this.pbCover.Controls)
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
                case "Title": lblTitle.Text = this.Title; break;
                case "Image": pbCover.Image = this.Image; break;
                case "Category": lblCategory.Text = this.Category != null ? this.Category.ToUpper() : lblCategory.Text; break;
            }
        }

        private void ImageBox_Load(object sender, EventArgs e)
        {
            if (HasVideo) lblHasVideo.Show();
            if (HasDocuments) lblHasDocuments.Show();
            if (Image != null) pbCover.Image = Image;
            this.lblTitle.Text = this.Title;
            if (!string.IsNullOrWhiteSpace(this.Category)) this.lblCategory.Text = this.Category;
        }

        private void ImageBox_Click(object sender, EventArgs e)
        {
            if (CustomClick != null) CustomClick(sender, new CustomClickEventArgs(this));
        }
    }
}
