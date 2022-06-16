using System;

namespace Blog.Screens.ReportScreens
{
    public static class MenuReportScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Relatórios");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Os usuários separados por vírgula");
            Console.WriteLine("2 - As categorias com quantidades de posts");
            Console.WriteLine("3 - As tags com quantidades de posts");
            Console.WriteLine("4 - Os posts de sua categoria");
            Console.WriteLine("5 - Todos os posts com sua categoria");
            Console.WriteLine("6 - Todos os posts com suas tags");
            Console.WriteLine("0 - Retornar ao menu anterior");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserCommaScreen.Load();
                    break;
                case 2:
                    ListCategoryPostScreen.Load();
                    break;
                case 3:
                    ListTagPostScreen.Load();
                    break;
                case 4:
                    Program.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                case 6:
                    Program.Load();
                    break;
                case 0:
                    Program.Load();
                    break;
                default:
                    Program.Load();
                    break;
            }
        }
    }
}