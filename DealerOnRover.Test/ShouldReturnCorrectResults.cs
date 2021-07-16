using DealerOnRover.BusinessLogic;
using DealerOnRover.Model;
using DealerOnRover.Support;
using DealerOnRover.View;
using NUnit.Framework;
using System.Collections.Generic;

namespace DealerOnRover.Test
{
    public class ShouldReturnCorrectResults
    {

        [TestCase(5, 5, 1, 2, Heading.North, "LMLMLMLMM", 1, 3, Heading.North)]
        [TestCase(5, 5, 3, 3, Heading.East, "MMRMMRMRRM", 5, 1, Heading.East)]
        public void ShouldReturnCorrect(int boundsX,
                            int boundsY,
                            int currentLocationX,
                            int currentLocationY,
                            Heading currentHeading,
                            string instructions,
                            int resultX,
                            int resultY,
                            Heading resultHeading)
        {
            var explorationBounds = new ExplorationBounds();
            var roverLocation = new RoverLocation();
            var moveInstructions = new List<MoveInstruction>();

            explorationBounds.X = boundsX;
            explorationBounds.Y = boundsY;

            roverLocation.X = currentLocationX;
            roverLocation.Y = currentLocationY;
            roverLocation.Heading = currentHeading;

            foreach (var item in instructions)
            {
                switch (item)
                {
                    case 'L':
                        moveInstructions.Add(MoveInstruction.Left);
                        break;
                    case 'R':
                        moveInstructions.Add(MoveInstruction.Right);
                        break;
                    case 'M':
                        moveInstructions.Add(MoveInstruction.Move);
                        break;
                    default:
                        break;
                }
            }
            
            RoverCommand roverCommand = new RoverCommand(explorationBounds, roverLocation, moveInstructions);
            MoveRoverCommand moveRoverCommand = new MoveRoverCommand();
            RoverResponse roverResponse =  moveRoverCommand.Execute(roverCommand);

            Assert.AreEqual(resultX, roverResponse.RoverLocation.X);
            Assert.AreEqual(resultY, roverResponse.RoverLocation.Y);
            Assert.AreEqual(resultHeading, roverResponse.RoverLocation.Heading);
        }
    }
}