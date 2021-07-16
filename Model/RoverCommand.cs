namespace DealerOnRover.Model
{
    using DealerOnRover.Support;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="RoverCommand" />.
    /// </summary>
    public class RoverCommand
    {
        #region Fields

        /// <summary>
        /// Defines the explorationBounds.
        /// </summary>
        private ExplorationBounds explorationBounds;

        /// <summary>
        /// Defines the moveInstructions.
        /// </summary>
        private ICollection<MoveInstruction> moveInstructions;

        /// <summary>
        /// Defines the roverLocation.
        /// </summary>
        private RoverLocation roverLocation;

        /// <summary>
        /// Defines the roverResponse.
        /// </summary>
        private RoverResponse roverResponse;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RoverCommand"/> class.
        /// </summary>
        /// <param name="explorationBounds">The explorationBounds<see cref="ExplorationBounds"/>.</param>
        /// <param name="roverLocation">The roverLocation<see cref="RoverLocation"/>.</param>
        /// <param name="moveInstructions">The moveInstructions<see cref="ICollection{MoveInstruction}"/>.</param>
        public RoverCommand(ExplorationBounds explorationBounds,
                                 RoverLocation roverLocation,
                                 ICollection<MoveInstruction> moveInstructions)
        {
            this.explorationBounds = explorationBounds;
            this.roverLocation = roverLocation;
            this.moveInstructions = moveInstructions;
            roverResponse = new RoverResponse(this.roverLocation);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the ExplorationBounds.
        /// </summary>
        public ExplorationBounds ExplorationBounds
        {
            get { return explorationBounds; }
            set { explorationBounds = value; }
        }

        /// <summary>
        /// Gets or sets the MoveInstructions.
        /// </summary>
        public ICollection<MoveInstruction> MoveInstructions
        {
            get { return moveInstructions; }
            set { moveInstructions = value; }
        }

        /// <summary>
        /// Gets or sets the RoverLocation.
        /// </summary>
        public RoverLocation RoverLocation
        {
            get { return roverLocation; }
            set { roverLocation = value; }
        }

        /// <summary>
        /// Gets or sets the RoverResponse.
        /// </summary>
        public RoverResponse RoverResponse
        {
            get { return roverResponse; }
            set { roverResponse = value; }
        }

        #endregion
    }
}
