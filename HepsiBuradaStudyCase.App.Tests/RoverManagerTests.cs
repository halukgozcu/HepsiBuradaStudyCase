using HepsiBuradaStudyCase.App.Managers.Abstract;
using HepsiBuradaStudyCase.App.Managers.Concrete;
using HepsiBuradaStudyCase.App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HepsiBuradaStudyCase.App.Tests
{
    public class RoverManagerTests
    {
        private readonly IRoverManager _roverManager;
        public RoverManagerTests()
        {
            this._roverManager = new RoverManager();
        }

        [Fact]
        public void Test_12N_With_LMLMLMLMM_Returns_13N()
        {
            Rover rover = new Rover()
            {
                MaximumCoordinate = new Coordinate() { XCoordinate = 5, YCoordinate = 5 },
                RoverCoordinate = new Coordinate() { XCoordinate = 1, YCoordinate = 2 },
                Direction = Direction.N,
                Movement = new List<string>() { "L", "M", "L", "M", "L", "M", "L", "M", "M" }
            };

            rover = _roverManager.Move(rover);

            Assert.Equal(1, rover.RoverCoordinate.XCoordinate);
            Assert.Equal(3, rover.RoverCoordinate.YCoordinate);
            Assert.Equal(Direction.N, rover.Direction);
        }

        [Fact]
        public void Test_33E_With_MMRMMRMRRM_Returns_51E()
        {
            Rover rover = new Rover()
            {
                MaximumCoordinate = new Coordinate() { XCoordinate = 5, YCoordinate = 5 },
                RoverCoordinate = new Coordinate() { XCoordinate = 3, YCoordinate = 3 },
                Direction = Direction.E,
                Movement = new List<string>() { "M", "M", "R", "M", "M", "R", "M", "R", "R", "M" }
            };

            rover = _roverManager.Move(rover);

            Assert.Equal(5, rover.RoverCoordinate.XCoordinate);
            Assert.Equal(1, rover.RoverCoordinate.YCoordinate);
            Assert.Equal(Direction.E, rover.Direction);
        }
    }
}
