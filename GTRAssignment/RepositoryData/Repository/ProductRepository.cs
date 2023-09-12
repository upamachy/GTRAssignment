using GTRAssignment.Data;
using GTRAssignment.Models;
using GTRAssignment.RepositoryData.IRepository;

namespace GTRAssignment.RepositoryData.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepository
    {

        public ProductRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
