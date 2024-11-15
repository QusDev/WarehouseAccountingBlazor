namespace WarehouseAccountingBlazor.Entity.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int SupplyId { get; set; }
        public ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
        public List<Warehouse> Warehouses { get; set; } = [];  
    }
}
