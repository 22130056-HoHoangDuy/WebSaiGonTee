namespace SaiGonTee_Ecom.Models
{
    public class Banner
    {
        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public string BannerName { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation property
        public ProductVariant ProductVariant { get; set; }
    }
}
