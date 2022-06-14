using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoriaScreens
{
    public static class UpdateCategoriaScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma categoria");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Category
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            //MenuCategoriaScreen.Load();
        }

        public static void Update(Category categoria)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(categoria);
                Console.WriteLine("Categoria atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}