using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {

        protected override void OnConfiguring(
            DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=BlogEF;User ID=sa;Password=MinhaSenha@123;TrustServerCertificate=True");
        }

    }
}