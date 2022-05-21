using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;
using MarsRover.Common.Enumeration;
using MarsRover.Domain.Entity;
using MarsRover.Application;
using MarsRover.Application.Abstraction;
using FakeItEasy;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover.Test
{
    [TestClass]
    public class MarsRoverProblemTest
    {
        private readonly IMarsRoverService marsRoverService; 
        private readonly IOperatorService operatorService;
        private readonly ICommand command;

        public MarsRoverProblemTest()
        {
            operatorService = new OperatorService();
            marsRoverService = new MarsRoverService();
            command = A.Fake<ICommand>();
        }

        [TestMethod]
        public void TestScanrioForInput1()
        {
            //var services = new ServiceCollection();
            //var _serviceProvider = services.BuildServiceProvider(true);
            //var command = _serviceProvider.GetService<ICommand>();


            Coordinate coordinate = new Coordinate();

            coordinate.X = 1;
            coordinate.Y = 2;
            coordinate.Dir = DirectionEnum.N;

            //ICommand command;

            string [] upperRightBoundryCoordinates = { "5", "5" };
            string[] currentLocation = { "1", "2", "N" };
            var actions = "LMLMLMLMM";

            marsRoverService.MoveRover(upperRightBoundryCoordinates, currentLocation, actions);

           // A.CallTo(() => operatorService.StartMoving(A<ICommand>._, A<Coordinate>._)).ReturnsLazily(() => coordinate);

            var operationResult = operatorService.StartMoving(command, coordinate);

            var actualOutput = $"{operationResult.X} {operationResult.Y} {operationResult.Dir}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestScanrioForInput2()
        {
            var services = new ServiceCollection();
            var _serviceProvider = services.BuildServiceProvider(true);
            var command = _serviceProvider.GetService<ICommand>();

            var coordinate = new Coordinate();
            coordinate.X = 3;
            coordinate.Y = 3;
            coordinate.Dir = DirectionEnum.N;

            string[] currentLocation = { "3", "3", "E" };
            string [] upperRightBoundryCoordinates = { "5", "5" };
            var actions = "MMRMMRMRRM";

            marsRoverService.MoveRover(upperRightBoundryCoordinates, currentLocation, actions);

            var operationResult = operatorService.StartMoving(command, coordinate);

            var actualOutput = $"{operationResult.X} {operationResult.Y} {operationResult.Dir}";
            var expectedOutput = "5 1 E";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
