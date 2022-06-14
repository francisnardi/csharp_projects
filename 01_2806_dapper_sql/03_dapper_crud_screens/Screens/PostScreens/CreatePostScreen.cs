using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo post");
            Console.WriteLine("-------------");

            Console.Write("Título: ");
            var title = Console.ReadLine();
            Console.Write("Categoria: ");
            var category = int.Parse(Console.ReadLine());
            Console.Write("Autor: ");
            var author = int.Parse(Console.ReadLine());
            Console.Write("Resumo: ");
            var summary = Console.ReadLine();
            Console.Write("Texto: ");
            var body = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            var dataCriacao = DateTime.Now;

            Create(new Post
            {
                Title = title,
                CategoryId = category,
                AuthorId = author,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = dataCriacao,
                LastUpdateDate = dataCriacao
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine("Post cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}