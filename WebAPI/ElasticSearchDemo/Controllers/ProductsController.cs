using ElasticSearchDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nest;

namespace ElasticSearchDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IElasticClient _elasticClient;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(
                            IElasticClient elasticClient,
                            ILogger<ProductsController> logger)
        {
            _logger = logger;
            _elasticClient = elasticClient;
        }

        [HttpGet(Name = "GetAllProducts")]
        public async Task<IActionResult> Get(string keyword)
        {
            var result = await _elasticClient.SearchAsync<Product>(
                             s => s.Query(
                                 q => q.QueryString(
                                     d => d.Query('*' + keyword + '*')
                                 )).Size(5000));

            _logger.LogInformation("ProductsController Get - ", DateTime.UtcNow);
            return Ok(result.Documents.ToList());
        }

        [HttpPost(Name = "AddProduct")]
        public async Task<IActionResult> Post([FromBody]Product product)
        {
            await _elasticClient.IndexDocumentAsync(product);

            _logger.LogInformation("ProductsController Get - ", DateTime.UtcNow);
            return Ok();
        }
    }   
}
