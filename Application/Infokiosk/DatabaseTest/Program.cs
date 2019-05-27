using DatabaseLayer.Interfaces;
using DatabaseLayer.Repositories;
using System;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var userRepository = new UserRepository();

            TryUserAuthenication(userRepository, "admin", "sa");

            var articleRepository = new ArticleRepository();

            GetLatestArticles(articleRepository);

            GetArticlesByCategoryId(articleRepository, 1);

            Console.ReadKey();
        }

        public static void TryUserAuthenication(IUserRepository userRepository, string userName, string password)
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

        public static void GetLatestArticles(IArticleRepository articleRepository)
        {
            Console.WriteLine("Retrieving Latest Articles ...");

            var articles = articleRepository.GetLatestArticles();
        }

        public static void GetArticlesByCategoryId(IArticleRepository articleRepository, int categoryId)
        {
            Console.WriteLine("Retrieving Latest Articles ...");

            var articles = articleRepository.GetArticlesByCategoryId(categoryId);
        }
    }
}
