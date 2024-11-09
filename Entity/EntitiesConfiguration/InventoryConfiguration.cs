using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseAccountingBlazor.Entity.Entities;

namespace WarehouseAccountingBlazor.Entity.EntitiesConfiguration
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne<Warehouse>()
                .WithMany(w => w.Inventories)
                .HasForeignKey(i => i.WarehouseId)
                .IsRequired();
        
            builder
                .HasOne<Product>()
                .WithMany(p => p.Inventories)
                .HasForeignKey(i => i.ProductId)
                .IsRequired();
        }
    }
}
