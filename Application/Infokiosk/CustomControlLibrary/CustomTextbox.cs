using System;
using System.Windows.Forms;

namespace CustomControlLibrary
{
    public partial class CustomTextbox : UserControl
    {
        public string Placeholder { get; set; }

        public string FontAwesomeIcon { get; set; }

        public bool IsPasswordField { get; set; }

        public string Value
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        public event EventHandler CustomTextChanged;


        public CustomTextbox()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                this.lblPlaceholder.Show();
            }
            else
            {
                this.lblPlaceholder.Hide();
                this.lblPlaceholder.Cursor = Cursors.Default;
            }

            if (this.CustomTextChanged != null) this.CustomTextChanged(sender, e);
        }

        private void LoginTextbox_Load(object sender, EventArgs e)
        {
            this.lblPlaceholder.Text = Placeholder;
            this.lblIcon.Text = FontAwesomeIcon;
            this.textBox1.PasswordChar = this.IsPasswordField ? '*' : '\0';

            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                this.lblPlaceholder.Show();
            }
            else
            {
                this.lblPlaceholder.Hide();
                this.lblPlaceholder.Cursor = Cursors.Default;
            }
        }
    }
}
