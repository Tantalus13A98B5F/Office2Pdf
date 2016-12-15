using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Office2Pdf
{
    static class Program
    {
        [DllImport("user32.dll")]
        private static extern void SetProcessDPIAware();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
