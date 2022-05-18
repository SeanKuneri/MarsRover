using MarsRover.Application.Abstraction;
using MarsRover.Infrastructure.ServiceCollection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var upperRightBoundryCoordinates = Console.ReadLine().ToUpper(); //the lower-left coordinates are predefined as (0,0).
            var currentLocation = Console.ReadLine().ToUpper();
            var actions = Console.ReadLine().ToUpper();


            var services = new ServiceCollection();

            ServiceCollector.AddCommonInfrastructure(services);


            var serviceProvider = services.BuildServiceProvider(true);
            var marsRoverService = serviceProvider.GetService<IMarsRoverService>();



            Console.WriteLine("upperRightBoundryCoordinates:" + upperRightBoundryCoordinates);
            Console.WriteLine("currentLocation:" + currentLocation);
            Console.WriteLine("actions:" + actions);
        }
    }
}
