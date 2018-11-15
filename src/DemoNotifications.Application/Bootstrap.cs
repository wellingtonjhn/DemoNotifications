using DemoNotifications.Core.Notifications;
using DemoNotifications.Domain.Contracts;
using DemoNotifications.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DemoNotifications.Application
{
    public static class Bootstrap
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR();

            services.AddSingleton<InMemoryDatabaseContext>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<NotificationContext>();

            return services;
        }
    }
}
