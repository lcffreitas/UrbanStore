using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanStore.Domain.Model;

namespace UrbanStore.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetByIdAsync(Guid id);
        Task<Product> AddAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> DeleteAsync(Guid id);
        Task<Product> InactiveAsync(Guid id); 
    }
}