using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanStore.Domain.Model;

namespace UrbanStore.Domain.Interfaces
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAllBrandsAsync();
        Task<Brand> GetByIdAsync(Guid id);
        Task<Brand> AddAsync(Brand brand);
        Task<Brand> UpdateAsync(Brand brand);
        Task<Brand> DeleteAsync(Guid id);
    }
}