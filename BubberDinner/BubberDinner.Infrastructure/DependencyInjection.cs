using BubberDinner.Application.Common.Interface.Authentication;
using BubberDinner.Application.Common.Interface.Services;
using BubberDinner.Infrastructure.Authentication;
using BubberDinner.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BubberDinner.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        Microsoft.Extensions.Configuration.ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;
    }
}