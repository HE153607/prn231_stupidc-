namespace Backend.Database
{
    public class Image
    {
        public int ImageId { get; set; }
        public byte[] Name { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
