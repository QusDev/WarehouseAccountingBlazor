using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseAccountingBlazor.Entity.Entities;

namespace WarehouseAccountingBlazor.Entity.EntitiesConfiguration
{
    public class SupplyConfiguration : IEntityTypeConfiguration<Supply>
    {
        public void Configure(EntityTypeBuilder<Supply> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
