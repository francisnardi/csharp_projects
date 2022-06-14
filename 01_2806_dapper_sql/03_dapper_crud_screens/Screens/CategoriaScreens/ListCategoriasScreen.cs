using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoriaScreens
{
    public static class ListCategoriasScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuCategoriaScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categorias = repository.Get();
            foreach (var item in categorias)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}