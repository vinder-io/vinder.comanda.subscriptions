namespace Vinder.Comanda.Subscriptions.Application.Payloads.Subscription;

public sealed record SubscriptionCancelationScheme :
    IMessage<Result<SubscriptionScheme>>
{
    [property: JsonIgnore]
    public string SubscriptionId { get; init; } = default!;
}