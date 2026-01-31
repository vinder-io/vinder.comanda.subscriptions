global using System.Diagnostics.CodeAnalysis;

global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.OpenApi.Models;

global using Vinder.Comanda.Subscriptions.WebApi.Extensions;
global using Vinder.Comanda.Subscriptions.WebApi.Constants;
global using Vinder.Comanda.Subscriptions.Domain.Errors;

global using Vinder.Comanda.Subscriptions.Application.Payloads.Traceability;
global using Vinder.Comanda.Subscriptions.Application.Payloads.Subscription;

global using Vinder.Comanda.Subscriptions.Infrastructure.IoC.Extensions;
global using Vinder.Comanda.Subscriptions.CrossCutting.Configurations;

global using Vinder.Dispatcher.Contracts;
global using Vinder.Federation.Sdk.Extensions;

global using Scalar.AspNetCore;
global using Serilog;
global using FluentValidation.AspNetCore;
