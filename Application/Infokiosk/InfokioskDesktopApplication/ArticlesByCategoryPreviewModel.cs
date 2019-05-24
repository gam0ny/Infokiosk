using System.Collections.Generic;

namespace InfokioskDesktopApplication
{
    public class ArticlesByCategoryPreviewModel
    {
        public string Category { get; set; }

        public List<ArticlePreviewModel> Articles { get; set; }
    }
}
