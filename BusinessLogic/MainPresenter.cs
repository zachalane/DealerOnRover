namespace DealerOnRover.BusinessLogic
{
    using DealerOnRover.Model;
    using DealerOnRover.Support;
    using DealerOnRover.View;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="MainPresenter" />.
    /// </summary>
    public class MainPresenter
    {
        #region Fields

        /// <summary>
        /// Defines the mainControlView.
        /// </summary>
        private readonly IMainControlView mainControlView;

        /// <summary>
        /// Defines the mainForm.
        /// </summary>
        private readonly IMainForm mainForm;

        /// <summary>
        /// Defines the moveRoverCommand.
        /// </summary>
        private readonly MoveRoverCommand moveRoverCommand;

        /// <summary>
        /// Defines the resultsView.
        /// </summary>
        private readonly IResultsView resultsView;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPresenter"/> class.
        /// </summary>
        /// <param name="mainForm">The mainForm<see cref="IMainForm"/>.</param>
        /// <param name="moveRoverCommand">The moveRoverCommand<see cref="MoveRoverCommand"/>.</param>
        public MainPresenter(IMainForm mainForm, MoveRoverCommand moveRoverCommand)
        {
            this.mainForm = mainForm;
            resultsView = this.mainForm.ResultsView;
            mainControlView = this.mainForm.MainControlView;
            this.moveRoverCommand = moveRoverCommand;

            // subscribe to event
            mainControlView.SendCommandClicked += SendCommandClicked;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Listens for the send command button to be clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void SendCommandClicked(object sender, EventArgs e)
        {
            // get rover command form the event arg
            RoverCommandEventArgs roverCommandEventArgs = (RoverCommandEventArgs)e;

            // excute the command and retrive the response
            RoverResponse roverResponse = await Task.Run(() => moveRoverCommand.Execute(roverCommandEventArgs.RoverCommand));

            // Show current location
            if (roverResponse.Success) resultsView.SetReults(roverResponse);
            else resultsView.SetError();
        }

        #endregion
    }
}
