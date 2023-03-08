using System;
using System.Threading;
using System.Windows.Forms;

namespace MyFileStash.Files.def
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalErrorHandler);
            Thread.GetDomain().UnhandledException += new UnhandledExceptionEventHandler(GlobalErrorHandler);
            Application.Run(new MyFileStash.Menu.Forms.Main());
        }

        private static void GlobalErrorHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show(ex.Message, "MyFileStash", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
