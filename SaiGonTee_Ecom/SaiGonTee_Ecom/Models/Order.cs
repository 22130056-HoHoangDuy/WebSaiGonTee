namespace SaiGonTee_Ecom.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; } = "processing";
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int ShippingCompanyId { get; set; }
        public string Address { get; set; }
        public int PaymentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ShippingCompany ShippingCompany { get; set; }
        public Payment Payment { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
