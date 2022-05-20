
using MarsRover.Domain.Entity;

namespace MarsRover.Application.Abstraction
{
    public interface IMarsRoverService
    {
        Coordinate MoveRover(string[] upperRightBoundryCoordinates, string[] currentLocation, string actions, IOperatorService operatorService);
    }
}
