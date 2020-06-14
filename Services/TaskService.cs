using Microsoft.EntityFrameworkCore;
using ProjectManagement.WebAPI.Contracts;
using ProjectManagement.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Services
{
    public class TaskService: ITaskService
    {

        private ITaskRepository _taskRepository;

        public TaskService (ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<D_Task>> GetAllAsync()
        {
            return await _taskRepository.GetAll().ToListAsync();
        }

        public async Task<D_Task> GetByIdAsync(int Id)
        {
            return await _taskRepository.GetSingleEntityByCondition(x => x.TaskId == Id);
        }

        public async Task SaveAsync(D_Task task)
        {
            await _taskRepository.SaveAsync(task);           
        }


        public async Task UpdateAsync(D_Task task)
        {
            await _taskRepository.UpdateAsync(task);
        }

        public async Task DeleteAsync(D_Task task)
        {
            await _taskRepository.DeleteAsync(task);
        }

       
    }
}
