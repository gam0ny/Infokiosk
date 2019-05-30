using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HTMLEditorCSharp
{
    public partial class PForm : Form
    {
        public PForm()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
        }

        
        public String Align
        {
            get { return listBox1.SelectedItem.ToString(); }
        }

        private void OKBUtton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}