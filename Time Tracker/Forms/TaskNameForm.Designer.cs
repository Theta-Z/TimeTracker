namespace Time_Tracker.Forms
{
    partial class TaskNameForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskNameForm));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHiddenSubmit = new System.Windows.Forms.Button();
            this.cbTaskList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(12, 38);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(158, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnHiddenSubmit
            // 
            this.btnHiddenSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHiddenSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHiddenSubmit.Location = new System.Drawing.Point(115, 51);
            this.btnHiddenSubmit.Name = "btnHiddenSubmit";
            this.btnHiddenSubmit.Size = new System.Drawing.Size(10, 10);
            this.btnHiddenSubmit.TabIndex = 3;
            this.btnHiddenSubmit.UseVisualStyleBackColor = true;
            this.btnHiddenSubmit.Visible = false;
            // 
            // cbTaskList
            // 
            this.cbTaskList.FormattingEnabled = true;
            this.cbTaskList.Location = new System.Drawing.Point(12, 9);
            this.cbTaskList.Name = "cbTaskList";
            this.cbTaskList.Size = new System.Drawing.Size(221, 21);
            this.cbTaskList.TabIndex = 4;
            // 
            // TaskNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 68);
            this.Controls.Add(this.cbTaskList);
            this.Controls.Add(this.btnHiddenSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(251, 96);
            this.MinimumSize = new System.Drawing.Size(251, 96);
            this.Name = "TaskNameForm";
            this.Text = "What Task Was That?";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHiddenSubmit;
        private System.Windows.Forms.ComboBox cbTaskList;
    }
}