namespace GTRAssignment.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Define a navigation property to represent the relationship with Purchases
        public List<Purchase> Purchases { get; set; }
    }

}
