using System.ComponentModel.DataAnnotations;

namespace InventoryApi.Entities;

public class Product
{
    public int Id { get; set; }

    [Required] 
    public string Name { get; set; } = string.Empty;

    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public ProductDetail Detail { get; set; } = null!;

    public List<ProductSupplier> ProductSuppliers { get; set; } = new List<ProductSupplier>();
}