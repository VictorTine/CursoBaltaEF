using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Blog.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }
        public List<Post> Posts { get; set; } = new();
    }
}