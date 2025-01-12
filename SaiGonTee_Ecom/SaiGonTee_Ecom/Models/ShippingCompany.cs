namespace SaiGonTee_Ecom.Models
{
    public class ShippingCompany
    {
        public int Id { get; set; }
        public string ShippingCompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        public List<Order> Orders { get; set; }
    }
}
