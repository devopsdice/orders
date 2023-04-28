using Order.MessageBroker;
using Order.Model;
using Order.Repository;

namespace Order.Service
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IMessageBrokerService _messageBrokerService;
        public OrderService(IOrderRepository orderRepository, IMessageBrokerService messageBrokerService)
        {
            _orderRepository = orderRepository;
            _messageBrokerService = messageBrokerService;
        }
        public async Task AddOrderAsync(OrderData orderData)
        {
            orderData = await _orderRepository.SaveOrderAsync(orderData);
            _messageBrokerService.PublishMessage(orderData);
        }

        public async Task<int> UpdateOrderAsync(OrderData orderData)
        {
            return await _orderRepository.UpdateOrderAsync(orderData);
        }
    }
}
