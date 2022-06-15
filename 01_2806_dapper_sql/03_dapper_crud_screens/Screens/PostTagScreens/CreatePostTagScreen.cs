using Blog.Models;
using Blog.Repositories;
using System;

namespace Blog.Screens.PostTagScreens
{
    public static class CreatePostTagScreen
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
            Console.WriteLine("Lista de posts");
            Console.WriteLine("-------------");
            var postRepository = new Repository<Post>(Database.Connection);
            var posts = postRepository.Get();
            foreach (var item in posts)
                Console.WriteLine($"{item.Id} - {item.Title}");
            Console.WriteLine("-------------");
            Console.Write("Escolha o id do post: ");
            var idPost = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            var tagRepository = new Repository<Tag>(Database.Connection);
            var tags = tagRepository.Get();
            foreach (var item in tags)
                Console.WriteLine($"{item.Id} - {item.Name}");
            Console.WriteLine("-------------");
            Console.Write("Escolha o id da tag: ");
            var idTag = int.Parse(Console.ReadLine());
            Console.Clear();

            var postTagRepository = new Repository<PostTag>(Database.Connection);
            postTagRepository.Create(new PostTag
            {
                PostId = idPost,
                TagId = idTag
            });

            Console.WriteLine("Post: {0}\nTag: {1}", postRepository.Get(idPost).Title, tagRepository.Get(idTag).Name);
            Console.ReadLine();
            Program.Load();
        }
    }
}