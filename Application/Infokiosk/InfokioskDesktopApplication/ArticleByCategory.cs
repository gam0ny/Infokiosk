using CustomControlLibrary.Entities;
using System.Collections.Generic;

namespace InfokioskDesktopApplication
{
    public class ArticleByCategory
    {
        public string Category { get; set; }

        public List<ImageBoxItem> Articles { get; set; }
    }
}
