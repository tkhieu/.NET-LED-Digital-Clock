using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedClock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.ledTimeDisplay1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.ledTimeDisplay1.Stop();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            this.ledTimeDisplay1.Pause();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            this.ledTimeDisplay1.Resume();
        }
    }
}
