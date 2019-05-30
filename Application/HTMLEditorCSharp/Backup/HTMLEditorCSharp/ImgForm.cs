using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HTMLEditorCSharp
{
    public partial class ImgForm : Form
    {
        private String src;
        public String Src
        {
            get { return src; }
            set { src = value; }
        }
        private String alt;
        public String Alt
        {
            get { return alt; }
            set { alt = value; }
        }
        private String lowsrc;
        public String Lowsrc
        {
            get { return lowsrc; }
            set { lowsrc = value; }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        private int check;
        public int Check
        {
            get { return check;}
            set { check = value; }
        }
        private String align1;
        public String Align1
        {
            get { return align1; }
            set { align1 = value; }
        }
        private String align2;
        public String Align2
        {
            get { return align2; }
            set { align2 = value; }
        }
        public ImgForm()
        {
            InitializeComponent();
            Src = "";
            Alt = "";
            Lowsrc = "";
            Height = 10;
            heightTextBox.Text = Height.ToString();
            Width = 10;
            widthTextBox.Text = Width.ToString();
            Check = 0;
            pixelRadioButton.Select();
            listBox1.SelectedIndex = 0;
            Align1 = "none";
            listBox2.SelectedIndex = 0;
            Align2 = "none";
        }

        private void scrButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "picture files (*.jpg,*.bmp)|*.jpg;*.bmp";
            ofd.ShowDialog();
            scrTextBox.Text =ofd.FileName;
            Src = scrTextBox.Text;
        }

        private void lowsrcButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "picture files (*.jpg,*.bmp)|*.jpg;*.bmp";
            ofd.ShowDialog();
            lowsrcTextBox.Text = ofd.FileName;
            Lowsrc = lowsrcTextBox.Text;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                Width=int.Parse(widthTextBox.Text);
                Height=int.Parse(heightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Width and Height aren't number");
            }

            if (percentRadioButton.Checked) Check = 1;
            Alt = altTextBox.Text;
            Align1 = listBox1.SelectedItem.ToString();
            Align2 = listBox2.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void lowsrcTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void scrTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}