using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoriaScreens
{
    public static class CreateCategoriaScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova categoria");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoriaScreen.Load();
        }

        public static void Create(Category categoria)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(categoria);
                Console.WriteLine("Categoria cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}