using ApiRestFull.Relatorios;
using MassTransit;

namespace ApiRestFull.Bus;

internal sealed class RelatorioSolicitadoEnventConsumer : IConsumer<RelatorioSolicitadoEvent>
{
    public RelatorioSolicitadoEnventConsumer(ILogger<RelatorioSolicitadoEnventConsumer> logger)
    {
        _logger = logger;
    }
    
    private readonly ILogger<RelatorioSolicitadoEnventConsumer> _logger;
    
    public async Task Consume(ConsumeContext<RelatorioSolicitadoEvent> context)
    {
        var message = context.Message;
        
       _logger.LogInformation("Processando relatório Id:{Id}, Nome:{Nome}", message.Id, message.Name);

       await Task.Delay(10000);

       var relatorio = Lista.Relatorios.FirstOrDefault(r => r.Id == message.Id);
       _logger.LogInformation("Relatório processado Id:{Id}, Nome:{Nome}", message.Id, message.Name);

       if (relatorio != null)
       {
           relatorio.Status = "Processo completado !";
           relatorio.ProcessedTime = DateTime.Now;
       }
    }
}