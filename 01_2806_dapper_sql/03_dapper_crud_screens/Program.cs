using System;
using Blog.Screens.CategoriaScreens;
using Blog.Screens.PostScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserRoleScreens;
using Blog.Screens.PostTagScreens;
using Blog.Screens.ReportScreens;
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
            Console.WriteLine("1 - Gestão de posts");
            Console.WriteLine("2 - Gestão de categorias");
            Console.WriteLine("3 - Gestão de tags");
            Console.WriteLine("4 - Gestão de usuários/perfis");
            Console.WriteLine("5 - Gestão de posts/tags");
            Console.WriteLine("6 - Relatórios");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    MenuPostScreen.Load();
                    break;
                case 2:
                    MenuCategoriaScreen.Load();
                    break;
                case 3:
                    MenuTagScreen.Load();
                    break;
                case 4:
                    MenuUserRoleScreen.Load();
                    break;
                case 5:
                    MenuPostTagScreen.Load();
                    break;
                case 6:
                    MenuReportScreen.Load();
                    break;
                default: 
                    Load(); 
                    break;
            }
        }
    }
}
