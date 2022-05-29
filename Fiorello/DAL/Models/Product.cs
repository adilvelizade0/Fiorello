namespace Fiorello.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool IsDeleted { get; set; }
    }
}