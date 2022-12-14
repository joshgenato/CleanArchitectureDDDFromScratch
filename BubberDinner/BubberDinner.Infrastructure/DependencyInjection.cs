using BubberDinner.Application.Common.Interface.Authentication;
using BubberDinner.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BubberDinner.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}