namespace DealerOnRover.Support
{
    #region Enums

    /// <summary>
    /// Current heading of the rover.
    /// </summary>
    public enum Heading
    {
        /// <summary>
        /// Defines the North.
        /// </summary>
        North,
        /// <summary>
        /// Defines the East.
        /// </summary>
        East,
        /// <summary>
        /// Defines the South.
        /// </summary>
        South,
        /// <summary>
        /// Defines the West.
        /// </summary>
        West
    }

    /// <summary>
    /// Available instructions to move the rover.
    /// </summary>
    public enum MoveInstruction
    {
        /// <summary>
        /// Defines the Left.
        /// </summary>
        Left,

        /// <summary>
        /// Defines the Right.
        /// </summary>
        Right,

        /// <summary>
        /// Defines the Move.
        /// </summary>
        Move
    }

    #endregion
}
