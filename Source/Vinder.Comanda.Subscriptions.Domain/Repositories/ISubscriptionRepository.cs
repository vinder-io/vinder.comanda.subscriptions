namespace Vinder.Comanda.Subscriptions.Domain.Repositories;

public interface ISubcriptionRepository : IBaseRepository<Subscription>
{
    public Task<IReadOnlyCollection<Subscription>> GetSubscriptionsAsync(
        SubscriptionFilters filters,
        CancellationToken cancellation = default
    );

    public Task<long> CountSubscriptionsAsync(
        SubscriptionFilters filters,
        CancellationToken cancellation = default
    );
}