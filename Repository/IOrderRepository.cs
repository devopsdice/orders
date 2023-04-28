namespace Order.Repository
{
    using Model;
    public interface IOrderRepository
    {
        Task<OrderData> SaveOrderAsync(OrderData orderData);
        Task<int> UpdateOrderAsync(OrderData orderData);
    }
}
