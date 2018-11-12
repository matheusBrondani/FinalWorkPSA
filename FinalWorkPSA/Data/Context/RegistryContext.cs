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
        public DbSet<Historic> Historic { get; set; } 
        public DbSet<Requirement> Requirement { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
    }
}
