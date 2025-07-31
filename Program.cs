using System;
using Blog.Data;
using Blog.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            //Add User
            // context.Users.Add(new User
            // {
            //     Bio = "9x Micrososft MVP",
            //     Email = "andre@balta.io",
            //     Image = "https://balta.io",
            //     Name = "André Baltieri",
            //     PasswordHash = "1234",
            //     Slug = "andre-baltieri"

            // });
            // context.SaveChanges();

            var user = context.Users.FirstOrDefault(x => x.Email == "andre@balta.io");

            var post = new Post
            {
                Author = user,
                Body = "Meu artigo",
                Category = new Category
                {
                    Name = "Back-End",
                    Slug = "back-end"
                },
                CreateDate = System.DateTime.Now,
                //LastUpdateDate
                Slug = "meu-artigo",
                Summary = "Neste artigo vamos conferir...",
                // Tags = null,
                Title = "Meu artigo",

            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}