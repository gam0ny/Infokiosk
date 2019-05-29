using System.Collections.Generic;

namespace BusinessLogicLayer.ViewModels
{
    public class ArticlesByCategoryPreviewModel
    {
        public string Category { get; set; }

        public List<ArticlePreviewModel> Articles { get; set; }
    }
}
