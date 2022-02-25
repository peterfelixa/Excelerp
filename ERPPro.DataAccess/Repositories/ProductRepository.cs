using Dapper;
using ERPPro.DataAccess.Interfaces;
using ERPPro.Domain;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace ERPPro.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ILogger<ProductRepository> _logger;
        public ProductRepository(ILogger<ProductRepository> logger)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            _logger.LogInformation("Entered GetAllProducts method ...");
            IEnumerable<Product> products = new List<Product>();
             products = await ReadAllProdutcs();
            return products;
        }

        private async Task<IEnumerable<Product>> ReadAllProdutcs()
        {
            IEnumerable<Product> products = new List<Product>();   
            try
            {
                using (var sqlConnection = new SqlConnection("Server=localhost;Database=ERPPro;User Id=sa;Password=sa;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True"))
                {
                    sqlConnection.Open();
                    string query = $"spGetAllProducts";
                    var resultProducts = await sqlConnection.QueryAsync<Product>
                        (query, param: null, commandType: System.Data.CommandType.StoredProcedure);
                    products = (IEnumerable<Product>)resultProducts;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception at method ReadAllProdutcs : {ex.ToString()}");
            }
            return products;
        }
    }
}
