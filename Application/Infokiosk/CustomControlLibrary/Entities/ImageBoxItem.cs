namespace CustomControlLibrary.Entities
{
    public class ImageBoxItem
    {
        public string Id { get; set; }
        public string Category { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public bool HasVideo { get; set; }

        public bool HasDocuments { get; set; }
    }
}
