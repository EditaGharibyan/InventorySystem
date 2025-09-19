using InventoryApi.Entities;

namespace InventoryApi.Repositories
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetAll();
        Task<Supplier> GetById(int id);
        Task Add(Supplier supplier);
        Task Update(Supplier supplier);
        Task Delete(int id);
    }
}
