namespace SaiGonTee_Ecom.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public int StockQuantity { get; set; }
        public int SaleQuantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation property
        public ProductVariant ProductVariant { get; set; }
    }
}

