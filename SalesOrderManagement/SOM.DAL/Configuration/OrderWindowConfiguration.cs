using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOM.Core.DBModel;

namespace SOM.DAL.Configuration
{
    public class OrderWindowConfiguration : IEntityTypeConfiguration<OrderWindow>
    {
        public void Configure(EntityTypeBuilder<OrderWindow> builder)
        {
            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderWindow)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Window)
                .WithMany(x => x.OrderWindow)
                .HasForeignKey(x => x.WindowId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
