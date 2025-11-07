namespace Vinder.Comanda.Subscriptions.Application.Payloads.Subscription;

public sealed record CheckoutSessionCreationScheme : IMessage<Result<CheckoutSession>>
{
    public Plan Plan { get; init; } = Plan.None;
    public User Subscriber { get; init; } = default!;
    public CallbacksScheme Callbacks { get; init; } = default!;
}