using Microsoft.EntityFrameworkCore;
using ProjectManagement.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Data
{
    public class ProjectMgrDbContext:DbContext
    {
        public ProjectMgrDbContext(DbContextOptions<ProjectMgrDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<M_User> Users { get; set; }
        public virtual DbSet<D_Project> Projects { get; set; }
        public virtual DbSet<D_Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }

    
}
