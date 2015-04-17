using System;
using System.Collections.Generic;
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
        private Dictionary<DateTime, Dictionary<string, int>> Tasks;
        private Dictionary<DateTime, int> TimeSpentPerDay;
        private DateTime Today = DateTime.Now.Date;

        /// <summary>
        ///  Default constructor;
        ///  Set transparency for Custom Form.
        ///  Create Condensed View Form for OTF time tracking.
        /// </summary>
        public TimeTrackerForm()
        {
            InitializeComponent();

            Tasks = new Dictionary<DateTime, Dictionary<string, int>>();
            TimeSpentPerDay = new Dictionary<DateTime, int>();

            CondensedView = new TimeTrackerCondensedForm(OnTaskStop);
            CondensedView.Show();
        }

        private void btnClearTaskLog_Click(object sender, EventArgs e)
        {
            ExportLog();
            txtTasks.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Really Close?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
                Close();
        }

        private void btnExportDay_Click(object sender, EventArgs e)
        {
            ExportLog();
        }

        private void cbTimeWorkedDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetHourMinuteSecond(GetTotalTaskTime());
        }

        private void cbTimeWorkedTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetHourMinuteSecond(GetTotalTaskTime());
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

        private int GetTotalTaskTime()
        {
            var seconds = 0;

            if (cbTimeWorkedDate.SelectedItem == "Any Day" || cbTimeWorkedDate.SelectedItem == null)
            {
                foreach (var entry in Tasks)
                    foreach (var task in entry.Value)
                    {
                        if (cbTimeWorkedTask.SelectedItem == null ||
                            task.Key == cbTimeWorkedTask.SelectedItem.ToString() ||
                            cbTimeWorkedTask.SelectedItem == "Any Task")
                        {
                            seconds += task.Value;
                        }
                    }
            }
            else
            {
                foreach (var entry in Tasks[DateTime.Parse(cbTimeWorkedDate.SelectedItem.ToString())])
                {
                    if (cbTimeWorkedTask.SelectedItem == null ||
                        entry.Key == cbTimeWorkedTask.SelectedItem.ToString() ||
                        cbTimeWorkedTask.SelectedItem == "Any Task")
                    {
                        seconds += entry.Value;
                    }
                }
            }

            return seconds;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void OnTaskStop()
        {
            //: Get Task Name
            var taskName = new TaskNameForm(Tasks);

            if (taskName.ShowDialog() != DialogResult.OK)
            {
                CondensedView.TaskCompleteCancel();
                return;
            }

            //: Task String Ops
            var secondsThisTask = (CondensedView.HOURS * 3600) + (CondensedView.MINUTES * 60) + CondensedView.SECONDS;
            var taskExists = false;

            if (!Tasks.ContainsKey(Today))
            {
                Tasks.Add(Today, new Dictionary<string, int>());
            }

            foreach (var task in Tasks[Today])
            {
                taskExists = task.Key == taskName.TaskName;

                if (taskExists) break;
            }

            if (taskExists)
            {
                Tasks[Today][taskName.TaskName] += secondsThisTask;
            }
            else
            {
                Tasks[Today].Add(taskName.TaskName, secondsThisTask);
            }

            if (!cbTimeWorkedTask.Items.Contains(taskName.TaskName))
            {
                cbTimeWorkedTask.Items.Add(taskName.TaskName);
            }

            txtTasks.Text =
                string.Format(
                    "You spent {0} hours, {1} minutes, and {2} seconds\r\n -- On {3}\r\n\r\n{4}",
                    CondensedView.HOURS,
                    CondensedView.MINUTES,
                    CondensedView.SECONDS,
                    taskName.TaskName,
                    txtTasks.Text);

            //: Task Date / Seconds Ops
            if (!TimeSpentPerDay.ContainsKey(Today))
            {
                TimeSpentPerDay.Add(Today, 0);
                cbTimeWorkedDate.Items.Add(Today);
                Refresh();
            }

            TimeSpentPerDay[Today] += (CondensedView.HOURS * 3600) + (CondensedView.MINUTES * 60) + CondensedView.SECONDS;

            if (Today != DateTime.Now.Date)
            {
                txtTasks.Text =
                    string.Format(
                        "{0}\r\n==========================\r\n{1}",
                        DateTime.Now.ToShortDateString(),
                        txtTasks.Text);

                Today = DateTime.Now.Date;
            }

            CondensedView.TaskComplete();
        }
        private void SetHourMinuteSecond(int seconds)
        {
            var hours = seconds / 3600;
            seconds %= 3600;

            var minutes = seconds / 60;
            seconds %= 60;

            txtHours.Text = hours.ToString();
            txtMinutes.Text = minutes.ToString();
            txtSeconds.Text = seconds.ToString();
        }
    }
}