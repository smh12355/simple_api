using BnipiTask.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BnipiTask.Configuration
{
    public class DesignObjectConfig : IEntityTypeConfiguration<DesignObject>
    {
        public void Configure(EntityTypeBuilder<DesignObject> builder)
        {
            builder.Property(b => b.Code)
                .IsRequired();

            builder.Property(b => b.Name)
                .IsRequired();

            builder.HasMany(a => a.DocSets)
                .WithOne(a => a.DesignObject)
                .HasForeignKey(a => a.DesignObjectId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
