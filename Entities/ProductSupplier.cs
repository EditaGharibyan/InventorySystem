namespace InventoryApi.Entities
{
    public class ProductSupplier
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; } = null!;
    }
}
