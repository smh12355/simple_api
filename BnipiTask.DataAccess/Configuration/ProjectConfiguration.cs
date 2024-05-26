using BnipiTask.Core.Models;
using BnipiTask.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BnipiTask.DataAccess.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<ProjectEntity>
    {
        public void Configure(EntityTypeBuilder<ProjectEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(b => b.Cipher)
                .IsRequired()
                .HasMaxLength(Project.MAX_CIPHER_LENGHT);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(Project.MAX_NAME_LENGHT);

            builder.HasMany(p => p.DesignObjects)
               .WithOne(d => d.Project)
               .HasForeignKey(d => d.ProjectId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(b => b.Cipher).IsUnique();
            builder.HasIndex(b => b.Name);

            //builder.Navigation(p => p.DesignObjects)
            //    .HasField("_designObjects")
            //    .UsePropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
