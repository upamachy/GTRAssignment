using GTRAssignment.Models;
using GTRAssignment.RepositoryData.IRepository;
using GTRAssignment.RepositoryData.Repository;

namespace GTRAssignment.ServiceData
{
    public class GTRService : IGTRService
    {
        private readonly IProductRepository _productRepository;
        public GTRService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Add(Product product)
        {
            var AddProduct = await _productRepository.Add(product);

           
            return AddProduct;
        }

        public async Task<List<Product>> GetProducts()
        {
           var GetProductList= await _productRepository.GetAll();

            return GetProductList;

        }

       
    }
}
