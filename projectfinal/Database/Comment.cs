using System.ComponentModel.DataAnnotations;

namespace Backend.Database
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public int ArticleId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public virtual User User { get; set; }
        public virtual Article Article { get; set; }
    }
}
