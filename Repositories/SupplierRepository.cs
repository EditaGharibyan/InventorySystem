using InventoryApi.Data;
using InventoryApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryApi.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly InventoryDbContext _context;

        public SupplierRepository(InventoryDbContext context)
        {
            _context = context;
        }

        public async Task<List<Supplier>> GetAll()
        {
            return await _context.Suppliers
                .Include(s => s.ProductSuppliers)
                .ThenInclude(ps => ps.Product)
                .ToListAsync();
        }

        public async Task<Supplier> GetById(int id)
        {
            return await _context.Suppliers
                .Include(s => s.ProductSuppliers)
                .ThenInclude(ps => ps.Product)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Add(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var supplier = await GetById(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                await _context.SaveChangesAsync();
            }
        }
    }
}
