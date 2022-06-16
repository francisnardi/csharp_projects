using System;
using System.Collections.Generic;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
    public static class ListTagPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Número de posts por tags");
            Console.WriteLine("-----------------------------");
            List();
            Console.WriteLine("-----------------------------");
            Console.ReadKey();
            Program.Load();
        }

        private static void List()
        {
            Dictionary<int, int> counterDict = new Dictionary<int, int>();
            var postTagRepository = new Repository<PostTag>(Database.Connection);


            var postsTags = postTagRepository.Get();
            var tagRepository = new Repository<Tag>(Database.Connection);

            foreach (var item in postsTags)
                if (counterDict.ContainsKey(item.TagId))
                    counterDict[item.TagId]++;
                else
                    counterDict.Add(item.TagId, 1);

            foreach (var elem in counterDict)
                Console.WriteLine("{0}: {1} post(s)", tagRepository.Get(elem.Key).Name, elem.Value);
        }
    }
}