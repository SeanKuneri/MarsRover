
using MarsRover.Application.Abstraction;
using MarsRover.Common.Enumeration;
using MarsRover.Domain.Entity;

namespace MarsRover.Command
{
    public class TurnLeft : ICommand
    {

        public Coordinate Execute(Coordinate coordinates)
        {
            if (coordinates.Direction == DirectionEnum.N)
            {
                coordinates.Direction = DirectionEnum.W;
            }
            else if (coordinates.Direction == DirectionEnum.W)
            {
                coordinates.Direction = DirectionEnum.S;
            }
            else if (coordinates.Direction == DirectionEnum.S)
            {
                coordinates.Direction = DirectionEnum.E;
            }
            else if (coordinates.Direction == DirectionEnum.E)
            {
                coordinates.Direction = DirectionEnum.N;
            }
            return coordinates;
        }
    }
}
