namespace DealerOnRover.Model
{
    /// <summary>
    /// Defines the <see cref="RoverResponse" />.
    /// </summary>
    public class RoverResponse
    {
        #region Fields

        /// <summary>
        /// Defines the roverLocation.
        /// </summary>
        private RoverLocation roverLocation;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RoverResponse"/> class.
        /// </summary>
        /// <param name="roverLocation">The roverLocation<see cref="RoverLocation"/>.</param>
        public RoverResponse(RoverLocation roverLocation)
        {
            this.roverLocation = roverLocation;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the RoverLocation.
        /// </summary>
        public RoverLocation RoverLocation
        {
            get { return roverLocation; }
            set { roverLocation = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether Success.
        /// </summary>
        public bool Success { get; set; }

        #endregion
    }
}
