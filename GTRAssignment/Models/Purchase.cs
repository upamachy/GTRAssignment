namespace GTRAssignment.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SupplierId { get; set; }
        public Supplier PurchaseSupplier { get; set; }
        public int TotalPurchase { get; set; }
        public DateTime LastPurchaseDate { get; set; }
    }

}
