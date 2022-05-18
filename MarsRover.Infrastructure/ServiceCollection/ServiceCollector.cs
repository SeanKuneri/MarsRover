using MarsRover.Application;
using MarsRover.Application.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover.Infrastructure.ServiceCollection
{
    public static class ServiceCollector
    {
        public static void AddCommonInfrastructure(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IMarsRoverService, MarsRoverService>();

        }
    }
}
