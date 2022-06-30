using System;
using System.Linq;
using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();
            var user = context.Users.FirstOrDefault();
            user.GitHub = "fran";         
            context.Users.Update(user);
            context.SaveChanges();
            Console.WriteLine($"{user.GitHub}");
        }
    }
}