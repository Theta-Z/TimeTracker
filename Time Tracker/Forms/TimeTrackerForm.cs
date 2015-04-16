using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Time_Tracker.Helper;

namespace Time_Tracker.Forms
{
    /// <summary>
    ///   Used for keeping time.
    /// </summary>
    public partial class TimeTrackerForm : MovableForm
    {
        private TimeTrackerCondensedForm CondensedView;
        private DateTime Today = DateTime.Now.Date;

        /// <summary>
        ///  Default constructor;
        ///  Set transparency for Custom Form.
        ///  Create Condensed View Form for OTF time tracking.
        /// </summary>
        public TimeTrackerForm()
        {
            InitializeComponent();
            TransparencyKey = Color.FromArgb(50, 50, 50);

            CondensedView = new TimeTrackerCondensedForm(
                () =>
                {
                    //: Get Task Name
                    var taskName = new TaskNameForm();
                    while (taskName.ShowDialog() != DialogResult.OK) { }

                    txtTasks.Text =
                        string.Format(
                            "You spent {0} hours, {1} minutes, and {2} seconds\r\n -- On {3}\r\n\r\n{4}",
                            CondensedView.HOURS,
                            CondensedView.MINUTES,
                            CondensedView.SECONDS,
                            taskName.TaskName,
                            txtTasks.Text);

                    if (Today != DateTime.Now.Date)
                    {
                        txtTasks.Text =
                            string.Format(
                                "{0}\r\n==========================\r\n{1}",
                                DateTime.Now.ToShortDateString(),
                                txtTasks.Text);

                        Today = DateTime.Now.Date;
                    }
                });
            CondensedView.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Really Close?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
                Close();
        }

        private void btnClearTaskLog_Click(object sender, EventArgs e)
        {
            ExportLog();
            txtTasks.Text = string.Empty;
        }

        private void ExportLog()
        {
            Directories.CreateLocalDirectoryIfNotExists("Logs");
            using (var sw = new StreamWriter(string.Format(@"Logs\{0}.txt", DateTime.Now.Ticks)))
            {
                sw.Write(txtTasks.Text);
                sw.Close();
            }
        }

        private void btnExportDay_Click(object sender, EventArgs e)
        {
            ExportLog();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}