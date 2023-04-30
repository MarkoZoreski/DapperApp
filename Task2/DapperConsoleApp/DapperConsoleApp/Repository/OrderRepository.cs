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
    public class OrderRepository
    {
        
        private readonly IDbConnection _dbConnection;

        public OrderRepository(string connectionString)
        {
            _dbConnection = new SqlConnection(connectionString);
        }

        public async Task<int> CreateOrder(Order order)
        {
            var query = @"
            INSERT INTO [Order] 
            (
                CustomerID,
                EmployeeID,
                OrderDate,
                RequiredDate,
                ShippedDate,
                ShipVia,
                Freight,
                ShipName,
                ShipAddress,
                ShipCity,
                ShipRegion,
                ShipPostalCode,
                ShipCountry
            )
            VALUES 
            (
                @CustomerID,
                @EmployeeID,
                @OrderDate,
                @RequiredDate,
                @ShippedDate,
                @ShipVia,
                @Freight,
                @ShipName,
                @ShipAddress,
                @ShipCity,
                @ShipRegion,
                @ShipPostalCode,
                @ShipCountry
            );
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            var orderId = await _dbConnection.QuerySingleAsync<int>(query, order);
            return orderId;
        }

        public async Task<IEnumerable<Order>> GetOrdersSortedByDate()
        {
            var query = @"
            SELECT OrderID,OrderDate FROM [Order]
            ORDER BY OrderDate DESC";

            var orders = await _dbConnection.QueryAsync<Order>(query);
            return orders;
        }

        public async Task<int> CreateOrderDetails(OrderDetails orderDetails)
        {
            var query = @"
            INSERT INTO OrderDetails
            (
                OrderID,
                ProductID,
                UnitPrice,
                Quantity,
                Discount
            )
            VALUES
            (
                @OrderID,
                @ProductID,
                @UnitPrice,
                @Quantity,
                @Discount
            );
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            var orderDetailsId = await _dbConnection.QuerySingleAsync<int>(query, orderDetails);
            return orderDetailsId;
        }

        public async Task<IEnumerable<OrderDetails>> GetOrderDetailsByOrderId(int orderId)
        {
            var query = @"
            SELECT * FROM OrderDetails
            WHERE OrderID = @OrderId";

            var orderDetails = await _dbConnection.QueryAsync<OrderDetails>(query, new { OrderId = orderId });
            return orderDetails;
        }
    }

}
