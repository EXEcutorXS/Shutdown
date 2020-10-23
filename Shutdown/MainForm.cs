using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class MainForm : Form
    {
        DateTime timeToShutdown;
        public void shutdown()
        {
            System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + @"\shutdown.exe", "/c shutdown -s -f -t 00");
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void setTimer(object sender, EventArgs e)
        {
            timeToShutdown = DateTime.Now.AddMinutes(Convert.ToDouble((sender as Control).Name.Trim("button".ToCharArray())));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timeToShutdown!=DateTime.MinValue)
            {
                TimeSpan delay = timeToShutdown - DateTime.Now;
                elapsedTime.Text = string.Format("{0:d2}:{1:d2}:{2:d2}", delay.Hours, delay.Minutes, delay.Seconds);
                trayIcon.Text = "Выключаем через " + elapsedTime.Text;

                if (delay.TotalMinutes < 3) 
                    elapsedTime.ForeColor = Color.Red;
                else
                    elapsedTime.ForeColor = Color.Black;

                if (delay < TimeSpan.Zero) 
                {
                    shutdown();
                }
            }
            else 
                elapsedTime.Text = "00:00:00";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            timeToShutdown = DateTime.MinValue;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            trayIcon.Visible = this.WindowState == FormWindowState.Minimized;
        }

        private void elapsedTime_Click(object sender, EventArgs e)
        {
            timeToShutdown = DateTime.MinValue;
        }
    }
}

