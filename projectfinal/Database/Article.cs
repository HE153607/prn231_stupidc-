using System.ComponentModel.DataAnnotations;

namespace Backend.Database
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        
        public int CategoryId { get; set; }
        public int UserId { get; set; }

        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual Category Categorys { get; set; }
        public virtual User Users { get; set; }

    }
}
