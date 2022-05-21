
using MarsRover.Domain.Entity;

namespace MarsRover.Application.Abstraction
{
    public interface ICommand
    {
        public Coordinate Execute(Coordinate coordinates);
    }
}
