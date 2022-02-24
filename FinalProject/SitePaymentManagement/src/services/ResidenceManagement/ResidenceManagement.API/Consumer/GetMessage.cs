using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Linq;
using System.Text;

namespace ResidenceManagement.API.Consumer
{
    public static class GetMessage
    {
        public static string CheckPayment()
        {
            ConnectionFactory factory = new ConnectionFactory() { HostName = "localhost", UserName = "admin", Password = "123456" };
            var returnItem = "";
            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
                channel.BasicConsume("payment", false, consumer);
                consumer.Received += (sender, e) =>
                {

                    var body = e.Body.ToArray();
                    var jsonString = Encoding.UTF8.GetString(body);
                    returnItem = jsonString;
                   

                    channel.BasicAck(e.DeliveryTag, false);
                };
                return returnItem;
                //using (IConnection connection = factory.CreateConnection())
                //using (IModel channel = connection.CreateModel())
                //{
                //    channel.QueueDeclare("customer", durable: true, false, false, null);
                //    channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

                //    EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
                //    channel.BasicConsume("customer", false, consumer);
                //    consumer.Received += (sender, e) =>
                //    {
                //        returnITem = Encoding.UTF8.GetString(e.Body.ToArray());
                //        channel.BasicAck(e.DeliveryTag, false);
                //    };

                //    return returnITem;

                }
            }
    }
}
