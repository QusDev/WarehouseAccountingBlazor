using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseAccountingBlazor.Entity.Entities;

namespace WarehouseAccountingBlazor.Entity.EntitiesConfiguration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .Property(t => t.TransactionType)
                .HasConversion<string>();

            builder
                .HasMany(t => t.Employees)
                .WithMany(e => e.Transactions)
                .UsingEntity("Transaction_Employees");
        }
    }
}
