
namespace MarsRover.Domain.Entity
{
    public interface ICommand
    {
        public Coordinate Execute(Coordinate coordinates);
    }
}
