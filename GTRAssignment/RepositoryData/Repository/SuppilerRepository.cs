using GTRAssignment.Data;
using GTRAssignment.Models;
using GTRAssignment.RepositoryData.IRepository;

namespace GTRAssignment.RepositoryData.Repository
{
    public class SuppilerRepository : CommonRepository<Supplier>, ISuppilerRepository
    {

        public SuppilerRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
