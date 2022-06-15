using System;

namespace Blog.Screens.PostScreens
{
    public static class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de posts");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar posts");
            Console.WriteLine("2 - Cadastrar posts");
            Console.WriteLine("3 - Atualizar post");
            Console.WriteLine("4 - Excluir post");
            Console.WriteLine("0 - Retornar ao menu anterior");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListPostsScreen.Load();
                    break;
                case 2:
                    CreatePostScreen.Load();
                    break;
                case 3:
                    UpdatePostScreen.Load();
                    break;
                case 4:
                    DeletePostScreen.Load();
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