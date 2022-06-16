using Blog.Models;
using Blog.Repositories;
using System;

namespace Blog.Screens.ReportScreens
{
    public static class ListUserCommaScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários separados por vírgula");
            Console.WriteLine("---------------------------------------");
            List();
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Program.Load();
        }

        public static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();
            foreach (var user in users)
            {
                Console.Write("{0}, ", user.Name);
            }
            Console.WriteLine();
        }
    }
}