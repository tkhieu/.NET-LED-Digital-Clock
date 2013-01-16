using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedClock
{
    public partial class LedTimeDisplay : UserControl
    {
        int[] _time = new int[4];
        int[] _pause = new int[4];

        public LedTimeDisplay()
        {
            InitializeComponent();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            int[] timeValues = new int[3];
            timeValues[0] = DateTime.Now.Hour;
            timeValues[1] = DateTime.Now.Minute;
            timeValues[2] = DateTime.Now.Second;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var timeValue in timeValues)
            {
                
                if (timeValue < 10)
                    stringBuilder.Append("0").Append(timeValue);
                else
                {
                    stringBuilder.Append(timeValue);
                    
                }
                stringBuilder.Append(".");
            }

            stringBuilder.Remove(8, 1);

            String time = stringBuilder.ToString();
            this.lxLedControl.Text = time;
        }

        private void LedTimeDisplay_Load(object sender, EventArgs e)
        {
            this.lxLedControl.Text = "";
        }

        public void Start()
        {
            _time[0] = 0;
            _time[1] = 0;
            _time[2] = 0;

            msTimer.Enabled = true;
            msTimer.Start();
        }

        public void Stop()
        {
            _time[0] = 0;
            _time[1] = 0;
            _time[2] = 0;

            msTimer.Enabled = true;
            msTimer.Stop();
        }

        public void Pause()
        {
            msTimer.Enabled = false;
            timerPause.Enabled = true;
        }

        public void Resume()
        {
            msTimer.Enabled = true;
            timerPause.Enabled = false;
        }

        private void MsTimerTick(object sender, EventArgs e)
        {

            _time[2] = _time[2] + 1;


            if (_time[2] > 59)
            {
                _time[1] += 1;
                _time[2] = 0;
            }

            if (_time[0] > 59)
            {
                _time[1] += 1;
                _time[0] = 0;
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var timeValue in _time)
            {

                if (timeValue < 10)
                    stringBuilder.Append("0").Append(timeValue);
                else
                {
                    stringBuilder.Append(timeValue);

                }
                stringBuilder.Append(".");
            }

            

            String time = stringBuilder.ToString();
            this.lxLedControl1.Text = time;

        }

        private void timerPause_Tick(object sender, EventArgs e)
        {
            


            for(int i = 0;i<=3;i++)
            {
                _pause[i] = _time[i];
            }


            StringBuilder stringBuilder = new StringBuilder();

            foreach (var timeValue in _pause)
            {

                if (timeValue < 10)
                    stringBuilder.Append("0").Append(timeValue);
                else
                {
                    stringBuilder.Append(timeValue);

                }
                stringBuilder.Append(".");
            }



            if(DateTime.Now.Second %2 == 0)
                this.lxLedControl1.Text = stringBuilder.ToString();
            else
            {
                this.lxLedControl1.Text = "";
            }

        }
    }
}
