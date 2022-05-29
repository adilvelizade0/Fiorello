namespace Fiorello.DAL.Models
{
    public class Say
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string ImgUrl { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public bool IsDeleted { get; set; }
    }
}