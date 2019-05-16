using System;

namespace Entities
{
    public class ArticleShort
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string TitleImageName { get; set; }

        public bool HasVideo { get; set; }

        public bool HasDocument { get; set; }

        public ContentCategory ContentCategory { get; set; }
    }
}
