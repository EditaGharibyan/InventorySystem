using InventoryApi.Entities;

namespace InventoryApi.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> Create(Product product);
        Task Update(int id, Product product);
        Task Delete(int id);
    }
}
