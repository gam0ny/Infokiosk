using DatabaseLayer.Repositories;
using System;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {

            UserRepository userRepository = new UserRepository();

            TryUserAuthenication(userRepository, "admin", "sa");

            ArticleRepository articleRepository = new ArticleRepository();

            GetLatestArticles(articleRepository);

            GetArticlesByCategoryId(articleRepository, 1);

            Console.ReadKey();
        }

        public static void TryUserAuthenication(UserRepository userRepository, string userName, string password)
        {
            Console.WriteLine("Trying User Authentication: [{0}], [{1}]", userName, password);

            try
            {
                bool result = userRepository.Authenticate(userName, password);
                if(result)
                {
                    Console.WriteLine("Authentication is successfull");
                }
                else
                {
                    Console.WriteLine("Authentication failed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void GetLatestArticles(ArticleRepository articleRepository)
        {
            Console.WriteLine("Retrieving Latest Articles ...");

            var articles = articleRepository.GetLatestArticles();
        }

        public static void GetArticlesByCategoryId(ArticleRepository articleRepository, int categoryId)
        {
            Console.WriteLine("Retrieving Latest Articles ...");

            var articles = articleRepository.GetArticlesByCategoryId(categoryId);
        }
    }
}
