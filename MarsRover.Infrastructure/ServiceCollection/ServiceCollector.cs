using MarsRover.Application;
using MarsRover.Application.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover.Infrastructure.ServiceCollection
{
    public static class ServiceCollector
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IMarsRoverService, MarsRoverService>(); 
            serviceCollection.AddSingleton<IOperatorService, OperatorService>();

        }
    }
}
