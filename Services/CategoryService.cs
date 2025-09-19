using InventoryApi.Entities;
using InventoryApi.Repositories;

namespace InventoryApi.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Category> GetById(int id)
        {
            var category = await _repo.GetById(id);
            if (category == null)
                throw new Exception("Սխալ ");
            return category;
        }

        public async Task<Category> Create(Category category)
        {
            if (string.IsNullOrEmpty(category.Name))
                throw new Exception("category-ին անուն չունի");

            await _repo.Add(category);
            return category;
        }

        public async Task Update(int id, Category category)
        {
            var existing = await _repo.GetById(id);
            if (existing == null)
                throw new Exception("Category-ն չկա,ինչ ես ուզւոմ");

            existing.Name = category.Name;
            await _repo.Update(existing);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }
    }
}
