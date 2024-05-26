using BnipiTask.Configuration;
using BnipiTask.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace BnipiTask
{
    public class BnipiTaskDbContext : DbContext
    {
        public BnipiTaskDbContext(DbContextOptions<BnipiTaskDbContext> options) : base(options)
        { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<DesignObject> DesignObjects { get; set; }
        public DbSet<DocSet> DocSets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
