using GTRAssignment.Data;
using GTRAssignment.Models;
using GTRAssignment.RepositoryData.IRepository;

namespace GTRAssignment.RepositoryData.Repository
{
    public class SaleRepository : CommonRepository<Sales>, ISaleRepository
    {

        public SaleRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
