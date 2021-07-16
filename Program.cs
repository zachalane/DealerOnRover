using DealerOnRover.BusinessLogic;
using DealerOnRover.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerOnRover
{

    static class Program
    {

        /// <summary>
        /// The CurrentDomainOnUnhandledException
        /// </summary>
        /// <param name="sender">The sender <see cref="object"/></param>
        /// <param name="e">The e <see cref="UnhandledExceptionEventArgs"/></param>
        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var message = string.Format("Sorry, something went wrong.\r\n" +
                "{0}\r\n" +
                "Please contact support.",
                ((Exception)e.ExceptionObject).Message);

            Console.WriteLine("ERROR {0}: {1}",
                DateTimeOffset.Now, e.ExceptionObject);

            MessageBox.Show(message, "Unexpected Error");
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            var moveRoverCommand = new MoveRoverCommand();
            var presenter = new MainPresenter(mainForm, moveRoverCommand);

            Application.Run(mainForm);
        }
    }
}
