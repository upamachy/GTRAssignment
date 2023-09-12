using GTRAssignment.Models;
using GTRAssignment.RepositoryData.IRepository;

namespace GTRAssignment.ServiceData
{
    public class GTRService : IGTRService
    {
        private readonly ICategoryRepository _categoryRepository;
        public GTRService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<Category>> GetCategories()
        {
           var GetCategoryList= await _categoryRepository.GetAll();

            return GetCategoryList;

        }
    }
}
