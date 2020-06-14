using ProjectManagement.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Contracts
{
    /// <summary>
    /// Task Interface 
    /// </summary>
    public interface ITaskService
    {
        Task<IEnumerable<D_Task>> GetAllAsync();
        Task<D_Task> GetByIdAsync(int Id);
        Task SaveAsync(D_Task task);
        Task UpdateAsync(D_Task task);
        Task DeleteAsync(D_Task task);
    }
}
