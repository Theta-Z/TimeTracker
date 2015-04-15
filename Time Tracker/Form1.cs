using System;
using System.Windows.Forms;
using Gma.UserActivityMonitor;

namespace Time_Tracker
{
    /// <summary>
    ///   Used for keeping time.
    /// </summary>
    public partial class Form1 : Form
    {
        #region movable form

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }
            base.WndProc(ref m);
        }

        #endregion

        //:Tasks
        private int MINUTESIDLE;
        private bool TIMEOUT;

        public Form1()
        {
            InitializeComponent();

            HookManager.KeyPress += new KeyPressEventHandler(HookManager_KeyPress);
            HookManager.MouseMove += new MouseEventHandler(HookManager_MouseMove);

            tmrTimeout.Start();
            System.Threading.Thread.SpinWait(50);
            tmrMinute.Start();

            MINUTESIDLE = 0;
        }

        private void AddTimeToTask(int minutes)
        {
            //: TODO-- find which RB is checked. Add Time to it.
        }

        private void IDLEOVER()
        {
            //: TODO-- show form with idle tasks. [meeting / thinking / support / etc]
            //--set task first

            AddTimeToTask(MINUTESIDLE);
            MINUTESIDLE = 0;
        }

        private void NewDay()
        {
            //: TODO-- erase all old times, print to log what was done.
            using (var sw = new System.IO.StreamWriter(string.Format("{0}{1}.txt", "Log-", DateTime.Now.Ticks)))
            {
                sw.Close();
            }
        }

        #region global hooks
        public void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            if (MINUTESIDLE != 0)
            {
                IDLEOVER();
            }

            TIMEOUT = false;
        }

        public void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (MINUTESIDLE != 0)
            {
                IDLEOVER();
            }

            TIMEOUT = false;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Really Close?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
                Close();
        }

        private void tmrTimeout_Tick(object sender, EventArgs e)
        {
            if (TIMEOUT == true)
            {
                MINUTESIDLE++;
            }

            TIMEOUT = true;
        }

        private void tmrMinute_Tick(object sender, EventArgs e)
        {
            if (!TIMEOUT)
                AddTimeToTask(1);
        }

        private void btnNewDay_Click(object sender, EventArgs e)
        {
            NewDay();
        }
    }
}