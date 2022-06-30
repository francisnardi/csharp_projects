using System;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new BlogDataContext();

            var posts = context.Posts.ToListAsync();
            var users = context.Users.ToListAsync();
            // var posts = await context.Posts.ToListAsync();
            // var users = await context.Users.ToListAsync();
            Console.WriteLine("posts");
            Console.WriteLine("users");
        }
    }
}