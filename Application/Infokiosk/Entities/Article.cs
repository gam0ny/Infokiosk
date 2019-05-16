using System;

namespace Entities
{
    public class Article : ArticleShort
    {
        public string UserId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime EditingDate { get; set; }
    }
}
