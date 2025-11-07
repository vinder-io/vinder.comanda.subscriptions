namespace Vinder.Comanda.Subscriptions.Infrastructure.Repositories;

public sealed class SubscriptionRepository(IMongoDatabase database) :
    BaseRepository<Subscription>(database, Collections.Subscriptions),
    ISubcriptionRepository
{
    public async Task<IReadOnlyCollection<Subscription>> GetSubscriptionsAsync(
        SubscriptionFilters filters, CancellationToken cancellation = default)
    {
        var pipeline = PipelineDefinitionBuilder
            .For<Subscription>()
            .As<Subscription, Subscription, BsonDocument>()
            .FilterSubscriptions(filters)
            .Paginate(filters.Pagination)
            .Sort(filters.Sort);

        var options = new AggregateOptions { AllowDiskUse = true };
        var aggregation = await _collection.AggregateAsync(pipeline, options, cancellation);

        var bsonDocuments = await aggregation.ToListAsync(cancellation);
        var subscriptions = bsonDocuments
            .Select(bson => BsonSerializer.Deserialize<Subscription>(bson))
            .ToList();

        return subscriptions;
    }

    public async Task<long> CountSubscriptionsAsync(
        SubscriptionFilters filters, CancellationToken cancellation = default)
    {
        var pipeline = PipelineDefinitionBuilder
            .For<Subscription>()
            .As<Subscription, Subscription, BsonDocument>()
            .FilterSubscriptions(filters)
            .Count();

        var aggregation = await _collection.AggregateAsync(pipeline, cancellationToken: cancellation);
        var result = await aggregation.FirstOrDefaultAsync(cancellation);

        return result?.Count ?? 0;
    }
}