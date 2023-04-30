using Dapper;
using DapperConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DapperConsoleApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DapperDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly IDbConnection _dbConnection;

        public CategoryRepository()
        {
            _dbConnection = new SqlConnection(connectionString);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _dbConnection.QueryAsync<Category>("SELECT * FROM Category");
            return categories;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            var category = await _dbConnection.QuerySingleOrDefaultAsync<Category>("SELECT * FROM Category WHERE CategoryID = @Id", new { Id = id });
            return category;
        }

        public async Task<int> InsertAsync(Category category)
        {
            var query = @"INSERT INTO Category (CategoryName, Description, Picture)
                       VALUES (@CategoryName, @Description, @Picture); 
                       SELECT CAST(SCOPE_IDENTITY() as int)";
            var id = await _dbConnection.QuerySingleAsync<int>(query, category);
            return id;
        }

        public async Task<bool> UpdateAsync(Category category)
        {
            var query = @"UPDATE Category 
                        SET CategoryName = @CategoryName, Description = @Description, Picture = @Picture 
                        WHERE CategoryID = @CategoryID";
            var rowsAffected = await _dbConnection.ExecuteAsync(query, category);
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var query = "DELETE FROM Category WHERE CategoryID = @Id";
            var rowsAffected = await _dbConnection.ExecuteAsync(query, new { Id = id });
            return rowsAffected > 0;
        }

        public async Task<IEnumerable<Category>> GetCategoriesSortedByMostSoldProductsAsync()
        {
            var query = @"
                SELECT 
                    c.*,
                    SUM(od.Quantity) AS TotalQuantitySold
                FROM 
                    Category c
                    JOIN Product p ON c.CategoryID = p.CategoryID
                    JOIN OrderDetails od ON p.ProductID = od.ProductID
                    JOIN [Order] o ON od.OrderID = o.OrderID
                GROUP BY
                    c.CategoryID,
                    c.CategoryName,
                    c.Description,
                    c.Picture
                ORDER BY
                    TotalQuantitySold DESC";

            var categories = await _dbConnection.QueryAsync<Category>(query);
            return categories;
        }
    }
}
