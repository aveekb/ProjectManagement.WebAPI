using ProjectManagement.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<M_User>> GetAllAsync();
        Task<M_User> GetByIdAsync(int Id);
        Task SaveAsync(M_User user);
        Task UpdateAsync(M_User user);
        Task DeleteAsync(M_User user);
    }
}
