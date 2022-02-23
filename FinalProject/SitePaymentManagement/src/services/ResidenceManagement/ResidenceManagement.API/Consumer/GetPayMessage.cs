using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ResidenceManagement.API.Model;
using System.Text;

namespace ResidenceManagement.API.Consumer
{
    public static class GetPayMessage
    {
        public static PaymentReturnModel GetMessage()
        {
            var factory = new ConnectionFactory() { HostName = "localhost", UserName = "admin", Password = "123456" };
            var getingPayment = new PaymentReturnModel();

            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                //TODO: Received methoduyla gelen dataları yakalayıp işlem yapacağımız için EventingBasicConsumer classından nesne alıyoruz.
                var consumer = new EventingBasicConsumer(channel);
                //TODO: Yeni data geldiğinde bu event otomatik tetikleniyor.
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;//TODO: Kuyruktaki içerik bilgisi.
                    var message = Encoding.UTF8.GetString(body);//TODO: Gelen bodyi stringe çeviriyoruz.
                    getingPayment = JsonConvert.DeserializeObject<PaymentReturnModel>(message); //TODO: Mesajdan dönen veriyi classa çeviriyoruz.
                    //context.Send(sendingEftModel);//TODO: Contextimize gönderip Database.json dosyamıza kaydedilmesini sağlıyoruz.
                    //Console.WriteLine($" {sendingEftModel.FromId} - {sendingEftModel.Money}₺ --> {sendingEftModel.ToId}");
                };
                channel.BasicConsume(queue: "customer1", //TODO: Consume edilecek kuyruk ismi
                    autoAck: true, //TODO: Kuyruk ismi doğrulansın mı
                    consumer: consumer); //TODO: Hangi consumer kullanılacak.


            }
            return getingPayment;
        }
    }
}
