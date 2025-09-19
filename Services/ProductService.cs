using InventoryApi.Entities;
using InventoryApi.Repositories;

namespace InventoryApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            var product = await _repo.GetById(id);
            if (product == null)
                throw new Exception("Ապրանք չկա ազիզ ջան");
            return product;
        }

        public async Task<Product> Create(Product product)
        {
            if (string.IsNullOrEmpty(product.Name))
                throw new Exception("Անունը դատարկ չի կարող լինել");
            if (product.Price < 0)
                throw new Exception("Գինը պիտի լինի մեծ զրոյից");

            await _repo.Add(product);
            return product;
        }

        public async Task Update(int id, Product product)
        {
            var existing = await _repo.GetById(id);
            if (existing == null)
                throw new Exception("սխալ ապրանք");

            existing.Name = product.Name;
            existing.Quantity = product.Quantity;
            existing.Price = product.Price;
            existing.CategoryId = product.CategoryId;
            if (product.Detail != null)
            {
                existing.Detail.Description = product.Detail.Description;
                existing.Detail.SKU = product.Detail.SKU;
            }
            await _repo.Update(existing);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }
    }
}
