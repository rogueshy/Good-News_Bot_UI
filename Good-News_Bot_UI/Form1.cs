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
            System.Diagnostics.ProcessStartInfo pythonLaunch = new System.Diagnostics.ProcessStartInfo();
            Process python;
            pythonLaunch.FileName = "pyw";
            pythonLaunch.Arguments = "main.py";
            pythonLaunch.CreateNoWindow = true;
            pythonLaunch.UseShellExecute = true;

            if (StatusLabelCurrent.Text == "Stopped")
            {
                python = Process.Start(pythonLaunch);
                pythonId = python.Id;
                MainButton.Text = "Stop";
                StatusLabelCurrent.Text = "Running...";
            }
            else if (StatusLabelCurrent.Text == "Running...")
            {
                Process toKill = Process.GetProcessById(pythonId);
                toKill.Kill();
                MainButton.Text = "Start";
                StatusLabelCurrent.Text = "Stopped";
             }
        }
    }
}
