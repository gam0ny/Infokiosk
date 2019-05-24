using System.Collections.Generic;

namespace Entities
{
    public class ArticlesByCategory
    {
        public ContentCategory ContentCategory { get; set; }

        public List<ArticleShort> Articles { get; set; }
    }
}
