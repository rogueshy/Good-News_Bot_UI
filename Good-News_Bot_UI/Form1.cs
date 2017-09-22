using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_News_Bot_UI
{
    public partial class Form1 : Form
    {
        int pythonId;
        string pyRun = "pyw";
        string pyArgs = "main.py";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (NotifCB.Checked == true)
                {
                    if (StatusLabelCurrent.Text == "Stopped")
                    {
                        NotifIcon.Visible = true;
                        NotifIcon.BalloonTipText = "App is stopped!";
                        NotifIcon.BalloonTipTitle = "Good News Bot UI";
                        NotifIcon.ShowBalloonTip(500);
                        this.Hide();
                    }
                    else if (StatusLabelCurrent.Text == "Running...") { 
                        NotifIcon.Visible = true;
                        NotifIcon.BalloonTipText = "App still running.";
                        NotifIcon.BalloonTipTitle = "Good News Bot UI";
                        NotifIcon.ShowBalloonTip(500);
                        this.Hide();
                        }
                }
                else {
                    NotifIcon.Visible = true;
                    this.Hide();
                }
            }
            else if (WindowState == FormWindowState.Normal)
            {
                NotifIcon.Visible = false;
            }
        }

        private void NotifIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MainButton_Click_1(object sender, EventArgs e)
        {
            if (StatusLabelCurrent.Text == "Stopped")
            {
                ProcessStartInfo pythonLaunch = new ProcessStartInfo();
                Process python;
                pythonLaunch.FileName = pyRun;
                pythonLaunch.Arguments = pyArgs;
                pythonLaunch.CreateNoWindow = true;
                pythonLaunch.UseShellExecute = true;
                python = Process.Start(pythonLaunch);
                pythonId = python.Id;
                MainButton.Text = "Stop";
                startStopMenu.Text = "Stop";
                StatusLabelCurrent.Text = "Running...";
            }
            else if (StatusLabelCurrent.Text == "Running...")
            {
                Process toKill = Process.GetProcessById(pythonId);
                toKill.Kill();
                MainButton.Text = "Start";
                startStopMenu.Text = "Start";
                StatusLabelCurrent.Text = "Stopped";
             }
        }

        private void startStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startStopMenu.Text == "Start")
            {
                ProcessStartInfo pythonLaunch = new ProcessStartInfo();
                Process python;
                pythonLaunch.FileName = pyRun;
                pythonLaunch.Arguments = pyArgs;
                pythonLaunch.CreateNoWindow = true;
                pythonLaunch.UseShellExecute = true;
                python = Process.Start(pythonLaunch);
                pythonId = python.Id;
                MainButton.Text = "Stop";
                startStopMenu.Text = "Stop";
                StatusLabelCurrent.Text = "Running...";
            }
            else if (startStopMenu.Text == "Stop")
            {
                Process toKill = Process.GetProcessById(pythonId);
                toKill.Kill();
                MainButton.Text = "Start";
                startStopMenu.Text = "Start";
                StatusLabelCurrent.Text = "Stopped";
            }
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
