using Microsoft.EntityFrameworkCore;
using ProjectManagement.WebAPI.Contracts;
using ProjectManagement.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Services
{
    public class ProjectService : IProjectService
    {

        private IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<IEnumerable<D_Project>> GetAllAsync()
        {
            return  await _projectRepository.GetAll().ToListAsync();
        }

        public async Task<D_Project> GetByIdAsync(int Id)
        {
            return await _projectRepository.GetSingleEntityByCondition(x => x.ProjectId == Id);
        }

        public async Task SaveAsync(D_Project project)
        {
            await _projectRepository.SaveAsync(project);
        }


        public async Task UpdateAsync(D_Project project)
        {
            await _projectRepository.UpdateAsync(project);
        }

        public async Task DeleteAsync(D_Project project)
        {
            await _projectRepository.DeleteAsync(project);
        }

       
    }
}
