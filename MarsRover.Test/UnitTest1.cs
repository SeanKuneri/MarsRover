using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover.Common.Enumeration;
using MarsRover.Domain.Entity;
using MarsRover.Application;
using MarsRover.Application.Abstraction;

namespace MarsRover.Test
{
    [TestClass]
    public class MarsRoverProblemTest
    {
        private readonly IMarsRoverService marsRoverService;

        public MarsRoverProblemTest()
        {
            marsRoverService = new MarsRoverService();
        }

        [TestMethod]
        public void TestScanrioForInput1()
        {
            Coordinate coordinate = new Coordinate();

            coordinate.X = 1;
            coordinate.Y = 2;
            coordinate.Direction = DirectionEnum.N;

            string [] upperRightBoundryCoordinates = { "5", "5" };
            string[] currentLocation = { "1", "2", "N" };
            var actions = "LMLMLMLMM";

            var operationResult = marsRoverService.MoveRover(upperRightBoundryCoordinates, currentLocation, actions);

            var actualOutput = $"{operationResult.X} {operationResult.Y} {operationResult.Direction}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestScanrioForInput2()
        {
            var coordinate = new Coordinate();
            coordinate.X = 3;
            coordinate.Y = 3;
            coordinate.Direction = DirectionEnum.N;

            string[] currentLocation = { "3", "3", "E" };
            string[] upperRightBoundryCoordinates = { "5", "5" };
            var actions = "MMRMMRMRRM";

            var operationResult = marsRoverService.MoveRover(upperRightBoundryCoordinates, currentLocation, actions);

            var actualOutput = $"{operationResult.X} {operationResult.Y} {operationResult.Direction}";
            var expectedOutput = "5 1 E";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
