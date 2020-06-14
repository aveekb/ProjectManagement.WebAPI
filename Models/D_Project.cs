using ProjectManagement.WebAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Models
{
    [Table("Projects")]
    public class D_Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
       
    }

    public interface IProjectRepository : IRepositoryBase<D_Project>
    {
    }

    public class ProjectRepository : RepositoryBase<D_Project>, IProjectRepository
    {
        public ProjectRepository(ProjectMgrDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
