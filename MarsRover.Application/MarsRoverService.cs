using MarsRover.Application.Abstraction;
using MarsRover.Common.Enumeration;
using MarsRover.Domain.Entity;
using MarsRover.Command;
using System;
using System.Collections.Generic;

namespace MarsRover.Application
{
    public class MarsRoverService : IMarsRoverService
    {

        private readonly IOperatorService operatorService;

        public MarsRoverService()
        {
            operatorService = new OperatorService();
        }

        public Coordinate MoveRover(string[] upperRightBoundryCoordinates, string[] currentLocation, string actions)
        {

            var maxLst = new List<int>();
            foreach (var point in upperRightBoundryCoordinates)
            {
                var maxCoordinate = Convert.ToInt32(point);
                maxLst.Add(maxCoordinate);
            }
            var coordinate = new Coordinate();
            coordinate.X = Convert.ToInt32(currentLocation[0]);
            coordinate.Y = Convert.ToInt32(currentLocation[1]);
            coordinate.Dir = EnumExtensions.GetEnumValue(currentLocation[2]);
            ICommand command;

            foreach (var dir in actions)
            {

                if (dir == MovementEnum.TurnLeft)
                {
                    command = new TurnLeft();
                }
                else if (dir == MovementEnum.TurnRight)
                {
                    command = new TurnRight();

                }
                else if (dir == MovementEnum.MoveForward)
                {
                    command = new MoveForward(maxLst);
                }
                else return null;


                var operationResult = operatorService.StartMoving(command, coordinate);

                if (operationResult == null)
                    return null;

                coordinate.Dir = operationResult.Dir;
                coordinate.X = operationResult.X;
                coordinate.Y = operationResult.Y;
            }
            return coordinate;

        }
    }
}
