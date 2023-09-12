using GTRAssignment.Models;

namespace GTRAssignment.ServiceData
{
    public interface IGTRService
    {
        Task<List<Category>> GetCategories();
    }
}
