using System;
using System.Drawing;
using System.Windows.Forms;
using Time_Tracker.Forms.Settings;
using Time_Tracker.Helper;

namespace Time_Tracker.Forms
{
    public partial class TimeTrackerCondensedForm : MovableForm
    {
        private Action OnTaskStop;
        private bool PAUSED;
        private TaskTimer SecTimer;
        private IFormSettings Settings;

        public string CurrentTask;

        public volatile short
            HOURS = 0,
            MINUTES = 0,
            SECONDS = 0;

        /// <summary>
        ///  Due to the multithreaded nature of Winforms UI vs Non-UI... We have this to set text of a control.
        /// </summary>
        /// <param name="c">The control to set the Text property of.</param>
        /// <param name="text">What you want the Text property to say.</param>
        private delegate void SetMultiThreadText(Control c, string text);

        /// <summary>
        ///  Due to the multithreaded nature of Winforms UI vs Non-UI... We have this to set text of a control.
        /// </summary>
        /// <param name="c">The control to set the Text property of.</param>
        /// <param name="text">What you want the Text property to say.</param>
        private void SetText(Control c, string text)
        {
            if (c.InvokeRequired)
            {
                var fp = new SetMultiThreadText(SetText);
                Invoke(fp, new object[] { c, text });
            }
            else
            {
                c.Text = text;
            }
        }

        /// <summary>
        ///  Constructor, of the default variety!
        /// </summary>
        public TimeTrackerCondensedForm(Action taskStop)
        {
            InitializeComponent();

            System.Threading.Thread.SpinWait(50);
            TransparencyKey = Color.FromArgb(12, 12, 12);
            PAUSED = true;

            Settings = new FormSettings("TTCF.cfg", "Settings");
            BackColor = Settings.GetBGColour();
            SetFGColours(Settings.GetFGColour());

            OnTaskStop = taskStop;
            SecTimer = new TaskTimer();
            SecTimer.SetTimerAction(
                (obj, evt) =>
                {
                    SECONDS++;
                    if (SECONDS >= 60)
                    {
                        SECONDS -= 60;
                        MINUTES++;
                    }
                    if (MINUTES >= 60)
                    {
                        MINUTES -= 60;
                        HOURS++;
                    }

                    SetText(lblCurrentTaskTime,
                        string.Format("{0}:{1}:{2}",
                            HOURS, MINUTES.ToString("00"), SECONDS.ToString("00")));
                });
        }

        private void lblPauseUnpause_Click(object sender, EventArgs e)
        {
            PAUSED = !PAUSED;

            if (PAUSED)
            {
                SecTimer.Stoptimer();
                lblPauseUnpause.Text = "▶";
            }
            else
            {
                SecTimer.StartTimer();
                lblPauseUnpause.Text = "II";
            }
        }

        private void cmsMenuSetBGColour_Click(object sender, EventArgs e)
        {
            var colourPicker = new ColorDialog();
            if (colourPicker.ShowDialog() == DialogResult.OK)
            {
                BackColor = colourPicker.Color;
                Settings.SetBGColour(colourPicker.Color);
            }
        }

        private void cmsMenuTxtColour_Click(object sender, EventArgs e)
        {
            var colourPicker = new ColorDialog();
            if (colourPicker.ShowDialog() == DialogResult.OK)
            {
                SetFGColours(colourPicker.Color);
                Settings.SetFGColour(colourPicker.Color);
            }
        }

        private void SetFGColours(Color c)
        {
            foreach (Control control in Controls)
                control.ForeColor = c;
        }

        private void lblStopTask_Click(object sender, EventArgs e)
        {
            PAUSED = true;
            SecTimer.Stoptimer();
            lblPauseUnpause.Text = "▶";

            OnTaskStop.Invoke();
        }

        public void TaskComplete()
        {
            HOURS = 0;
            MINUTES = 0;
            SECONDS = 0;
            lblCurrentTaskTime.Text = "0:00:00";
        }

        public void TaskCompleteCancel()
        {
            PAUSED = false;
            SecTimer.StartTimer();
            lblPauseUnpause.Text = "II";
        }
    }
}