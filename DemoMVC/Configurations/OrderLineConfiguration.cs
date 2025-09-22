using DemoMVC.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoMVC.Configurations
{
    public class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.HasKey(ol => ol.Id);

            builder.HasOne(ol => ol.Product).WithMany(p => p.OrderLines)
                .HasForeignKey(p => p.ProductRef).IsRequired();

            builder.HasOne(ol => ol.Order).WithMany(o => o.OrderLines)
                .HasForeignKey(p => p.OrderRef).IsRequired();
        }
    }
}
