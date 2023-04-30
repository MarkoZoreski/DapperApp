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
    public class ProductRepository
    {
        
        private readonly IDbConnection _dbConnection;

        public ProductRepository(string connectionString)
        {
            _dbConnection = new SqlConnection(connectionString);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var query = "SELECT * FROM Product";
            var products = await _dbConnection.QueryAsync<Product>(query);
            return products;
        }

        public async Task<IEnumerable<Product>> GetMostSoldProducts()
        {
            var query = @"
            SELECT p.*, SUM(od.Quantity) AS TotalQuantity
            FROM Product p
            INNER JOIN OrderDetails od ON p.ProductID = od.ProductID
            GROUP BY p.ProductID, p.ProductName, p.CategoryID, p.QuantityPerUnit, p.UnitPrice,
                p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued, p.LastUserId, p.LastDateUpdated, p.SupplierID
            ORDER BY TotalQuantity DESC";
            var products = await _dbConnection.QueryAsync<Product>(query);
            return products;
        }

        public async Task<int> CreateProduct(Product product)
        {
            var query = @"
            INSERT INTO Product (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice,
                UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, LastUserId, LastDateUpdated)
            VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice,
                @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued, @LastUserId, @LastDateUpdated);
            SELECT CAST(SCOPE_IDENTITY() AS INT)";
            var productId = await _dbConnection.QuerySingleOrDefaultAsync<int>(query, product);
            return productId;
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            var query = @"
            UPDATE Product
            SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID,
                QuantityPerUnit = @QuantityPerUnit, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock,
                UnitsOnOrder = @UnitsOnOrder, ReorderLevel = @ReorderLevel, Discontinued = @Discontinued,
                LastUserId = @LastUserId, LastDateUpdated = @LastDateUpdated
            WHERE ProductID = @ProductID";
            var rowsAffected = await _dbConnection.ExecuteAsync(query, product);
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var query = "DELETE FROM Product WHERE ProductID = @ProductID";
            var rowsAffected = await _dbConnection.ExecuteAsync(query, new { ProductID = productId });
            return rowsAffected > 0;
        }
    }

}
