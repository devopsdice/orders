using Order.Model;

namespace Order.Service
{
    public interface IOrderService
    {
        Task AddOrderAsync(OrderData orderData);
        Task<int> UpdateOrderAsync(OrderData orderData);
    }
}
