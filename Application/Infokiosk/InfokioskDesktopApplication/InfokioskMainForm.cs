using CustomControlLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskMainForm : Form
    {
        public InfokioskMainForm()
        {
            InitializeComponent();
            this.iblvRecentlyAdded.Title = "Новое";
            this.iblvRecentlyAdded.CountItemsPerLine = 4;
            this.iblvRecentlyAdded.ImageBoxItemList = new List<ImageBoxItem> {
                new ImageBoxItem { Category="IXX Век", Title = "Тема 1", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/1.jpg", HasDocuments = true, HasVideo = false },
                new ImageBoxItem { Category="Золотой Век", Title = "Тема 2", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/2.jpg", HasDocuments = true, HasVideo = true },
                new ImageBoxItem { Category="Искусство", Title = "Тема 3", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/3.jpg", HasDocuments = false, HasVideo = false },
                new ImageBoxItem { Category="XVI Век", Title = "Тема 4", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/4.jpg", HasDocuments = false, HasVideo = false },
                new ImageBoxItem { Category="Наука", Title = "Тема 5", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/5.jpg", HasDocuments = true, HasVideo = false },
                new ImageBoxItem { Category="IXX Век", Title = "Тема 1", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/1.jpg", HasDocuments = true, HasVideo = false },
                new ImageBoxItem { Category="Золотой Век", Title = "Тема 2", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/2.jpg", HasDocuments = true, HasVideo = true },
                new ImageBoxItem { Category="Искусство", Title = "Тема 3", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/3.jpg", HasDocuments = false, HasVideo = false },
                new ImageBoxItem { Category="XVI Век", Title = "Тема 4", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/4.jpg", HasDocuments = false, HasVideo = false },
                new ImageBoxItem { Category="Наука", Title = "Тема 5", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/5.jpg", HasDocuments = true, HasVideo = false },
            };

            this.iblvPerCategory.Title = "IXX Век";
            this.iblvPerCategory.CountItemsPerLine = 4;
            this.iblvPerCategory.ImageBoxItemList = new List<ImageBoxItem> {
                new ImageBoxItem { Category="IXX Век", Title = "Тема 1", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/1.jpg", HasDocuments = true, HasVideo = false },
                new ImageBoxItem { Category="IXX Век", Title = "Тема 1", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/1.jpg", HasDocuments = true, HasVideo = false },
            };
        }

        private void InfokioskMainForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.iblvPerCategory.Location = new Point(0, this.iblvRecentlyAdded.Size.Height);
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
