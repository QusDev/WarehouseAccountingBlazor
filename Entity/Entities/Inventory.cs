namespace WarehouseAccountingBlazor.Entity.Entities
{
    public class Inventory : IEntity
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
    }
}
