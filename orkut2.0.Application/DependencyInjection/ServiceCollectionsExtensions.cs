using Microsoft.Extensions.DependencyInjection;
using orkut2._0.Application.Services;

namespace orkut2._0.Application.DependencyInjection
{
    public static class ServiceCollectionsExtensions
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUsersService, UsersService>();
            return services;
        }
    }
}
