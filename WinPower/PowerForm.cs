using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinPower
{
    public partial class PowerForm : Form
    {
        private uint remainingSeconds;
        private SelectedOperation selectedOperation;
        
        enum SelectedOperation
        {
            SHUTDOWN,
            RESTART,
            HIBERNATE
        }

        public PowerForm()
        {
            InitializeComponent();
            StopTimer();

            switch (Properties.Settings.Default.defaultSel)
            {
                case 1:
                    shutdownBtn_Click(null, null);
                    break;
                case 2:
                    restartBtn_Click(null, null);
                    break;
                case 3:
                    hibernateBtn_Click(null, null);
                    break;
            }

            if (Properties.Settings.Default.debug)
            {
                debugLbl.Visible = true;
            }
        }

        private void backToWinBtn_Click(object sender, EventArgs e)
        {
            StopTimer();
            Close();
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            selectedOperation = SelectedOperation.SHUTDOWN;
            StopTimer();
            StartTimer();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            selectedOperation = SelectedOperation.RESTART;
            StopTimer();
            StartTimer();
        }

        private uint GetTimeout()
        {
            return Properties.Settings.Default.timeout;
        }

        private void StartTimer()
        {
            remainingSeconds = GetTimeout();
            timer1.Start();
            secondsPgb.Value = 100;
            timeoutPnl.Visible = true;
        }

        private void StopTimer()
        {
            remainingSeconds = GetTimeout();
            timer1.Stop();
            secondsPgb.Value = 100;
            timeoutPnl.Visible = false;
            secondsLbl.Text = string.Format("{0} seconds", remainingSeconds);
        }

        private void TakeAction()
        {
            StopTimer();
            char option = ' ';
            switch (selectedOperation)
            {
                case SelectedOperation.SHUTDOWN:
                    option = 's';
                    break;
                case SelectedOperation.RESTART:
                    option = 'r';
                    break;
                case SelectedOperation.HIBERNATE:
                    option = 'h';
                    break;
            }

            if (option != ' ')
            {
                shutdownCmd(option);
            }
        }

        private void shutdownCmd(char option)
        {
            string options;
            if (option == 'o')
            {
                options = string.Format("/{0} /t 0", "r /o");
            }
            else
            {
                options = string.Format("/{0} /t 0", option);
            }

            if (Properties.Settings.Default.debug)
            {
                Console.WriteLine(options);
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo("shutdown", options);
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            secondsPgb.Value = (int)(100 * remainingSeconds / GetTimeout());
            secondsLbl.Text = string.Format("{0} seconds", remainingSeconds);
            if (remainingSeconds <= 0)
            {
                TakeAction();
                timer1.Stop();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void hibernateBtn_Click(object sender, EventArgs e)
        {
            selectedOperation = SelectedOperation.HIBERNATE;
            StopTimer();
            StartTimer();
        }

        private void advRestartBtn_Click(object sender, EventArgs e)
        {
            shutdownCmd('o');
        }
    }
}
