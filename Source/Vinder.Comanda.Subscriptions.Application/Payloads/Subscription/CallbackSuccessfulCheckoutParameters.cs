namespace Vinder.Comanda.Subscriptions.Application.Payloads.Subscription;

public sealed record CallbackSuccessfulCheckoutParameters : IMessage<Result<SubscriptionScheme>>
{
    public string SessionId { get; init; } = default!;
}