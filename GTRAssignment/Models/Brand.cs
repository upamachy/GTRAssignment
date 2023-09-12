namespace GTRAssignment.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Define a navigation property to represent the relationship with Products
        public List<Product> Products { get; set; }
    }
}
