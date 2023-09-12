using GTRAssignment.Data;
using GTRAssignment.Models;
using GTRAssignment.RepositoryData.IRepository;

namespace GTRAssignment.RepositoryData.Repository
{
    public class WarehouseRepository : CommonRepository<Warehouse>, IWarehouseRepository
    {

        public WarehouseRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
