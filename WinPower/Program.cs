using System;
using System.Windows.Forms;

namespace WinPower
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form f = new SettingsForm();
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "--power") // Se viene rilevata l'opzione --power
                {
                    f = new PowerForm(); // lancia la finestra
                }
            }

            Application.Run(f);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
