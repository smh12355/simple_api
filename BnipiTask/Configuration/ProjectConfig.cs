using BnipiTask.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BnipiTask.Configuration
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(b => b.Cipher)
                .IsRequired();

            builder.Property(b => b.Name)
                .IsRequired();
        }
    }
}
