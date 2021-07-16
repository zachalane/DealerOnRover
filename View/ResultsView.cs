namespace DealerOnRover.View
{
    using DealerOnRover.Model;
    using System.Windows.Forms;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IResultsView" />.
    /// </summary>
    public interface IResultsView
    {
        #region Methods

        /// <summary>
        /// The SetError.
        /// </summary>
        void SetError();

        /// <summary>
        /// The SetReults.
        /// </summary>
        /// <param name="roverResponse">The roverResponse<see cref="RoverResponse"/>.</param>
        void SetReults(RoverResponse roverResponse);

        #endregion
    }

    #endregion

    /// <summary>
    /// Defines the <see cref="ResultsView" />.
    /// </summary>
    public partial class ResultsView : UserControl, IResultsView
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsView"/> class.
        /// </summary>
        public ResultsView()
        {
            InitializeComponent();

            txtLocationX.Text = string.Empty;
            txtLocationY.Text = string.Empty;
            txtLocationHeading.Text = string.Empty;
            txtResults.Text = string.Empty;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The SetError.
        /// </summary>
        public void SetError()
        {
            txtLocationX.Text = "0";
            txtLocationY.Text = "0";
            txtLocationHeading.Text = "0";

            txtResults.Text = "Rover exceeded boundary!";
        }

        /// <summary>
        /// The SetReults.
        /// </summary>
        /// <param name="roverResponse">The roverResponse<see cref="RoverResponse"/>.</param>
        public void SetReults(RoverResponse roverResponse)
        {
            txtLocationX.Text = roverResponse.RoverLocation.X.ToString();
            txtLocationY.Text = roverResponse.RoverLocation.Y.ToString();
            txtLocationHeading.Text = roverResponse.RoverLocation.Heading.ToString();

            txtResults.Text = "Success!";
        }

        #endregion
    }
}
