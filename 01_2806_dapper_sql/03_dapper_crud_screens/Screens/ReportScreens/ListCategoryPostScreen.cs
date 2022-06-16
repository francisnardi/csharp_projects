using System;
using System.Collections.Generic;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
    public static class ListCategoryPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Número de posts por categoria");
            Console.WriteLine("-----------------------------");
            List();
            Console.WriteLine("-----------------------------");
            Console.ReadKey();
            Program.Load();
        }

        private static void List()
        {
            Dictionary<int, int> counterDict = new Dictionary<int, int>();
            var postRepository = new Repository<Post>(Database.Connection);
            var posts = postRepository.Get();
            var categoryRepository = new Repository<Category>(Database.Connection);

            foreach (var item in posts)
                if (counterDict.ContainsKey(item.CategoryId))
                    counterDict[item.CategoryId]++;
                else
                    counterDict.Add(item.CategoryId, 1);

            foreach (var elem in counterDict)
                Console.WriteLine("{0}: {1} post(s)", categoryRepository.Get(elem.Key).Name, elem.Value);
        }
    }
}