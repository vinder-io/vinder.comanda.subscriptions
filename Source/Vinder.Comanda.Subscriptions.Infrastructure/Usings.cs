global using Vinder.Internal.Infrastructure.Persistence;
global using Vinder.Internal.Infrastructure.Persistence.Pipelines;

global using Vinder.Comanda.Subscriptions.Domain.Aggregates;
global using Vinder.Comanda.Subscriptions.Domain.Filtering;
global using Vinder.Comanda.Subscriptions.Domain.Collections;
global using Vinder.Comanda.Subscriptions.Domain.Concepts;
global using Vinder.Comanda.Subscriptions.Domain.Errors;

global using Vinder.Internal.Essentials.Patterns;
global using Vinder.Comanda.Subscriptions.CrossCutting.Extensions;

global using Vinder.Comanda.Subscriptions.Application.Gateways;
global using Vinder.Comanda.Subscriptions.Application.Payloads.Subscription;

global using Vinder.Comanda.Subscriptions.Infrastructure.Constants;
global using Vinder.Comanda.Subscriptions.Infrastructure.Pipelines;
global using Vinder.Comanda.Subscriptions.Infrastructure.Gateways.Mappers;

global using MongoDB.Driver;
global using MongoDB.Bson;
global using MongoDB.Bson.Serialization;
global using Stripe.Checkout;
