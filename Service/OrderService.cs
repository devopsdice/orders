using Order.MessageBroker;
using Order.Model;
using Order.Repository;

namespace Order.Service
{
    public class OrderService:IOrderService
    {
        private IOrderRepository _orderRepository;
        private IMessageBrokerService _messageBrokerService;
        public OrderService(IOrderRepository orderRepository, IMessageBrokerService messageBrokerService)
        {
            _orderRepository = orderRepository;
            _messageBrokerService = messageBrokerService;
        }
        public void AddOrder(OrderData orderData)
        {
            _orderRepository.SaveOrder(orderData);
            _messageBrokerService.PublishMessage(orderData);
        }
    }
}
