using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class ManageContentCategoriesForm : Form
    {
        private MainForm mainForm;

        private BackgroundWorker backgroundWorker;

        private IInfokioskAdministrationDesktopApplicationController controller;
        public ManageContentCategoriesForm()
        {
            InitializeComponent();

            controller = new InfokioskAdministrationDesktopApplicationController();

            backgroundWorker = new BackgroundWorker();
            this.backgroundWorker.DoWork += new DoWorkEventHandler(FetchingContentCategoriesInProgress);
            this.backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingContentCategoriesComplete);
        }

        private void FetchingContentCategoriesInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = controller.GetContentCategories();
        }

        private void FetchingContentCategoriesComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            var contentCategories = (List<ContentCategoryViewModel>)e.Result;
            lbxContentCategories.Items.Clear();
            foreach(var contentCategory in contentCategories)
            {
                lbxContentCategories.ValueMember = "Id";
                lbxContentCategories.DisplayMember = "Name";
                lbxContentCategories.Items.Add(contentCategory);
            }
            this.pbLoading.Visible = false;
        }

        public ManageContentCategoriesForm(MainForm mainForm) : this()
        {
            this.mainForm = mainForm;
        }

        private void LblExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void LblBack_Click(object sender, System.EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void TbxEdit_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TbxAdd_TextChanged(object sender, System.EventArgs e)
        {
            var value = ((TextBox)sender).Text;

            btnAdd.Enabled = !string.IsNullOrWhiteSpace(value);
        }

        private void ManageContentCategoriesForm_Load(object sender, System.EventArgs e)
        {
            this.pbLoading.Visible = true;
            backgroundWorker.RunWorkerAsync();
        }
    }
}
