using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockWinFormsApp
{
    public partial class MainForm : Form
    {
        private int timeStopWatch;
        private  DateTime timeStart;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ReadTime_Click(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

      

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timeStopWatch = 0;
            timerStopWatch.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerStopWatch.Enabled = false;
        }

        private void timerStopWatch_Tick(object sender, EventArgs e)
        {
            timeStopWatch++;
            labelStoper.Text = timeStopWatch.ToString();
        }

        private void buttonstartdelta_Click(object sender, EventArgs e)
        {
            timeStart = DateTime.Now;
            timerdelta.Enabled = true;
        }

        private void buttonstopdelta_Click(object sender, EventArgs e)
        {
            timerdelta.Enabled = false;
        }

        private void timerdelta_Tick(object sender, EventArgs e)
        {
            TimeSpan deltaTime = DateTime.Now - timeStart;
            labeldelta.Text = deltaTime.Hours + ":" +
                deltaTime.Minutes + ":" +
                deltaTime.Seconds + ":" +
                deltaTime.Milliseconds;
        }
    }
}
    

