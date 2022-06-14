using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um post");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

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

            var repository = new Repository<Post>(Database.Connection);
            var editPost = repository.Get(id);
            var dataAtualizacao = DateTime.Now;

            System.Console.WriteLine(editPost);
            System.Console.WriteLine(editPost.CreateDate);
            System.Console.WriteLine(dataAtualizacao);

            Update(new Post
            {
                Id = id,
                Title = title,
                CategoryId = category,
                AuthorId = author,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = editPost.CreateDate,
                LastUpdateDate = dataAtualizacao
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Update(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Update(post);
                Console.WriteLine("Post atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}