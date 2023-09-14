using GTRAssignment.Models;

namespace GTRAssignment.ServiceData
{
    public interface IGTRService
    {
        Task<List<Product>> GetProducts();
        Task<Product> Add(Product product);
    }
}
