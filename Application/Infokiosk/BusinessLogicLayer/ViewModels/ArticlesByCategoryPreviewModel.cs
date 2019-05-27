using System.Collections.Generic;

namespace BusinessLogicLayer.Models
{
    public class ArticlesByCategoryPreviewModel
    {
        public string Category { get; set; }

        public List<ArticlePreviewModel> Articles { get; set; }
    }
}
