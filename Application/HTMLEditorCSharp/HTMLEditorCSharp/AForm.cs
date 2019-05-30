using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HTMLEditorCSharp
{
    public partial class AForm : Form
    {
        private String path;
        public String Path
        {
            get { return path; }
            set { path = value; }
        }
        public AForm()
        {
            InitializeComponent();
            Path = "";
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            Path=linkTextBox.Text=of.FileName;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void AForm_Load(object sender, EventArgs e)
        {

        }
    }
}