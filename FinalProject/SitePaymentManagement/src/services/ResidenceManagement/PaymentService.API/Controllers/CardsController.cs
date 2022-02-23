﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PaymentService.API.Entities;
using PaymentService.API.MessageBroker;
using PaymentService.API.Models;
using PaymentService.API.Repositories;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PaymentService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly ICardRepository _cardRepository;
        private readonly ConnectionFactory factory;
        private readonly IConnection connection;

        public CardsController(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;

            factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "admin",
                Password = "123456"
            };

            connection = factory.CreateConnection();
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Card>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Card>>> GetAllCard()
        {
            var cards = await _cardRepository.GetAllCards();
            return Ok(cards);
        }

        [HttpGet("{id}", Name = "GetCard")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(Card), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Card>> GetCardById(int id)
        {
            var card = await _cardRepository.GetCardById(id);
            if (card == null)
            {
                return NotFound();
            }
            return Ok(card);
        }


        [HttpGet]
        [Route("CardNumber")]
        [ProducesResponseType(typeof(IEnumerable<Card>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Card>>> GetCardByCardNumber(int cardNumber)
        {
            var cards = await _cardRepository.GetCardByCardNumber(cardNumber);
            return Ok(cards);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Card), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Card>> AddCard([FromBody] Card card)
        {
            await _cardRepository.AddCard(card);

            return Ok(card);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Card), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateCard([FromBody] Card card)
        {
            return Ok(await _cardRepository.UpdateCard(card));
        }

        [HttpDelete("{id)}", Name = "DeleteCard")]
        [ProducesResponseType(typeof(Card), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteCardById(int id)
        {
            return Ok(await _cardRepository.DeleteCard(id));
        }


        [HttpPost]
        [Route("PaymentControl")]
        public IActionResult PaymentControl([FromQuery] PaymentModel paymentModel)
        {
            Message.SendMesage(paymentModel);
            return Ok();
        }

        [HttpPost]
        [Route("addRabbit")]
        public IActionResult AddRabbit([FromQuery] PaymentModel paymentModel)
        {
            var customer = new
            {
                Id = 1,
                Name = "customer",
                Email = "customer@customer.com"
            };

            using (var channel = this.connection.CreateModel())
            {
                channel.QueueDeclare(
                    queue: "customer1",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                );

                var customerPayload = System.Text.Json.JsonSerializer.Serialize(customer);

                var body = Encoding.UTF8.GetBytes(customerPayload);

                channel.BasicPublish(
                    exchange: "",
                    routingKey: "customer1",
                    basicProperties: null,
                    body: body
                );
            }

            return Ok(customer);
        }

    }
}
