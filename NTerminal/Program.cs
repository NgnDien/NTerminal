using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace NTerminal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
            switch(ShutdownState)
            {
                case eShutdownState.Shutdown:
                    Process.Start("shutdown", "-s");
                    break;
                case eShutdownState.Restart:
                    Process.Start("shutdown", "-r");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// trạng thái tắt
        /// </summary>
        public static eShutdownState ShutdownState { get; set; } = eShutdownState.None;// mặc định là none
    }

    enum eShutdownState
    {
        None = 0,
        Shutdown = 1,
        Restart = 2
    }
}
