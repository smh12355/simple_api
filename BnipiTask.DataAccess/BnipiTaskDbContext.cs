using BnipiTask.DataAccess.Configuration;
using BnipiTask.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BnipiTask.DataAccess
{
    public class BnipiTaskDbContext : DbContext
    {
        public BnipiTaskDbContext(DbContextOptions<BnipiTaskDbContext> options) : base(options)
        { }
        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<DesignObjectEntity> DesignObjects { get; set; }
        public DbSet<MarkTypeEntity> MarkTypes { get; set; }
        public DbSet<DocumentationSetEntity> DocumentationSets { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<ProjectEntity>()
        //        .HasMany(p => p.DesignObjects)
        //        .WithOne(d => d.Project)
        //        .HasForeignKey(d => d.ProjectId);

        //    modelBuilder.Entity<DesignObjectEntity>()
        //        .HasMany(d => d.DocumentSets)
        //        .WithOne(ds => ds.DesignObject)
        //        .HasForeignKey(ds => ds.DesignObjectId);

        //    modelBuilder.Entity<DocumentationSetEntity>()
        //        .HasOne(ds => ds.MarkType)
        //        .WithMany(b => b.DocumentationSets)
        //        .HasForeignKey(ds => ds.MarkTypeId);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new DesignObjectConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentationSetConfiguration());
            modelBuilder.ApplyConfiguration(new MarkTypeConfiguration());
        }
    }
}
