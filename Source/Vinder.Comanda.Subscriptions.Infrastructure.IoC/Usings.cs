global using System.Diagnostics.CodeAnalysis;

global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;

global using Vinder.Comanda.Subscriptions.Domain.Repositories;
global using Vinder.Comanda.Subscriptions.Domain.Concepts;

global using Vinder.Comanda.Subscriptions.CrossCutting.Configurations;
global using Vinder.Comanda.Subscriptions.CrossCutting.Exceptions;

global using Vinder.Comanda.Subscriptions.Application.Gateways;
global using Vinder.Comanda.Subscriptions.Application.Handlers.Traceability;
global using Vinder.Comanda.Subscriptions.Application.Payloads.Subscription;
global using Vinder.Comanda.Subscriptions.Application.Validators.Subscription;

global using Vinder.Comanda.Subscriptions.Infrastructure.Gateways;
global using Vinder.Comanda.Subscriptions.Infrastructure.Repositories;

global using Vinder.Internal.Essentials.Contracts;
global using Vinder.Internal.Infrastructure.Persistence.Repositories;

global using Vinder.Dispatcher.Extensions;

global using Stripe;
global using MongoDB.Driver;
global using FluentValidation;
