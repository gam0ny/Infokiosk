using System;

namespace InfokioskDesktopApplication.Models
{
    public class ArticlePreviewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public bool HasVideo { get; set; }

        public bool HasDocument { get; set; }

        public string CategoryName { get; set; }
    }
}
