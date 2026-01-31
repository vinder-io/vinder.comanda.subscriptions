global using System.Net;
global using System.Net.Http.Json;
global using System.Text.Json;

global using Microsoft.AspNetCore.Mvc.Testing;
global using Microsoft.Extensions.DependencyInjection;

global using Vinder.Comanda.Subscriptions.WebApi;
global using Vinder.Comanda.Subscriptions.Domain.Collections;
global using Vinder.Comanda.Subscriptions.Domain.Aggregates;
global using Vinder.Comanda.Subscriptions.Domain.Concepts;
global using Vinder.Comanda.Subscriptions.Domain.Errors;

global using Vinder.Comanda.Subscriptions.Application.Payloads;
global using Vinder.Comanda.Subscriptions.Application.Gateways;
global using Vinder.Comanda.Subscriptions.Application.Payloads.Subscription;

global using Vinder.Comanda.Subscriptions.TestSuite.Fixtures;
global using Vinder.Comanda.Subscriptions.TestSuite.Mocks;

global using Vinder.Internal.Essentials.Patterns;

global using MongoDB.Driver;
global using DotNet.Testcontainers.Builders;
global using DotNet.Testcontainers.Containers;
global using AutoFixture;
