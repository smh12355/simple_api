using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BnipiTask.DataAccess.Entities;
using BnipiTask.Core.Models;

namespace BnipiTask.DataAccess.Configuration
{
    public class MarkTypeConfiguration : IEntityTypeConfiguration<MarkTypeEntity>
    {
        public void Configure(EntityTypeBuilder<MarkTypeEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(b => b.ShortName)
                .IsRequired()
                .HasMaxLength(MarkType.MAX_SHORTNAME_LENGHT);

            builder.Property(b => b.FullName)
                .IsRequired()
                .HasMaxLength(MarkType.MAX_FULLNAME_LENGHT); ;

            builder.HasMany(b => b.DocumentationSets)
                .WithOne(ds => ds.MarkType)
                .HasForeignKey(ds => ds.MarkTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
