namespace MyData.TestApp
{
    internal static class Program
    {
        static MainForm MainForm = null;
        static void DisplayError(Exception e)
        {
            if (MainForm != null)
            {
                MainForm.Log(e.ToString());
            }
            else
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /* private */
        /// <summary>
        /// this is of a little use because it actually is a notification about an exception, NOT a catcher. 
        /// <para>WARNING: An unhandled exception in ANY thread terminates the application. </para>
        /// </summary>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                if ((e.ExceptionObject is Exception) && !e.IsTerminating)
                {
                    Logger.Error(e.ExceptionObject as Exception);
                    DisplayError(e.ExceptionObject as Exception);
                }
                else
                {
                    Logger.Error(e.ExceptionObject.ToString());
                }
            }
            catch
            {
            }
        }
        /// <summary>
        /// Global exception catcher for unhandled exceptions thrown by the primary (UI) thread.
        /// </summary>
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                Logger.Error(e.Exception);
                DisplayError(e.Exception);
            }
            catch
            {
            }
        }


        /* construction */
        /// <summary>
        /// Static constructor. Setups unhandled exception event handlers.
        /// </summary>
        static Program()
        {
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MainForm = new MainForm();
            Application.Run(MainForm);

        }
    }
}