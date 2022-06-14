using System;
using Blog.Screens.CategoriaScreens;
using Blog.Screens.PostScreens;
using Blog.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
    public class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("0 - Gestão de posts");
            Console.WriteLine("1 - Gestão de usuários");
            Console.WriteLine("2 - Gestão de perfis");
            Console.WriteLine("3 - Gestão de categorias");
            Console.WriteLine("4 - Gestão de tags");
            Console.WriteLine("5 - Vincular perfis/usuários");
            Console.WriteLine("6 - Vincular posts/tags");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 0:
                    MenuPostScreen.Load();
                    break;
                // case 1:
                //     MenuTagScreen.Load();
                //     break;
                // case 2:
                //     MenuTagScreen.Load();
                //     break;
                case 3:
                    MenuCategoriaScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                // case 5:
                //     MenuTagScreen.Load();
                //     break;              
                // case 6:
                //     MenuTagScreen.Load();
                //     break;
                // case 7:
                //     MenuTagScreen.Load();
                //     break;

                default: Load(); break;
            }
        }
    }
}
