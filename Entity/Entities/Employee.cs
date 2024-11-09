namespace WarehouseAccountingBlazor.Entity.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Phone { get; set; } = null!; 
        public string Email { get; set; } = null!;
        public List<Transaction> Transactions { get; set; } = [];
    }
}
