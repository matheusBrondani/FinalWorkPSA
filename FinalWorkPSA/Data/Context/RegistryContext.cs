using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalWorkPSA.Models.Entities;

namespace FinalWorkPSA.Data.Context
{
    public class RegistryContext : DbContext
    {
        public RegistryContext(DbContextOptions<RegistryContext> options) : base(options) { }

        public DbSet<Class> Class { get; set; }
        public DbSet<HistoricService> Historic { get; set; } 
        public DbSet<RequirementService> Requirement { get; set; }
        public DbSet<StudentService> Student { get; set; }
        public DbSet<SubjectService> Subject { get; set; }
    }
}
