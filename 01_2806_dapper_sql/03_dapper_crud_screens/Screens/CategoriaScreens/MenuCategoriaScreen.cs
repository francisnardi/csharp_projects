using System;

namespace Blog.Screens.CategoriaScreens
{
    public static class MenuCategoriaScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de categorias");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar categorias");
            Console.WriteLine("2 - Cadastrar categorias");
            Console.WriteLine("3 - Atualizar tag");
            Console.WriteLine("4 - Excluir tag");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCategoriasScreen.Load();
                    break;
                case 2:
                    CreateCategoriaScreen.Load();
                    break;
                case 3:
                    UpdateCategoriaScreen.Load();
                    break;
                case 4:
                    DeleteCategoriaScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}