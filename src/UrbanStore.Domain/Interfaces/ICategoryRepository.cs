using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanStore.Domain.Model;

namespace UrbanStore.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetByIdAsync(Guid id);
        Task<Category> AddAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<Category> DeleteAsync(Guid id);
        Task<Category> InactiveAsync(Guid id); 
    }
}