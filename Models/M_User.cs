using ProjectManagement.WebAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Models
{
    public class M_User
    {
        [Key]
        public int UserId { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public int TaskId { get; set; }
       
    }

    public interface IUserRepository : IRepositoryBase<M_User>
    {
    }

    public class UserRepository : RepositoryBase<M_User>, IUserRepository
    {
        public UserRepository(ProjectMgrDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
