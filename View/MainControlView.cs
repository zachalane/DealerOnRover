namespace DealerOnRover.View
{
    using DealerOnRover.Model;
    using DealerOnRover.Support;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IMainControlView" />.
    /// </summary>
    public interface IMainControlView
    {
        #region Events

        /// <summary>
        /// Defines the SendCommandClicked.
        /// </summary>
        event EventHandler SendCommandClicked;

        #endregion
    }

    #endregion

    /// <summary>
    /// Defines the <see cref="MainControlView" />.
    /// </summary>
    public partial class MainControlView : UserControl, IMainControlView
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainControlView"/> class.
        /// </summary>
        public MainControlView()
        {
            InitializeComponent();

            // create events
            btnTest1.Click += (s, a) => OnTest1Clicked();
            btnTest2.Click += (s, a) => OnTest2Clicked();
            btnSend.Click += (s, a) => OnSendCommandClicked();
            btnRotateLeft.Click += (s, a) => OnRotateLeftClicked();
            btnRotateRight.Click += (s, a) => OnRotateRightClicked();
            btnMove.Click += (s, a) => OnMoveClicked();
            btnDelete.Click += (s, a) => OnDeleteClicked();

            // set default boundary
            txtBoundsX.Text = "5";
            txtBoundsY.Text = "5";

            // set default current location
            txtCurrentX.Text = "0";
            txtCurrentY.Text = "0";
            cboCurrentHeading.SelectedIndex = (int)Heading.North;
            txtCommandString.Text = string.Empty;

        }

        #endregion

        #region Events

        /// <summary>
        /// Alerts the business logic when the send command is clicked.
        /// </summary>
        public event EventHandler SendCommandClicked;

        #endregion

        #region Methods

        /// <summary>
        /// Adds a command to text box to display.
        /// </summary>
        /// <param name="moveInstruction">The moveInstruction<see cref="MoveInstruction"/>.</param>
        private void AddToCommandString(MoveInstruction moveInstruction)
        {
            // Check to see which move instruction needs to be added
            switch (moveInstruction)
            {
                case MoveInstruction.Left:
                    txtCommandString.Text = txtCommandString.Text + "L";
                    break;
                case MoveInstruction.Right:
                    txtCommandString.Text = txtCommandString.Text + "R";
                    break;
                case MoveInstruction.Move:
                    txtCommandString.Text = txtCommandString.Text + "M";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clears the command string.
        /// </summary>
        private void OnDeleteClicked()
        {
            txtCommandString.Text = string.Empty;
        }

        /// <summary>
        /// The OnMoveClicked.
        /// </summary>
        private void OnMoveClicked()
        {
            AddToCommandString(MoveInstruction.Move);
        }

        /// <summary>
        /// The OnRotateLeftClicked.
        /// </summary>
        private void OnRotateLeftClicked()
        {
            AddToCommandString(MoveInstruction.Left);
        }

        /// <summary>
        /// The OnRotateRightClicked.
        /// </summary>
        private void OnRotateRightClicked()
        {
            AddToCommandString(MoveInstruction.Right);
        }

        /// <summary>
        /// Executes when user clicks the send command button.
        /// </summary>
        private void OnSendCommandClicked()
        {
            // Create new variables
            var explorationBounds = new ExplorationBounds();
            var roverLocation = new RoverLocation();
            var moveInstructions = new List<MoveInstruction>();

            // validate x/y coordinate entries
            if (int.TryParse(txtBoundsX.Text, out int i)) explorationBounds.X = int.Parse(txtBoundsX.Text);
            else
            {
                MessageBox.Show("Please insert a value 0-99 for Bounds X");
                return;
            }

            if (int.TryParse(txtBoundsY.Text, out int j)) explorationBounds.Y = int.Parse(txtBoundsY.Text);
            else
            {
                MessageBox.Show("Please insert a value 0-99 for Bounds Y");
                return;
            }

            if (int.TryParse(txtCurrentX.Text, out int k)) roverLocation.X = int.Parse(txtCurrentX.Text);
            else
            {
                MessageBox.Show("Please insert a value 0-99 for Current Location X");
                return;
            }

            if (int.TryParse(txtCurrentY.Text, out int l)) roverLocation.Y = int.Parse(txtCurrentY.Text);
            else
            {
                MessageBox.Show("Please insert a value 0-99 for Current Location Y");
                return;
            }

            // get heading from the combobox
            roverLocation.Heading = (Heading)Enum.ToObject(typeof(Heading), cboCurrentHeading.SelectedIndex);

            // get all intstructions from the command string to add to the list
            foreach (var item in txtCommandString.Text.ToCharArray())
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

            SendCommandClicked?.Invoke(this, new RoverCommandEventArgs(new RoverCommand(explorationBounds, roverLocation, moveInstructions)));
        }

        /// <summary>
        /// Creates the data on the UI for the first test application.
        /// </summary>
        private void OnTest1Clicked()
        {
            // set boundary
            txtBoundsX.Text = "5";
            txtBoundsY.Text = "5";

            // set current location
            txtCurrentX.Text = "1";
            txtCurrentY.Text = "2";
            cboCurrentHeading.SelectedIndex = (int)Heading.North;

            txtCommandString.Text = string.Empty;

            // add instructions
            AddToCommandString(MoveInstruction.Left);
            AddToCommandString(MoveInstruction.Move);
            AddToCommandString(MoveInstruction.Left);
            AddToCommandString(MoveInstruction.Move);
            AddToCommandString(MoveInstruction.Left);
            AddToCommandString(MoveInstruction.Move);
            AddToCommandString(MoveInstruction.Left);
            AddToCommandString(MoveInstruction.Move);
            AddToCommandString(MoveInstruction.Move);
        }

        /// <summary>
        /// Creates the data on the UI for the second test application.
        /// </summary>
        private void OnTest2Clicked()
        {
            // set boundary
            txtBoundsX.Text = "5";
            txtBoundsY.Text = "5";

            // set current location
            txtCurrentX.Text = "3";
            txtCurrentY.Text = "3";
            cboCurrentHeading.SelectedIndex = (int)Heading.East;

            txtCommandString.Text = string.Empty;

            // add instructions
            AddToCommandString(MoveInstruction.Move);
            AddToCommandString(MoveInstruction.Move);
            AddToCommandString(MoveInstruction.Right);
            AddToCommandString(MoveInstruction.Move);
            AddToCommandString(MoveInstruction.Move);
            AddToCommandString(MoveInstruction.Right);
            AddToCommandString(MoveInstruction.Move);
            AddToCommandString(MoveInstruction.Right);
            AddToCommandString(MoveInstruction.Right);
            AddToCommandString(MoveInstruction.Move);
        }

        #endregion
    }
}
