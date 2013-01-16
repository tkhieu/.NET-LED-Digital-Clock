namespace LedClock
{
    partial class LedTimeDisplay
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lxLedControl = new Led.Controls.LxLedControl();
            this.lxLedControl1 = new Led.Controls.LxLedControl();
            this.msTimer = new System.Windows.Forms.Timer(this.components);
            this.timerPause = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // lxLedControl
            // 
            this.lxLedControl.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl.BackColor_1 = System.Drawing.Color.Black;
            this.lxLedControl.BackColor_2 = System.Drawing.Color.DimGray;
            this.lxLedControl.BevelRate = 0.5F;
            this.lxLedControl.FadedColor = System.Drawing.Color.DimGray;
            this.lxLedControl.ForeColor = System.Drawing.Color.LightGreen;
            this.lxLedControl.HighlightOpaque = ((byte)(50));
            this.lxLedControl.Location = new System.Drawing.Point(4, 4);
            this.lxLedControl.Name = "lxLedControl";
            this.lxLedControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lxLedControl.Size = new System.Drawing.Size(343, 75);
            this.lxLedControl.TabIndex = 0;
            this.lxLedControl.Text = "LXLEDCONTROL1";
            this.lxLedControl.TotalCharCount = 9;
            // 
            // lxLedControl1
            // 
            this.lxLedControl1.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl1.BackColor_1 = System.Drawing.Color.Black;
            this.lxLedControl1.BackColor_2 = System.Drawing.Color.DimGray;
            this.lxLedControl1.BevelRate = 0.5F;
            this.lxLedControl1.FadedColor = System.Drawing.Color.DimGray;
            this.lxLedControl1.ForeColor = System.Drawing.Color.DeepPink;
            this.lxLedControl1.HighlightOpaque = ((byte)(50));
            this.lxLedControl1.Location = new System.Drawing.Point(4, 85);
            this.lxLedControl1.Name = "lxLedControl1";
            this.lxLedControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lxLedControl1.Size = new System.Drawing.Size(343, 84);
            this.lxLedControl1.TabIndex = 1;
            this.lxLedControl1.Text = "";
            this.lxLedControl1.TotalCharCount = 9;
            // 
            // msTimer
            // 
            this.msTimer.Interval = 10;
            this.msTimer.Tick += new System.EventHandler(this.MsTimerTick);
            // 
            // timerPause
            // 
            this.timerPause.Tick += new System.EventHandler(this.timerPause_Tick);
            // 
            // LedTimeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lxLedControl1);
            this.Controls.Add(this.lxLedControl);
            this.Name = "LedTimeDisplay";
            this.Size = new System.Drawing.Size(353, 174);
            this.Load += new System.EventHandler(this.LedTimeDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private Led.Controls.LxLedControl lxLedControl;
        private Led.Controls.LxLedControl lxLedControl1;
        private System.Windows.Forms.Timer msTimer;
        private System.Windows.Forms.Timer timerPause;
    }
}
