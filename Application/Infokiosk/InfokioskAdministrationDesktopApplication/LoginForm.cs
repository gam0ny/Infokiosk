using DatabaseLayer;
using System;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class LoginForm : Form
    {
        public UserRepository UserRepository { get; set; }
        public MainForm MainForm { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            UserRepository = new UserRepository();
            MainForm = new MainForm();
        }

        private void BtnAuthenticate_Click(object sender, EventArgs e)
        {
            var userName = this.tbxUsername.Value;
            var password = this.tbxPassword.Value;
            var result = UserRepository.Authenticate(userName, password);

            if(result)
            {
                this.Hide();
                this.lblErrorMessage.Hide();
                this.MainForm.Show();
            }
            else
            {
                this.lblErrorMessage.Show();
                this.lblErrorMessage.Text = Constants.AuthenticationFailedMessage;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.lblErrorMessage.Hide();
        }

        private void TbxUsername_CustomTextChanged(object sender, EventArgs e)
        {
            this.lblErrorMessage.Hide();
        }

    }
}
