namespace WarehouseAccountingBlazor.Entity.Entities
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;
        public ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
        public List<Product> Products { get; set; } = [];
    }
}
