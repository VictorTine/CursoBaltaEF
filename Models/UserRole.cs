using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Blog.Models
{
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }
    }
}