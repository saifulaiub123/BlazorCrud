using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOM.Core.DBModel;

namespace SOM.DAL.Configuration
{
    public class WindowConfiguration : IEntityTypeConfiguration<Window>
    {
        public void Configure(EntityTypeBuilder<Window> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}