using MarsRover.Application.Abstraction;
using MarsRover.Domain.Entity;

namespace MarsRover.Application
{
    public class OperatorService : IOperatorService
    {
        public Coordinate StartMoving(ICommand command, Coordinate coordinates)
        {
            return command.Execute(coordinates);
        }
    }
}
