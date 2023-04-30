using DapperConsoleApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperConsoleApp.Repository
{
    public interface IOrderRepository
    {
        Task<int> CreateOrderAsync(Order order);
        Task<int> CreateOrderDetailsAsync(OrderDetails orderDetails);
        Task<IEnumerable<OrderDetails>> GetOrderDetailsByOrderIdAsync(int orderId);
        Task<IEnumerable<Order>> GetOrdersSortedByDateAsync();
    }
}