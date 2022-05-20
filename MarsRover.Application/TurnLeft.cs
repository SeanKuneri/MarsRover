
using MarsRover.Common.Enumeration;
using MarsRover.Domain.Entity;

namespace MarsRoverProblemSolution.Repository.Command
{
    public class TurnLeft : ICommand
    {

        public Coordinate Execute(Coordinate coordinates)
        {
            if (coordinates.Dir == DirectionEnum.N)
            {
                coordinates.Dir = DirectionEnum.W;
            }
            else if (coordinates.Dir == DirectionEnum.W)
            {
                coordinates.Dir = DirectionEnum.S;
            }
            else if (coordinates.Dir == DirectionEnum.S)
            {
                coordinates.Dir = DirectionEnum.E;
            }
            else if (coordinates.Dir == DirectionEnum.E)
            {
                coordinates.Dir = DirectionEnum.N;
            }
            return coordinates;
        }
    }
}
