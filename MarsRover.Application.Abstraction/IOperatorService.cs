

using MarsRover.Domain.Entity;

namespace MarsRover.Application.Abstraction
{
    public interface IOperatorService
    {
        Coordinate StartMoving(ICommand command, Coordinate coordinates);
    }
}
