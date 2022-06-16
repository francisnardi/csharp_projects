using Blog.Repositories;
using System;

namespace Blog.Screens.PostTagScreens
{
    public static class ListPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de posts/tags");
            Console.WriteLine("-------------");
            var repository = new PostRepository(Database.Connection);
            var postTags = repository.GetWithTags();

            foreach (var postTag in postTags)
            {
                Console.WriteLine(postTag.Title);
                foreach (var pstTag in postTag.Tags) Console.WriteLine($" - {pstTag.Name}");
            }
            Console.WriteLine("-------------");
            Console.ReadKey();
            Console.Clear();
            Program.Load();
        }
    }
}