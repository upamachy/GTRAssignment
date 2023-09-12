using GTRAssignment.Data;
using GTRAssignment.Models;
using GTRAssignment.RepositoryData.IRepository;

namespace GTRAssignment.RepositoryData.Repository
{
    public class PurchaseRepository : CommonRepository<Purchase>, IPurchaseRepository
    {

        public PurchaseRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
