using DapperConsoleApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperConsoleApp.Repository
{
    public interface ICategoryRepository
    {
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<IEnumerable<Category>> GetCategoriesSortedByMostSoldProductsAsync();
        Task<int> InsertAsync(Category category);
        Task<bool> UpdateAsync(Category category);
    }
}