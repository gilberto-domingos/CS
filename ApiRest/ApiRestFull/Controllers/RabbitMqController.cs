using ApiRestFull.Bus;
using ApiRestFull.Relatorios;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestFull.Controllers;

[ApiController]
[Route("api/[Controller]")]
internal static class RabbitMqController
{
    public static void AddEndPointRabbit(this WebApplication app)
    {
        app.MapPost("solicitar-relatorio/{name}", async (string name, IBusPublish bus, CancellationToken ct = default) =>
        {
            var solicitacao = new SolicitacaoRelatorios()
            {
                Id = Guid.NewGuid(),
                Nome = name,
                Status = "Pendente",
                ProcessedTime = null
            };
            
            //Simulação: salvando no banco
            Lista.Relatorios.Add(solicitacao);

            var eventRequest = new RelatorioSolicitadoEvent(solicitacao.Id, solicitacao.Nome);

            await bus.publishAsync(eventRequest, ct);

            return Results.Ok(solicitacao);
        });

        app.MapGet("relatorios", () => Lista.Relatorios);
    }
}