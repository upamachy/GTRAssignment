using GTRAssignment.Models;
using GTRAssignment.RepositoryData.IRepository;
using GTRAssignment.ServiceData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTRAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GTRController : ControllerBase
    {
        private readonly IGTRService _GTRService;
        public GTRController(IGTRService GTRService)
        {
            _GTRService = GTRService;
        }

        [HttpGet(Name = "GetCategoryList")]
        public async Task<ActionResult<List<Category>>> GetCategoryList()
        {
            return await _GTRService.GetCategories();
        }
    }
}
