namespace GTRAssignment.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int? BrandId { get; set; }
        public Brand Brand { get; set; }
        public string UnitName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ProductBarcode { get; set; }
        public string Description { get; set; }
        public string SizeName { get; set; }
        public string ColorName { get; set; }
        public string ModelName { get; set; }
        public string VariantName { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Price { get; set; }
        public decimal CostPrice { get; set; }
        public List<Warehouse> WarehouseList { get; set; }
        public int Stock { get; set; }
        public string ImagePath { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public decimal CommissionAmount { get; set; }
        public decimal CommissionPer { get; set; }
        public decimal PCTN { get; set; }

        // Define navigation properties for relationships
        public List<Purchase> Purchases { get; set; }
        public List<Sales> Sales { get; set; }
    }

}
