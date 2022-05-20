
using MarsRover.Common.Enumeration;

namespace MarsRover.Domain.Entity
{
    public class Coordinate
    {

        public int X { get; set; }

        public int Y { get; set; }

        public DirectionEnum Dir { get; set; }
    }
}
