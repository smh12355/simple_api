using BnipiTask.Core.Models;
using BnipiTask.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BnipiTask.DataAccess.Configuration
{
    internal class DesignObjectConfiguration : IEntityTypeConfiguration<DesignObjectEntity>
    {
        public void Configure(EntityTypeBuilder<DesignObjectEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(b => b.Code)
                .IsRequired()
                .HasMaxLength(DesignObject.MAX_CODE_LENGTH);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(DesignObject.MAX_NAME_LENGTH);

            builder.HasOne(d => d.Project)
                .WithMany(p => p.DesignObjects)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(d => d.DocumentSets)
                .WithOne(ds => ds.DesignObject)
                .HasForeignKey(ds => ds.DesignObjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(b => b.Code); 
            builder.HasIndex(b => b.Name);

            //builder.Navigation(d => d.DocumentSets)
            //    .UsePropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
