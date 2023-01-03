/*
 * AddHealthCheckExtension.cs
 *
 *   Created: 2023-01-03-06:54:33
 *   Modified: 2023-01-03-06:54:33
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace JustinWritesCode.EntityFrameworkCore.HealthCheck;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using SendPulse.Api.HealthCheck;

public static class AddHealthCheckExtension
{
    public static IServiceCollection AddSendPulseApiHealthCheck<TDbContext>(
        this IServiceCollection services
    )
    {
        services
            .AddHealthChecks()
            .AddCheck<SendPulseApiHealthCheck>(
                $"Entity Framework Core Health Check for {typeof(TDbContext).Name}"
            );
        return services;
    }
}
