namespace Vinder.Comanda.Subscriptions.Domain.Entities;

public sealed class Subscription : Entity
{
    public Plan Plan { get; set; } = Plan.None;
    public Status Status { get; set; } = Status.None;
    public User Subscriber { get; set; } = default!;
    public SubscriptionMetadata Metadata { get; set; } = SubscriptionMetadata.None;
}