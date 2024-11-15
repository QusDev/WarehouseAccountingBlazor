using WarehouseAccountingBlazor.Entity.Enums;

namespace WarehouseAccountingBlazor.Entity.Entities
{
    public class Transaction : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; } 
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; } = null!;
        public List<Employee> Employees { get; set; } = [];
    }
}
