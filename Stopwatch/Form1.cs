using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class StopWatch : Form
    {
        int timeSeconds, timeMinutes, timeHours;
        bool isActive;

        public StopWatch()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeSeconds++;

                if (timeSeconds >= 60)
                {
                    timeMinutes++;
                    timeSeconds = 0;

                    if (timeMinutes >= 60)
                    {
                        timeHours++;
                        timeMinutes = 0;

                        if (timeHours >= 24)
                        {
                            timeHours = 0;
                        }
                     }
                 }
             }

            DrawTime();
        }

        private void DrawTime()
        {
            label_Seconds.Text = String.Format("{0:00}", timeSeconds);
            label_Minutes.Text = String.Format("{0:00}", timeMinutes);
            label_Hours.Text = String.Format("{0:00}", timeHours);

        }

        private void ResetTime()
        {
            timeSeconds = 0;
            timeMinutes = 0;
            timeHours = 0;
        }

        private void StopWatch_Load(object sender, EventArgs e)
        {
            ResetTime();
            isActive = false;
        }

        private void label_Cs_Click(object sender, EventArgs e)
        {

        }

        
    }
}
