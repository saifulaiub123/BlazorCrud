using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOM.Core.DBModel;

namespace SOM.DAL.Configuration
{
    public class ElementConfiguration : IEntityTypeConfiguration<Element>
    {
        public void Configure(EntityTypeBuilder<Element> builder)
        {
            builder.Property(x => x.Width)
                .IsRequired();
            builder.Property(x => x.Height)
                .IsRequired();
            builder.Property(x => x.ElementTypeId)
                .IsRequired();
            builder.Property(x => x.IsDeleted)
                .IsRequired();
        }
    }
}
