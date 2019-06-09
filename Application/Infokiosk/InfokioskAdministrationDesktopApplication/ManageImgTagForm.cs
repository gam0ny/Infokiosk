using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class ManageImgTagForm : Form, INotifyPropertyChanged
    {
        private string tagName;

        private string resultHtml;

        private string tagStyle;

        private string tagClass;

        private string tagSrc;

        private string tagWidth;

        private string tagHeight;

        [NotifyParentProperty(true)]
        public string ResultHtml { get { return resultHtml; } set { resultHtml = value; OnPropertyChanged("ResultHtml"); } }

        [NotifyParentProperty(true)]
        public string TagName { get { return tagName; } set { tagName = value; OnPropertyChanged("TagName"); } }

        [NotifyParentProperty(true)]
        public string TagStyle { get { return tagStyle; } set { tagStyle = value; OnPropertyChanged("TagStyle"); } }

        [NotifyParentProperty(true)]
        public string TagClass { get { return tagClass; } set { tagClass = value; OnPropertyChanged("TagClass"); } }

        [NotifyParentProperty(true)]
        public string TagSrc { get { return tagSrc; } set { tagSrc = value; OnPropertyChanged("TagSrc"); } }

        [NotifyParentProperty(true)]
        public string TagWidth { get { return tagWidth; } set { tagWidth = value; OnPropertyChanged("TagWidth"); } }

        [NotifyParentProperty(true)]
        public string TagHeight { get { return tagHeight; } set { tagHeight = value; OnPropertyChanged("TagHeight"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public ManageImgTagForm()
        {
            InitializeComponent();

            PropertyChanged += PropertyChanged_EventHandler;
            mtbxWidth.AutoSize = false;
            mtbxWidth.Height = 70;
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void PropertyChanged_EventHandler(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "TagName":
                case "TagStyle":
                    {
                        if (TagStyle != tbxStyle.Text) tbxStyle.Text = TagStyle;
                        ChangeResultHtml();
                        break;
                    }
                case "TagClass":
                    {
                        if (TagClass != tbxClass.Text) tbxClass.Text = TagClass;
                        ChangeResultHtml();
                        break;
                    }
                case "TagSrc":
                    {
                        if (TagSrc != tbxSrc.Text) tbxSrc.Text = TagSrc;
                        ChangeResultHtml();
                        break;
                    }
                case "TagWidth":
                    {
                        if (TagWidth != mtbxWidth.Text) mtbxWidth.Text = TagWidth;
                        ChangeResultHtml();
                        break;
                    }
                case "TagHeight":
                    {
                        if (TagHeight != mtbxHeight.Text) mtbxHeight.Text = TagHeight;
                        ChangeResultHtml();
                        break;
                    }
                case "ResultHtml":
                    lblPreview.Text = ResultHtml; break;
            }
        }

        private void ChangeResultHtml()
        {
            var result = new StringBuilder();

            result.AppendFormat("<{0}", TagName);
            if (!string.IsNullOrWhiteSpace(TagSrc))
            {
                result.AppendFormat(" src=\"{0}\"", TagSrc);
            }
            if (!string.IsNullOrWhiteSpace(TagClass))
            {
                result.AppendFormat(" class=\"{0}\"", TagClass);
            }
            if (!string.IsNullOrWhiteSpace(TagStyle))
            {
                result.AppendFormat(" style=\"{0}\"", TagStyle);
            }
            if (!string.IsNullOrWhiteSpace(TagWidth))
            {
                result.AppendFormat(" width=\"{0}\"", TagWidth);
            }
            if (!string.IsNullOrWhiteSpace(TagHeight))
            {
                result.AppendFormat(" height=\"{0}\"", TagHeight);
            }
            result.Append(">");

            ResultHtml = result.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TbxStyle_TextChanged(object sender, EventArgs e)
        {
            var changedText = ((TextBox)sender).Text;
            if (TagStyle != changedText)
            {
                TagStyle = changedText;
            }
        }

        private void TbxClass_TextChanged(object sender, EventArgs e)
        {
            var changedText = ((TextBox)sender).Text;
            if (TagClass != changedText)
            {
                TagClass = changedText;
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    tbxSrc.Text = fileName;
                }
            }
        }

        private void TbxSrc_TextChanged(object sender, EventArgs e)
        {
            var changedText = ((TextBox)sender).Text;
            if (TagSrc != changedText)
            {
                TagSrc = changedText;
            }
        }

        private void MtbxWidth_TextChanged(object sender, EventArgs e)
        {
            var changedText = ((MaskedTextBox)sender).Text;

            if (TagWidth != changedText)
            {
                TagWidth = changedText;
            }
        }

        private void MtbxHeight_TextChanged(object sender, EventArgs e)
        {
            var changedText = ((MaskedTextBox)sender).Text;

            if (TagHeight != changedText)
            {
                TagHeight = changedText;
            }
        }
    }
}
