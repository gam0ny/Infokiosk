using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class ManageDivTagForm : Form, INotifyPropertyChanged
    {
        private string tagName;

        private string tagText;

        private string resultHtml;

        private string tagStyle;

        private string tagClass;

        [NotifyParentProperty(true)]
        public string ResultHtml { get { return resultHtml; } set { resultHtml = value; OnPropertyChanged("ResultHtml"); } }

        [NotifyParentProperty(true)]
        public string TagName { get { return tagName; } set { tagName = value; OnPropertyChanged("TagName"); } }

        [NotifyParentProperty(true)]
        public string TagText { get { return tagText; } set { tagText = value; OnPropertyChanged("TagText"); } }

        [NotifyParentProperty(true)]
        public string TagStyle { get { return tagStyle; } set { tagStyle = value; OnPropertyChanged("TagStyle"); } }

        [NotifyParentProperty(true)]
        public string TagClass { get { return tagClass; } set { tagClass = value; OnPropertyChanged("TagClass"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public ManageDivTagForm()
        {
            InitializeComponent();

            PropertyChanged += PropertyChanged_EventHandler;
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
                case "TagText":
                    {
                        if (TagText != tbxText.Text) tbxText.Text = TagText;
                        ChangeResultHtml();
                        break;
                    }
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
                case "ResultHtml":
                    lblPreview.Text = ResultHtml; break;
            }
        }

        private void ChangeResultHtml()
        {
            if (string.IsNullOrWhiteSpace(TagStyle) && string.IsNullOrWhiteSpace(TagClass))
            {
                ResultHtml = string.Format("<{0}>{1}</{2}>", TagName, TagText, TagName);
            }
            else if(!string.IsNullOrWhiteSpace(TagStyle) && string.IsNullOrWhiteSpace(TagClass))
            {
                ResultHtml = string.Format("<{0} style=\"{1}\">{2}</{3}>", TagName, TagStyle, TagText, TagName);
            }
            else if (string.IsNullOrWhiteSpace(TagStyle) && !string.IsNullOrWhiteSpace(TagClass))
            {
                ResultHtml = string.Format("<{0} class=\"{1}\">{2}</{3}>", TagName, TagClass, TagText, TagName);
            }
            else if (!string.IsNullOrWhiteSpace(TagStyle) && !string.IsNullOrWhiteSpace(TagClass))
            {
                ResultHtml = string.Format("<{0} style=\"{1}\" class=\"{2}\">{3}</{4}>", TagName, TagStyle, TagClass, TagText, TagName);
            }
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

        private void TbxText_TextChanged(object sender, EventArgs e)
        {
            var changedText = ((TextBox)sender).Text;
            if(TagText != changedText)
            {
                TagText = changedText;
            }
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
    }
}
