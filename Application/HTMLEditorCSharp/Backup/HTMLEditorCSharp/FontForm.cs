using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HTMLEditorCSharp
{
    public partial class FontForm : Form
    {
        private Color fontColor;
        public Color FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }
        private String fontFont;
        public string FontFont
        {
            get { return fontFont; }
            set { fontFont = value; }
        }
        private int fontSize;
        public int FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }
        private char fontCheck;
        public char FontCheck
        {
            get { return fontCheck; }
            set { fontCheck = value; }
        }
        public FontForm(Color c)
        {
            InitializeComponent();
            FontColor = c;
            eqRadioButton.Select();
            FontFont = "Times New Roman";
            faceTextBox.Text = FontFont;
            FontSize = 8;
            sizeTextBox.Text = FontSize.ToString();
            FontCheck = '=';
        }

        private void FontForm_Load(object sender, EventArgs e)
        {
            colorTextBox.BackColor = FontColor;
        }

        private void faceButton_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog fd = new FontDialog();
                fd.ShowDialog();
                FontFont = fd.Font.Name;
                faceTextBox.Text = FontFont;
                FontSize = (int)fd.Font.Size;
                sizeTextBox.Text = FontSize.ToString();
            }
            catch (ArgumentException i)
            {
                MessageBox.Show("Sorry! This Font is not avablible!");

            }
        }

        private void colorChangeButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            FontColor = cd.Color;
            colorTextBox.BackColor = FontColor;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (eqRadioButton.Checked) FontCheck = '=';
            if (plusRadioButton.Checked) FontCheck = '+';
            if (minusRadioButton.Checked) FontCheck = '-';
            Close();
        }

        private void faceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void plusRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}