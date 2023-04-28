namespace Order.Repository
{
    using Model;
    public interface IOrderRepository
    {
        void SaveOrder(OrderData orderData);
    }
}
