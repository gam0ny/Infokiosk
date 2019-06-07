using System;

namespace BusinessLogicLayer.ViewModels
{
    public class ArticleModel : ArticlePreviewModel
    {
        public string Content { get; set; }

        public bool IsPublishing { get; set; }

        public string TitleFileName { get; set; }

        public Guid? UserId { get; set; }
    }
}
