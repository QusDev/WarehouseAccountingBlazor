﻿namespace WarehouseAccountingBlazor.Entity.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
    }
}
