using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class ManageVideoTagForm : Form, INotifyPropertyChanged
    {
        private string resultHtml;

        private string tagName;

        private string tagStyle;

        private string tagClass;

        private string tagSrc;

        private bool tagControls;

        private string tagType;

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
        public bool TagControls { get { return tagControls; } set { tagControls = value; OnPropertyChanged("TagControls"); } }

        [NotifyParentProperty(true)]
        public string TagType { get { return tagType; } set { tagType = value; OnPropertyChanged("TagType"); } }

        [NotifyParentProperty(true)]
        public string TagWidth { get { return tagWidth; } set { tagWidth = value; OnPropertyChanged("TagWidth"); } }

        [NotifyParentProperty(true)]
        public string TagHeight { get { return tagHeight; } set { tagHeight = value; OnPropertyChanged("TagHeight"); } }
        public event PropertyChangedEventHandler PropertyChanged;
        public ManageVideoTagForm()
        {
            InitializeComponent();

            PropertyChanged += PropertyChanged_EventHandler;
            cbxControls.AutoSize = false;
            cbxControls.Height = 70;
            cbxControls.Checked = true;
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
                case "TagControls":
                    {
                        if (TagControls != cbxControls.Checked) cbxControls.Checked = TagControls;
                        ChangeResultHtml();
                        break;
                    }
                case "TagType":
                    {
                        if (TagType != cbxMediaType.SelectedItem.ToString()) cbxMediaType.SelectedItem = TagType;
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
            if (TagControls)
            {
                result.AppendFormat(" controls");
            }
            if (!string.IsNullOrWhiteSpace(TagWidth))
            {
                result.AppendFormat(" width=\"{0}\"", TagWidth);
            }
            if (!string.IsNullOrWhiteSpace(TagHeight))
            {
                result.AppendFormat(" height=\"{0}\"", TagHeight);
            }
            if (!string.IsNullOrWhiteSpace(TagClass))
            {
                result.AppendFormat(" class=\"{0}\"", TagClass);
            }
            if (!string.IsNullOrWhiteSpace(TagStyle))
            {
                result.AppendFormat(" style=\"{0}\"", TagStyle);
            }
            result.Append(">");

            if (!string.IsNullOrWhiteSpace(TagSrc) || !string.IsNullOrWhiteSpace(TagType))
            {
                result.AppendLine();
                result.Append("<source");
                if (!string.IsNullOrWhiteSpace(TagSrc)) result.AppendFormat(" src=\"{0}\"", TagSrc);
                if (!string.IsNullOrWhiteSpace(TagType)) result.AppendFormat(" type=\"{0}\"", TagType);
                result.Append("/>");
                result.AppendLine();
            }

            result.AppendFormat("</{0}>", TagName);

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
            openFileDialog.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3;*.mp4|All Files|*.*";

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

        private void CbxControls_CheckedChanged(object sender, EventArgs e)
        {
            var value = ((CheckBox)sender).Checked;
            if (TagControls != value)
            {
                TagControls = value;
            }
        }

        private void CbxMediaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = ((ComboBox)sender).SelectedItem.ToString();
            if (TagType != value)
            {
                TagType = value;
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
