using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ResidenceManagement.API.Model;
using System.Text;

namespace ResidenceManagement.API.Consumer
{
    public static class GetPayMessage
    {
        public static string GetMessage()
        {
            var factory = new ConnectionFactory() { HostName = "localhost", UserName = "admin", Password = "123456" };
            string getingPayment = "1";

            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    getingPayment = JsonConvert.DeserializeObject(message).ToString();
                    
                };
                channel.BasicConsume(queue: "payment", 
                    autoAck: true, 
                    consumer: consumer);
                return getingPayment;

            }
           
        }
    }
}
