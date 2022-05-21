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
            var upperRightBoundryCoordinates = Console.ReadLine().Split(' '); //the lower-left coordinates are predefined as (0,0).
            var currentLocation = Console.ReadLine().Split(' ');
            var actions = Console.ReadLine().ToUpper();

            var services = new ServiceCollection();
            ServiceCollector.AddServices(services);

            var serviceProvider = services.BuildServiceProvider(true);
            var marsRoverService = serviceProvider.GetService<IMarsRoverService>();

            var coordinate = marsRoverService.MoveRover(upperRightBoundryCoordinates, currentLocation, actions);
            if (coordinate != null)
                Console.WriteLine(coordinate.X + " " + coordinate.Y + " " + coordinate.Direction);
            else
                Console.WriteLine("error");
        }
    }
}
