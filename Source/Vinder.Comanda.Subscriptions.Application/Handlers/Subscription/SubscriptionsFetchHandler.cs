namespace Vinder.Comanda.Subscriptions.Application.Handlers.Subscription;

public sealed class SubscriptionsFetchHandler(ISubcriptionRepository repository) :
    IMessageHandler<SubscriptionsFetchParameters, Result<PaginationScheme<SubscriptionScheme>>>
{
    public async Task<Result<PaginationScheme<SubscriptionScheme>>> HandleAsync(
        SubscriptionsFetchParameters parameters, CancellationToken cancellation = default)
    {
        var filters = SubscriptionFilters.WithSpecifications()
            .WithIdentifier(parameters.Id)
            .WithSubscriberId(parameters.SubscriberId)
            .WithExternalId(parameters.ExternalId)
            .WithPlan(parameters.Plan)
            .WithStatus(parameters.Status)
            .WithPagination(parameters.Pagination)
            .WithSort(parameters.Sort)
            .Build();

        var subscriptions = await repository.GetSubscriptionsAsync(filters, cancellation);
        var totalCount = await repository.CountSubscriptionsAsync(filters, cancellation);

        var pagination = new PaginationScheme<SubscriptionScheme>
        {
            Items = [.. subscriptions.Select(subscription => subscription.AsResponse())],
            Total = (int)totalCount,
            PageNumber = parameters.Pagination.PageNumber,
            PageSize = parameters.Pagination.PageSize,
        };

        return Result<PaginationScheme<SubscriptionScheme>>.Success(pagination);
    }
}