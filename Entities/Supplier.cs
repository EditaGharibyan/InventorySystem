using System.ComponentModel.DataAnnotations;

namespace InventoryApi.Entities
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public List<ProductSupplier> ProductSuppliers { get; set; } = new List<ProductSupplier>();
    }
}
