using System;
using System.Reflection;
using System.Windows.Forms;

namespace WinPower
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            defaultSelCmb.SelectedIndex = (int)Properties.Settings.Default.defaultSel;
            timeoutTxt.Text = Properties.Settings.Default.timeout.ToString();

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            versionLbl.Text = string.Format("{0} {1}.{2}", versionLbl.Text, version.Major, version.Minor);

            if (Properties.Settings.Default.debug)
            {
                debugBtn.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void ApplySettings()
        {
            Properties.Settings.Default.defaultSel = (uint)defaultSelCmb.SelectedIndex;
            Properties.Settings.Default.timeout = uint.Parse(timeoutTxt.Text);
            Properties.Settings.Default.Save();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.francescosorge.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.francescosorge.com/fwlink/winpower");
        }

        private void debugBtn_Click(object sender, EventArgs e)
        {
            Form f = new PowerForm();
            f.Show();
        }
    }
}
