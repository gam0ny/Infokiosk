using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using System;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class LoginForm : Form
    {
        private IInfokioskAdministrationDesktopApplicationController controller;
        private MainForm mainForm { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            controller = new InfokioskAdministrationDesktopApplicationController();
            mainForm = new MainForm();
        }

        private void BtnAuthenticate_Click(object sender, EventArgs e)
        {
            var userName = this.tbxUsername.Value;
            var password = this.tbxPassword.Value;
            var result = controller.Authenticate(userName, password);

            if(result)
            {
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
