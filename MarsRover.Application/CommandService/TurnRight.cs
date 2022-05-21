
using MarsRover.Application.Abstraction;
using MarsRover.Common.Enumeration;
using MarsRover.Domain.Entity;

namespace MarsRover.Command
{
    public class TurnRight : ICommand
    {

        public Coordinate Execute(Coordinate coordinates)
        {

            if (coordinates.Dir == DirectionEnum.N)
            {
                coordinates.Dir = DirectionEnum.E;
            }
            else if (coordinates.Dir == DirectionEnum.E)
            {
                coordinates.Dir = DirectionEnum.S;
            }
            else if (coordinates.Dir == DirectionEnum.S)
            {
                coordinates.Dir = DirectionEnum.W;
            }
            else if (coordinates.Dir == DirectionEnum.W)
            {
                coordinates.Dir = DirectionEnum.N;
            }
            return coordinates;
        }
    }
}
