using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }

        public Post Post { get; set; }
        public Tag Tag { get; set; }
        
    }
}