using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectManagment.Models;

namespace ProjectManagment.Data
{
    public class PmContext : DbContext
    {
        public PmContext (DbContextOptions<PmContext> options)
            : base(options)
        {
        }

        public DbSet<Developer> Developer { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<Assignment> Assignment { get; set; }

        
    }
}
