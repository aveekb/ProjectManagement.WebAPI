using ProjectManagement.WebAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Models
{
    public class D_Task
    {
        [Key]
        public int TaskId { get; set; }
        public int Parent_Id { get; set; }
        public int Project_Id { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
    }

    public interface ITaskRepository : IRepositoryBase<D_Task>
    {
    }

    public class TaskRepository : RepositoryBase<D_Task>, ITaskRepository
    {
        public TaskRepository(ProjectMgrDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
