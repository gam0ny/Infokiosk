namespace BusinessLogicLayer.ViewModels
{
    public class ArticleModel : ArticlePreviewModel
    {
        public string Content { get; set; }

        public bool IsPublishing { get; set; }
    }
}
