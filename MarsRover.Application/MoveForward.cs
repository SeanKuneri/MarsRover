using MarsRover.Common.Enumeration;
using MarsRover.Domain.Entity;
using System;
using System.Collections.Generic;

namespace MarsRoverProblemSolution.Repository.Command
{
    public class MoveForward : ICommand
    {
        private List<int> upperRightBoundryCoordinates = new List<int>();

        public MoveForward(List<int> upperRightBoundryCoordinates)
        {
            this.upperRightBoundryCoordinates = upperRightBoundryCoordinates;
        }

        public Coordinate Execute(Coordinate coordinate)
        {

            if (coordinate.Dir == DirectionEnum.N)
            {
                if (coordinate.Y >= upperRightBoundryCoordinates[1])
                    coordinate = CantMove();
                else
                    coordinate.Y += 1;
            }
            else if (coordinate.Dir == DirectionEnum.E)
            {
                if (coordinate.X >= upperRightBoundryCoordinates[0])
                    coordinate = CantMove();
                else
                    coordinate.X += 1;
            }
            else if (coordinate.Dir == DirectionEnum.S)
            {
                if (coordinate.Y != 0)
                    coordinate.Y -= 1;
                else
                    coordinate = CantMove();
            }
            else if (coordinate.Dir == DirectionEnum.W)
            {
                if (coordinate.X != 0)
                    coordinate.X -= 1;
                else
                    coordinate = CantMove();
            }
            return coordinate;
        }

        private Coordinate CantMove()
        {
            Console.WriteLine("Can't Move");
            return null;
        }
    }
}
