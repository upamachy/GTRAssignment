using GTRAssignment.Data;
using GTRAssignment.Models;
using GTRAssignment.RepositoryData.IRepository;

namespace GTRAssignment.RepositoryData.Repository
{
    public class BrandRepository : CommonRepository<Brand>, IBrandRepository
    {

        public BrandRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
