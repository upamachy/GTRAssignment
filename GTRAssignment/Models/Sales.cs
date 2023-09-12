namespace GTRAssignment.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int TotalSales { get; set; }
        public DateTime LastSalesDate { get; set; }
        public string LastSalesCustomer { get; set; }
    }

}
