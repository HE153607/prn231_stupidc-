namespace Backend.Database
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public bool status { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
