/* global using for System namespaces here */

global using System.Net;
global using System.Net.Http.Json;

global using System.Text;
global using System.Text.Json;

/* global using for Microsoft namespaces here */

global using Microsoft.AspNetCore.Mvc.Testing;
global using Microsoft.Extensions.DependencyInjection;

/* global using for Vinder namespaces here */

global using Vinder.Comanda.Subscriptions.WebApi;

global using Vinder.Comanda.Subscriptions.Domain.Repositories;
global using Vinder.Comanda.Subscriptions.Domain.Entities;
global using Vinder.Comanda.Subscriptions.Domain.Entities.Enums;
global using Vinder.Comanda.Subscriptions.Domain.Concepts;
global using Vinder.Comanda.Subscriptions.Domain.Errors;
global using Vinder.Comanda.Subscriptions.Domain.Filtering;

global using Vinder.Comanda.Subscriptions.Application.Payloads;
global using Vinder.Comanda.Subscriptions.Application.Gateways;
global using Vinder.Comanda.Subscriptions.Application.Payloads.Subscription;

global using Vinder.Comanda.Subscriptions.CrossCutting.Constants;

global using Vinder.Comanda.Subscriptions.TestSuite.Fixtures;
global using Vinder.Comanda.Subscriptions.TestSuite.Mocks;

global using Vinder.Internal.Essentials.Patterns;
global using Vinder.Internal.Essentials.Utilities;

/* global usings for third-party namespaces here */

global using MongoDB.Driver;
global using DotNet.Testcontainers.Builders;
global using DotNet.Testcontainers.Containers;
global using AutoFixture;