using InventoryApi.Entities;
using InventoryApi.Repositories;

namespace InventoryApi.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _repo;

        public SupplierService(ISupplierRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Supplier>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Supplier> GetById(int id)
        {
            var supplier = await _repo.GetById(id);
            if (supplier == null)
                throw new Exception("Supplier չկա");
            return supplier;
        }

        public async Task<Supplier> Create(Supplier supplier)
        {
            if (string.IsNullOrEmpty(supplier.Name))
                throw new Exception("Supplier-ը անուն չունի");

            await _repo.Add(supplier);
            return supplier;
        }

        public async Task Update(int id, Supplier supplier)
        {
            var existing = await _repo.GetById(id);
            if (existing == null)
                throw new Exception("Պարոն Supplierը չի գտնվել");

            existing.Name = supplier.Name;
            await _repo.Update(existing);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }
    }
}
