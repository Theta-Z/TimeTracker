using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Time_Tracker.Forms
{
    public partial class TaskNameForm : Form
    {
        public string TaskName { get; set; }

        public TaskNameForm(Dictionary<DateTime, Dictionary<string, int>> tasks)
        {
            InitializeComponent();
            System.Threading.Thread.SpinWait(50);

            foreach (var entry in tasks)
            foreach (var task in entry.Value)
            {
                if(!cbTaskList.Items.Contains(task.Key))
                    cbTaskList.Items.Add(task.Key);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbTaskList.Text.Trim()))
            {
                TaskName = cbTaskList.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}