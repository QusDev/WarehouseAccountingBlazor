using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseAccountingBlazor.Entity.Entities;

namespace WarehouseAccountingBlazor.Entity.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(p => p.UnitPrice)
                .HasColumnType("decimal(10,2)");

            builder
                .HasOne<Category>()
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .IsRequired();

            builder
                .HasOne<Supply>()
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplyId)
                .IsRequired();
        }
    }
}
