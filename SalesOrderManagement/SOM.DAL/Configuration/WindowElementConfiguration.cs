using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOM.Core.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.DAL.Configuration
{
    public class WindowElementConfiguration : IEntityTypeConfiguration<WindowElement>
    {
        public void Configure(EntityTypeBuilder<WindowElement> builder)
        {
            builder.HasOne(x=> x.Window)
                .WithMany(x => x.WindowElement)
                .HasForeignKey(x => x.WindowId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Element)
                .WithMany(x => x.WindowElement)
                .HasForeignKey(x => x.ElementId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
