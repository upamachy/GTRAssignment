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

        [HttpGet(Name = "GetProductList")]
        public async Task<ActionResult<List<Product>>> GetProductList()
        {
            return await _GTRService.GetProducts();
        }

        [HttpPost(Name ="CreateProduct")]

        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            var createdProduct = await _GTRService.Add(product);

            return CreatedAtRoute("GetProductList", new { id = createdProduct.Id }, createdProduct);
        }
    }
}
