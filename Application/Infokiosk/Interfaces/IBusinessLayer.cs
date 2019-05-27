using System.Collections.Generic;

namespace Interfaces
{
    public interface IInfokioskDesktopApplicationController
    {
        List<ArticlePreviewModel> GetLatestArticles(int limit = 0);

    }
}
