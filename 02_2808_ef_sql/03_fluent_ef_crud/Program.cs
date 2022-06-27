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

            User fran = new User
            {
                Name = "Fran",
                Bio = "CS Developer",
                Email = "fjnf@fjnf.com",
                Image = "blob",
                PasswordHash = "Hash",
                Slug = "fran"
            };
            var post = new Post
            {
                Author = fran,
                Body = "Meu artigo",
                Category = new Category
                {
                    Name = "Backend",
                    Slug = "backend"
                },
                CreateDate = DateTime.Now,
                Slug = "meu-artigo",
                Summary = "Nesse artigo vamos conferir",
                Title = "Meu artigo"
            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}