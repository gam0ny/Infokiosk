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

        private BackgroundWorker getContentCategoriesBackgroundWorker;
        private BackgroundWorker addContentCategoryBackgroundWorker;
        private BackgroundWorker editContentCategoryBackgroundWorker;
        private BackgroundWorker deleteContentCategoryBackgroundWorker;

        private IController controller;
        public ManageContentCategoriesForm()
        {
            InitializeComponent();

            controller = new Controller();

            this.getContentCategoriesBackgroundWorker = new BackgroundWorker();
            this.getContentCategoriesBackgroundWorker.DoWork += new DoWorkEventHandler(FetchingContentCategoriesInProgress);
            this.getContentCategoriesBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingContentCategoriesComplete);
            this.addContentCategoryBackgroundWorker = new BackgroundWorker();
            this.addContentCategoryBackgroundWorker.DoWork += new DoWorkEventHandler(AddingContentCategoriesInProgress);
            this.addContentCategoryBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(AddingContentCategoriesComplete);
            this.editContentCategoryBackgroundWorker = new BackgroundWorker();
            this.editContentCategoryBackgroundWorker.DoWork += new DoWorkEventHandler(EditContentCategoriesInProgress);
            this.editContentCategoryBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(EditContentCategoriesComplete);
            this.deleteContentCategoryBackgroundWorker = new BackgroundWorker();
            this.deleteContentCategoryBackgroundWorker.DoWork += new DoWorkEventHandler(DeleteContentCategoriesInProgress);
            this.deleteContentCategoryBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DeleteContentCategoriesComplete);
        }

        public ManageContentCategoriesForm(MainForm mainForm) : this()
        {
            this.mainForm = mainForm;
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
            this.tbxEdit.Text = string.Empty;
            this.tbxEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.lbxContentCategories.Focus();
        }

        private void AddingContentCategoriesInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = controller.AddContentCategory((ContentCategoryViewModel)e.Argument);
        }

        private void AddingContentCategoriesComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbLoading.Visible = false;

            bool result = (bool)e.Result;
            if(result)
            {
                this.pbLoading.Visible = true;
                this.getContentCategoriesBackgroundWorker.RunWorkerAsync();
            }
        }

        private void EditContentCategoriesInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = controller.EditContentCategory((ContentCategoryViewModel)e.Argument);
        }

        private void EditContentCategoriesComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbLoading.Visible = false;

            bool result = (bool)e.Result;

            if (result)
            {
                this.pbLoading.Visible = true;
                this.getContentCategoriesBackgroundWorker.RunWorkerAsync();
            }
        }

        private void DeleteContentCategoriesInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = controller.DeleteContentCategory((ContentCategoryViewModel)e.Argument);
        }

        private void DeleteContentCategoriesComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbLoading.Visible = false;

            bool result = (bool)e.Result;

            if (result)
            {
                this.pbLoading.Visible = true;
                this.getContentCategoriesBackgroundWorker.RunWorkerAsync();
            }
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
            var value = ((TextBox)sender).Text;

            btnEdit.Enabled = !string.IsNullOrWhiteSpace(value);
        }

        private void TbxAdd_TextChanged(object sender, System.EventArgs e)
        {
            var value = ((TextBox)sender).Text;

            btnAdd.Enabled = !string.IsNullOrWhiteSpace(value);
        }

        private void ManageContentCategoriesForm_Load(object sender, System.EventArgs e)
        {
            this.pbLoading.Visible = true;
            getContentCategoriesBackgroundWorker.RunWorkerAsync();
        }

        private void LbxContentCategories_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var contentCategory = (ContentCategoryViewModel)((ListBox)sender).SelectedItem;

            if (contentCategory != null)
            {
                tbxEdit.Text = contentCategory.Name;
                tbxEdit.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                tbxEdit.Text = string.Empty;
                tbxEdit.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            var value = tbxAdd.Text;
            if(!string.IsNullOrWhiteSpace(value))
            {
                this.pbLoading.Visible = true;
                this.addContentCategoryBackgroundWorker.RunWorkerAsync(new ContentCategoryViewModel { Name = value });
            }
        }

        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить категорию? Все темы, относящиеся к этой категории будут недоступны в пользовательском инфокиоске!", "Внимание!", MessageBoxButtons.YesNo);
            
            if(result.ToString().ToUpper() == "Yes".ToUpper())
            {
                pbLoading.Visible = true;
                var selectedContentCategory = (ContentCategoryViewModel)lbxContentCategories.SelectedItem;
                this.deleteContentCategoryBackgroundWorker.RunWorkerAsync(selectedContentCategory);
            }
        }

        private void BtnEdit_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите отредактировать категорию?", "Внимание!", MessageBoxButtons.YesNo);

            if (result.ToString().ToUpper() == "Yes".ToUpper())
            {
                pbLoading.Visible = true;
                var selectedContentCategory = (ContentCategoryViewModel)lbxContentCategories.SelectedItem;
                this.editContentCategoryBackgroundWorker.RunWorkerAsync(new ContentCategoryViewModel { Id = selectedContentCategory.Id, Name = tbxEdit.Text});
            }
        }
    }
}
