using ProjectManagement.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Contracts
{
    public interface IProjectService
    {
        Task<IEnumerable<D_Project>> GetAllAsync();
        Task<D_Project> GetByIdAsync(int Id);
        Task SaveAsync(D_Project user);
        Task UpdateAsync(D_Project user);
        Task DeleteAsync(D_Project user);
    }
}
