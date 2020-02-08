using System;
using System.Windows.Forms;

namespace WinPower
{
    static class Program
    {

        public static Form powerForm;

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

            Form f = new PowerForm();
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "--settings") // Se viene rilevata l'opzione --power
                {
                    f = new SettingsForm(); // lancia la finestra
                }
            }

            Application.Run(f);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
