using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[PostTag]")]
    public class PostTag
    {
        // PostId
        public int Id { get; set; }
        public int TagId { get; set; }
    }
}