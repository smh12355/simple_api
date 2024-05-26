using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BnipiTask.Models;

namespace BnipiTask.Configuration
{
    public class DocSetConfig : IEntityTypeConfiguration<DocSet>
    {
        public void Configure(EntityTypeBuilder<DocSet> builder)
        {
            builder.Property(b => b.Number)
                .IsRequired();

            builder.Property(b => b.MarkType)
                .IsRequired();
        }
    }
}