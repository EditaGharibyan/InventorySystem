using InventoryApi.Entities;

namespace InventoryApi.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int id);
        Task<Category> Create(Category category);
        Task Update(int id, Category category);
        Task Delete(int id);
    }
}
