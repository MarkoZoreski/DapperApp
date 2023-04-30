using DapperConsoleApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperConsoleApp.Repository
{
    public interface IProductRepository
    {
        Task<int> CreateProduct(Product product);
        Task<bool> DeleteProduct(int productId);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<IEnumerable<Product>> GetMostSoldProducts();
        Task<bool> UpdateProduct(Product product);
    }
}