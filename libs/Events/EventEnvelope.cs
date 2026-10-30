using System;

public class EventEnvelope<T>
{
    public Guid EventId { get; set; }

    public string EventType { get; set; }

    public Guid TenantId { get; set; }

    public Guid CorrelationId { get; set; }

    public T Payload { get; set; }
}
