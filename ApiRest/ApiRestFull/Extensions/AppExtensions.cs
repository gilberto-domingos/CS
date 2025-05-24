using ApiRestFull.Bus;
using MassTransit;

namespace ApiRestFull.Extensions;

internal static class AppExtensions
{
    public static void AddRabbitMqService(this IServiceCollection services)
    {
        services.AddTransient<IBusPublish, PublishBus>();
        
        services.AddMassTransit(busConfigurator =>
        {
            busConfigurator.AddConsumer<RelatorioSolicitadoEnventConsumer>();
            
            busConfigurator.UsingRabbitMq((ctx, cfg) =>
            {
               cfg.Host(new Uri("amqp://localhost:5672"), host =>
               {
                   host.Username("mmss");
                   host.Password("mmssmmnn");
               });
               
               cfg.ConfigureEndpoints(ctx);
               
            });
        });
    }
}