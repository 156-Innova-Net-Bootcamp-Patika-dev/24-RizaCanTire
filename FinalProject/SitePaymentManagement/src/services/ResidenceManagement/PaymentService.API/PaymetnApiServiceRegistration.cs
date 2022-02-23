using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentService.API.Data.Persistence;
using PaymentService.API.Repositories;

namespace PaymentService.API
{
    public static class PaymetnApiServiceRegistration
    {
        public static IServiceCollection AddPaymentApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICardContext, CardContext>();
            services.AddScoped<ICardRepository, CardRepository>();

            return services;
        }
    }
}
