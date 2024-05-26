using BnipiTask.Core.Models;
using BnipiTask.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BnipiTask.DataAccess.Configuration
{
    public class DocumentationSetConfiguration : IEntityTypeConfiguration<DocumentationSetEntity>
    {
        public void Configure(EntityTypeBuilder<DocumentationSetEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(b => b.Number)
                .IsRequired();

            builder.HasOne(ds => ds.DesignObject)
                .WithMany(d => d.DocumentSets)
                .HasForeignKey(ds => ds.DesignObjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ds => ds.MarkType)
                .WithMany(b => b.DocumentationSets)
                .HasForeignKey(ds => ds.MarkTypeId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
