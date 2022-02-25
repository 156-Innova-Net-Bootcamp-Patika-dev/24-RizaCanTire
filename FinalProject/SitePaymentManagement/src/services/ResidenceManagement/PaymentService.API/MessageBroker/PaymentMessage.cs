using PaymentService.API.Models;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace PaymentService.API.MessageBroker
{
    public static class PaymentMessage
    {
        public static void Payment(bool payment)
        {
            var factory = new ConnectionFactory() { HostName = "localhost", UserName = "admin", Password = "123456" };
            using (IConnection connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(
                    queue: "checkPay",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);
                var customerPayload = JsonSerializer.Serialize(payment);

                var body = Encoding.UTF8.GetBytes(customerPayload);

                channel.BasicPublish(
                    exchange: "",
                    routingKey: "checkPay",
                    basicProperties: null,
                    body: body
                );
            }

        }
    }
}
