using System;
using System.Windows.Forms;

namespace Time_Tracker.Forms
{
    public partial class TaskNameForm : Form
    {
        public string TaskName { get; set; }

        public TaskNameForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskName.Text.Trim()))
            {
                err.SetError(txtTaskName, "This shouldn't be empty.");
                return;
            }

            TaskName = txtTaskName.Text;
        }

        private void txtTaskName_TextChanged(object sender, EventArgs e)
        {
            if (txtTaskName.Text.Length > 1)
            {
                btnSubmit.DialogResult = DialogResult.OK;
            }
        }
    }
}