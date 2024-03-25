using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanStore.Domain.Model;

namespace UrbanStore.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetByIdAsync(Guid id);
        Task<User> AddAsync(User user);
        Task<User> UpdateAsync(User user);
        Task<User> DeleteAsync(Guid id);        
    }
}