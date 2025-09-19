using InventoryApi.Entities;

namespace InventoryApi.Services
{
    public interface ISupplierService
    {
        Task<List<Supplier>> GetAll();
        Task<Supplier> GetById(int id);
        Task<Supplier> Create(Supplier supplier);
        Task Update(int id, Supplier supplier);
        Task Delete(int id);
    }
}
