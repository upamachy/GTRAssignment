using GTRAssignment.Data;
using GTRAssignment.Models;
using GTRAssignment.RepositoryData.IRepository;

namespace GTRAssignment.RepositoryData.Repository
{
    public class CategoryRepository : CommonRepository<Category>, ICategoryRepository
    {

        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
