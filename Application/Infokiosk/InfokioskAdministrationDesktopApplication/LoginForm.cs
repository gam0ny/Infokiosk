using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using System;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class LoginForm : Form
    {
        private IController controller;

        private MainForm mainForm { get; set; }

        public Guid UserId { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            controller = new Controller();
            mainForm = new MainForm();
        }

        private void BtnAuthenticate_Click(object sender, EventArgs e)
        {
            var userName = this.tbxUsername.Value;
            var password = this.tbxPassword.Value;
            Guid? userId;
            bool result = controller.Authenticate(userName, password, out userId);

            if(result)
            {
                this.mainForm.UserId = userId;
                this.Hide();
                this.lblErrorMessage.Hide();
                this.mainForm.Show();
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
