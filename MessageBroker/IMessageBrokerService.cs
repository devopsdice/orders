using Order.Model;

namespace Order.MessageBroker
{
    public interface IMessageBrokerService
    {
        void PublishMessage(OrderData orderData);
    }
}
