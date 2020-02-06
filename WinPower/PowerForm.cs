using System;
using System.Windows.Forms;

namespace WinPower
{
    public partial class PowerForm : Form
    {
        private int remainingSeconds;
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
            Console.WriteLine(Properties.Settings.Default.defaultSel);
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

        private int GetTimeout()
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
                Console.WriteLine(option);
                //var psi = new ProcessStartInfo("shutdown", string.Format("/{0} /t 0", option));
                //psi.CreateNoWindow = true;
                //psi.UseShellExecute = false;
                //Process.Start(psi);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            secondsPgb.Value = 100 * remainingSeconds / GetTimeout();
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

        }
    }
}
