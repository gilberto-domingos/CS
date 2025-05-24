using MassTransit;

namespace ApiRestFull.Bus;

internal interface IBusPublish
{
    Task publishAsync<T>(T message, CancellationToken ct = default) where T : class;
}

/// ////////////////////

internal class PublishBus : IBusPublish
{
    private readonly IPublishEndpoint _busEndPoint;

    public PublishBus(IPublishEndpoint publish)
    {
        _busEndPoint = publish;
    }
    
    public Task publishAsync<T>(T message, CancellationToken ct = default) where T : class
    {
        return _busEndPoint.Publish(message, ct);
    }
}