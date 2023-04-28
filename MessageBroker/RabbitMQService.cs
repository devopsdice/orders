namespace Order.MessageBroker
{
    using Newtonsoft.Json;
    using Order.MessageBroker;
    using Order.Model;
    using RabbitMQ.Client;
    using System.Text;

    public class RabbitMQService: IMessageBrokerService
    {
        private ConnectionFactory connectionFactory;
        private IConnection connection;
        private IModel model;
        public RabbitMQService()
        {
            connectionFactory = new ConnectionFactory
            {
                Uri =
                new Uri("amqp://guest:guest@34.121.163.121:5672/")
            };
            connection = connectionFactory.CreateConnection();
            model = connection.CreateModel();
             
           
        }
        public void PublishMessage(OrderData orderData)
        {
            model.BasicPublish("Order", "",null, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(orderData)));
        }

    }
}
