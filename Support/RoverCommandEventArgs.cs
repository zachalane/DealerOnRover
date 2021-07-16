namespace DealerOnRover.Support
{
    using DealerOnRover.Model;
    using System;

    /// <summary>
    /// Defines the <see cref="RoverCommandEventArgs" />.
    /// </summary>
    public class RoverCommandEventArgs : EventArgs
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RoverCommandEventArgs"/> class.
        /// </summary>
        /// <param name="roverCommand">The roverCommand<see cref="RoverCommand"/>.</param>
        public RoverCommandEventArgs(RoverCommand roverCommand)
        {
            RoverCommand = roverCommand;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the RoverCommand.
        /// </summary>
        public RoverCommand RoverCommand { get; internal set; }

        #endregion
    }
}
