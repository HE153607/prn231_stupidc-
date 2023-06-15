namespace Backend.Database
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool status { get; set; }   
        public DateTime CreateDate { get; set; }
        public int roleId { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Role role { get; set; }
    }
}
