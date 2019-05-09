using CustomControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskMainForm : Form
    {
        public InfokioskMainForm()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void InfokioskMainForm_Load(object sender, EventArgs e)
        {
            List<ArticlePreview> articlePreviews = new List<ArticlePreview> {
                new ArticlePreview { Category="IXX Век", Title = "Тема 1", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/1.jpg", HasDocuments = true, HasVideo = false },
                new ArticlePreview { Category="Золотой Век", Title = "Тема 2", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/2.jpg", HasDocuments = true, HasVideo = true },
                new ArticlePreview { Category="Искусство", Title = "Тема 3", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/3.jpg", HasDocuments = false, HasVideo = false },
                new ArticlePreview { Category="XVI Век", Title = "Тема 4", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/4.jpg", HasDocuments = false, HasVideo = false },
                new ArticlePreview { Category="Наука", Title = "Тема 5", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/5.jpg", HasDocuments = true, HasVideo = false },
                new ArticlePreview { Category="IXX Век", Title = "Тема 1", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/1.jpg", HasDocuments = true, HasVideo = false },
                new ArticlePreview { Category="Золотой Век", Title = "Тема 2", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/2.jpg", HasDocuments = true, HasVideo = true },
                new ArticlePreview { Category="Искусство", Title = "Тема 3", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/3.jpg", HasDocuments = false, HasVideo = false },
                new ArticlePreview { Category="XVI Век", Title = "Тема 4", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/4.jpg", HasDocuments = false, HasVideo = false },
                new ArticlePreview { Category="Наука", Title = "Тема 5", ImageUrl="c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/5.jpg", HasDocuments = true, HasVideo = false },
            };

            int xPoint = 0;
            int yPoint = 0;
            int totalPerLine = 4;

            for (int i = 0; i < articlePreviews.Count; i++)
            {
                var articlePreview = articlePreviews[i];
                var imageBox = new ImageBox();
                imageBox.Category = articlePreview.Category.ToUpper();
                imageBox.Title = articlePreview.Title;
                imageBox.HasVideo = articlePreview.HasVideo;
                imageBox.HasDocuments = articlePreview.HasDocuments;
                imageBox.Image = Image.FromFile(articlePreview.ImageUrl);

                if(i%totalPerLine == 0)
                {
                    xPoint = 0;
                    yPoint += imageBox.Size.Height;
                }

                imageBox.Location = new Point(xPoint, yPoint);
                xPoint += imageBox.Size.Width;
                this.Controls.Add(imageBox);
            }

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
