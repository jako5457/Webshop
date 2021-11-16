namespace WebApp.Models
{
    public class CreateOrderModel
    {
        public OrderModel Order { get; set; }
        public List<ProductModel> Products { get; set; }
    }

    public class OrderModel
    {
        public long CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public long OrderId { get; set; }
        public double TotalPrice { get; set; }
    }
}
