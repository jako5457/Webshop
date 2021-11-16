namespace WebApp.Models
{
    public class ProductModel
    {
        public long ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ManufacturerName { get; set; }
        public long ManufacturerId { get; set; }
    }
}
