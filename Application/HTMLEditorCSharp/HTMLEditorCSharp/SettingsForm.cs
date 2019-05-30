using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HTMLEditorCSharp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            tagRadioButton.Select();
            tagTextBox.BackColor = Settings.Instance.TagColor;
            parameterTextBox.BackColor = Settings.Instance.ParameterColor;
            textTextBox.BackColor = Settings.Instance.TextColor;
            commentTextBox.BackColor = Settings.Instance.CommentColor;
            specSymbolTextBox.BackColor = Settings.Instance.ChangeColor;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            cDialog.ShowDialog();
            Color color = cDialog.Color;
            if (tagRadioButton.Checked) tagTextBox.BackColor = color;
            if (parameterRadioButton.Checked) parameterTextBox.BackColor = color;
            if (textRadioButton.Checked) textTextBox.BackColor = color;
            if (commentRadioButton.Checked) commentTextBox.BackColor = color;
            if (specSymbolRadioButton.Checked) specSymbolTextBox.BackColor = color;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Settings.Instance.TagColor = tagTextBox.BackColor;
            Settings.Instance.ParameterColor = parameterTextBox.BackColor;
            Settings.Instance.TextColor = textTextBox.BackColor;
            Settings.Instance.CommentColor = commentTextBox.BackColor;
            Settings.Instance.ChangeColor = specSymbolTextBox.BackColor;
            this.Close();
        }

        private void parameterTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}