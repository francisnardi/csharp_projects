using System;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";
        static void Main(string[] args)
        {
            var us = CreateUser();
            // ReadUser();
            // ReadUsers();
            UpdateUser(us);
            DeleteUser(us);
        }

        public static int CreateUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = new User()
                {
                    Bio = "Teste",
                    Email = "teste@teste.com",
                    Image = "https://",
                    Name = "Teste",
                    PasswordHash = "HASH",
                    Slug = "teste"
                };

                var users = connection.Insert<User>(user);
                Console.WriteLine("CREATE {0}: {1}", user.Id, user.Name);
                return user.Id;
            }
        }
        public static void ReadUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);
                Console.WriteLine(user.Name);
            }
        }
        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();
                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }

        public static void UpdateUser(int up)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = new User()
                {
                    Id = up,
                    Bio = "Teste Novo",
                    Email = "testeupdate@teste.com",
                    Image = "https://",
                    Name = "Teste Novo",
                    PasswordHash = "HASH",
                    Slug = "teste-novo"
                };

                var users = connection.Update<User>(user);
                Console.WriteLine("UPDATE {0}: {1}", user.Id, user.Name);
            }
        }
        public static void DeleteUser(int del)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(del);
                var users = connection.Delete<User>(user);
                Console.WriteLine("DELETE {0}: {1}", user.Id, user.Name);
            }
        }
    }
}