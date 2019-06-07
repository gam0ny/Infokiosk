using System;

namespace Entities
{
    public class Article : ArticleShort
    {
        public string Content { get; set; }

        public Guid? UserId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime EditingDate { get; set; }

        public bool IsPublished { get; set; }

        public DateTime? PublishingDate { get; set; }
    }
}
