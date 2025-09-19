namespace InventoryApi.Entities
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;//stock

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
