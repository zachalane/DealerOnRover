namespace DealerOnRover.BusinessLogic
{
    using DealerOnRover.Model;
    using DealerOnRover.Support;

    /// <summary>
    /// Defines the <see cref="MoveRoverCommand" />.
    /// </summary>
    public class MoveRoverCommand
    {
        #region Methods

        /// <summary>
        /// Moves the rover from the list of instrutions.
        /// </summary>
        /// <param name="roverCommand">The roverCommand<see cref="RoverCommand"/>.</param>
        /// <returns>The <see cref="RoverCommand"/>.</returns>
        public RoverResponse Execute(RoverCommand roverCommand)
        {
            // go through each item in the list of instructions.
            foreach (var moveInstruction in roverCommand.MoveInstructions)
            {
                // check the instruction type
                switch (moveInstruction)
                {
                    case MoveInstruction.Left:
                        roverCommand.RoverResponse = RotateHeadingLeft(roverCommand.RoverResponse);
                        break;
                    case MoveInstruction.Right:
                        roverCommand.RoverResponse = RotateHeadingRight(roverCommand.RoverResponse);
                        break;
                    case MoveInstruction.Move:
                        roverCommand.RoverResponse = MoveForward(roverCommand.RoverResponse);
                        break;
                    default:
                        break;
                }

                // check to see if movement causes rover to go out of bounds
                if (OutOfBounds(roverCommand))
                {
                    roverCommand.RoverResponse.Success = false;
                    return roverCommand.RoverResponse;
                }
            }

            roverCommand.RoverResponse.Success = true;
            return roverCommand.RoverResponse;
        }

        /// <summary>
        /// Advances the rover forward based on heading.
        /// </summary>
        /// <param name="roverResponse">The roverResponse<see cref="RoverResponse"/>.</param>
        /// <returns>The <see cref="RoverResponse"/>.</returns>
        private RoverResponse MoveForward(RoverResponse roverResponse)
        {
            // switch based on current heading
            switch (roverResponse.RoverLocation.Heading)
            {
                case Heading.North:
                    roverResponse.RoverLocation.Y++;
                    break;
                case Heading.East:
                    roverResponse.RoverLocation.X++;
                    break;
                case Heading.South:
                    roverResponse.RoverLocation.Y--;
                    break;
                case Heading.West:
                    roverResponse.RoverLocation.X--;
                    break;
                default:
                    break;
            }

            // return the changes
            return roverResponse;
        }

        /// <summary>
        /// Verifys that the rover has not moved out of bounds.
        /// </summary>
        /// <param name="roverCommand">The roverCommand<see cref="RoverCommand"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool OutOfBounds(RoverCommand roverCommand)
        {

            return roverCommand.RoverResponse.RoverLocation.X > roverCommand.ExplorationBounds.X ||
                    roverCommand.RoverResponse.RoverLocation.Y > roverCommand.ExplorationBounds.Y ||
                    roverCommand.RoverResponse.RoverLocation.X < 0 ||
                    roverCommand.RoverResponse.RoverLocation.Y < 0;
        }

        /// <summary>
        /// Rotates the rover left based on orientation.
        /// </summary>
        /// <param name="roverResponse">The roverResponse<see cref="RoverResponse"/>.</param>
        /// <returns>The <see cref="RoverResponse"/>.</returns>
        private RoverResponse RotateHeadingLeft(RoverResponse roverResponse)
        {
            // switch based on current heading
            switch (roverResponse.RoverLocation.Heading)
            {
                case Heading.North:
                    roverResponse.RoverLocation.Heading = Heading.West;
                    break;
                case Heading.East:
                    roverResponse.RoverLocation.Heading = Heading.North;
                    break;
                case Heading.South:
                    roverResponse.RoverLocation.Heading = Heading.East;
                    break;
                case Heading.West:
                    roverResponse.RoverLocation.Heading = Heading.South;
                    break;
                default:
                    break;
            }

            // return the changes
            return roverResponse;
        }

        /// <summary>
        /// Rotates the rover right based on orientation.
        /// </summary>
        /// <param name="roverResponse">The roverResponse<see cref="RoverResponse"/>.</param>
        /// <returns>The <see cref="RoverResponse"/>.</returns>
        private RoverResponse RotateHeadingRight(RoverResponse roverResponse)
        {
            // switch based on current heading
            switch (roverResponse.RoverLocation.Heading)
            {
                case Heading.North:
                    roverResponse.RoverLocation.Heading = Heading.East;
                    break;
                case Heading.East:
                    roverResponse.RoverLocation.Heading = Heading.South;
                    break;
                case Heading.South:
                    roverResponse.RoverLocation.Heading = Heading.West;
                    break;
                case Heading.West:
                    roverResponse.RoverLocation.Heading = Heading.North;
                    break;
                default:
                    break;
            }

            // return the changes
            return roverResponse;
        }

        #endregion
    }
}
