using Order.Model;

namespace Order.Service
{
    public interface IOrderService
    {
        void AddOrder(OrderData orderData);
    }
}
