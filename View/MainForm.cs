namespace DealerOnRover.View
{
    using System.Windows.Forms;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IMainForm" />.
    /// </summary>
    public interface IMainForm
    {
        #region Properties

        /// <summary>
        /// Gets the MainControlView.
        /// </summary>
        IMainControlView MainControlView { get; }

        /// <summary>
        /// Gets the ResultsView.
        /// </summary>
        IResultsView ResultsView { get; }

        #endregion
    }

    #endregion

    /// <summary>
    /// Defines the <see cref="MainForm" />.
    /// </summary>
    public partial class MainForm : Form, IMainForm
    {
        #region Fields

        /// <summary>
        /// Defines the mainControlView.
        /// </summary>
        private readonly MainControlView mainControlView;

        /// <summary>
        /// Defines the resultsView.
        /// </summary>
        private readonly ResultsView resultsView;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // create the user controls
            mainControlView = new MainControlView() { Dock = DockStyle.Fill };
            resultsView = new ResultsView() { Dock = DockStyle.Fill };

            // add them to the split containers
            splitContainer1.Panel1.Controls.Add(mainControlView);
            splitContainer1.Panel2.Controls.Add(resultsView);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the MainControlView.
        /// </summary>
        public IMainControlView MainControlView { get => mainControlView; }

        /// <summary>
        /// Gets the ResultsView.
        /// </summary>
        public IResultsView ResultsView { get => resultsView; }

        #endregion
    }
}
