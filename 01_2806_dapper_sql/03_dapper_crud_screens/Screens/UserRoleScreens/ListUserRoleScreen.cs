using Blog.Models;
using Blog.Repositories;
using System;

namespace Blog.Screens.UserRoleScreens
{
    public static class ListUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários/perfis");
            Console.WriteLine("-------------");
            var repository = new UserRepository(Database.Connection);
            var userRoles = repository.GetWithRoles();

            foreach (var userRole in userRoles)
            {
                Console.WriteLine(userRole.Name);
                foreach (var role in userRole.Roles) Console.WriteLine($" - {role.Slug}");
            }
            Console.WriteLine("-------------");
            Console.ReadKey();
            Console.Clear();
            Program.Load();
        }
    }
}