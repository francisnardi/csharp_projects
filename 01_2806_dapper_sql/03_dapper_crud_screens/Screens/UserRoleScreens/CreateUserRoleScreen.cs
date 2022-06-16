using Blog.Models;
using Blog.Repositories;
using System;

namespace Blog.Screens.UserRoleScreens
{
    public static class CreateUserRoleScreen
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
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("-------------");
            var userRepository = new Repository<User>(Database.Connection);
            var users = userRepository.Get();
            foreach (var item in users)
                Console.WriteLine($"{item.Id} - {item.Name}");
            Console.WriteLine("-------------");
            Console.Write("Escolha o id de usuário: ");
            var idUser = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Lista de perfis");
            Console.WriteLine("-------------");
            var roleRepository = new Repository<Role>(Database.Connection);
            var perfis = roleRepository.Get();
            foreach (var item in perfis)
                Console.WriteLine($"{item.Id} - {item.Name}");
            Console.WriteLine("-------------");
            Console.Write("Escolha o id de perfil: ");
            var idRole = int.Parse(Console.ReadLine());
            Console.Clear();

            var userRoleRepository = new Repository<UserRole>(Database.Connection);
            userRoleRepository.Create(new UserRole
            {
                UserId = idUser,
                RoleId = idRole
            });

            Console.WriteLine("Usuário: {0}\nPerfil: {1}", userRepository.Get(idUser).Name, roleRepository.Get(idRole).Name);
            Console.ReadLine();
            MenuUserRoleScreen.Load();
        }
    }
}