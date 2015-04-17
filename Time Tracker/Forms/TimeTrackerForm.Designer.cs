namespace Time_Tracker.Forms
{
  partial class TimeTrackerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTrackerForm));
            this.btnClose = new System.Windows.Forms.Button();
            this._MNAREA = new System.Windows.Forms.Panel();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnExportDay = new System.Windows.Forms.Button();
            this.btnClearTaskLog = new System.Windows.Forms.Button();
            this.gbTasks = new System.Windows.Forms.GroupBox();
            this.cbTimeWorkedTask = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.cbTimeWorkedDate = new System.Windows.Forms.ComboBox();
            this.txtTasks = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this._MNAREA.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.gbTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(594, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // _MNAREA
            // 
            this._MNAREA.BackColor = System.Drawing.Color.PeachPuff;
            this._MNAREA.Controls.Add(this.gbActions);
            this._MNAREA.Controls.Add(this.gbTasks);
            this._MNAREA.Location = new System.Drawing.Point(6, 44);
            this._MNAREA.Name = "_MNAREA";
            this._MNAREA.Size = new System.Drawing.Size(617, 262);
            this._MNAREA.TabIndex = 1;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnExportDay);
            this.gbActions.Controls.Add(this.btnClearTaskLog);
            this.gbActions.Location = new System.Drawing.Point(489, 3);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(122, 256);
            this.gbActions.TabIndex = 1;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnExportDay
            // 
            this.btnExportDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportDay.Location = new System.Drawing.Point(6, 19);
            this.btnExportDay.Name = "btnExportDay";
            this.btnExportDay.Size = new System.Drawing.Size(110, 23);
            this.btnExportDay.TabIndex = 2;
            this.btnExportDay.Text = "Export Task Log";
            this.btnExportDay.UseVisualStyleBackColor = true;
            this.btnExportDay.Click += new System.EventHandler(this.btnExportDay_Click);
            // 
            // btnClearTaskLog
            // 
            this.btnClearTaskLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearTaskLog.Location = new System.Drawing.Point(6, 227);
            this.btnClearTaskLog.Name = "btnClearTaskLog";
            this.btnClearTaskLog.Size = new System.Drawing.Size(110, 23);
            this.btnClearTaskLog.TabIndex = 1;
            this.btnClearTaskLog.Text = "Clear Task Log";
            this.btnClearTaskLog.UseVisualStyleBackColor = true;
            this.btnClearTaskLog.Click += new System.EventHandler(this.btnClearTaskLog_Click);
            // 
            // gbTasks
            // 
            this.gbTasks.Controls.Add(this.cbTimeWorkedTask);
            this.gbTasks.Controls.Add(this.textBox4);
            this.gbTasks.Controls.Add(this.textBox3);
            this.gbTasks.Controls.Add(this.textBox2);
            this.gbTasks.Controls.Add(this.textBox1);
            this.gbTasks.Controls.Add(this.txtSeconds);
            this.gbTasks.Controls.Add(this.txtMinutes);
            this.gbTasks.Controls.Add(this.txtHours);
            this.gbTasks.Controls.Add(this.cbTimeWorkedDate);
            this.gbTasks.Controls.Add(this.txtTasks);
            this.gbTasks.Location = new System.Drawing.Point(10, 3);
            this.gbTasks.Name = "gbTasks";
            this.gbTasks.Size = new System.Drawing.Size(473, 256);
            this.gbTasks.TabIndex = 0;
            this.gbTasks.TabStop = false;
            this.gbTasks.Text = "Tasks";
            // 
            // cbTimeWorkedTask
            // 
            this.cbTimeWorkedTask.FormattingEnabled = true;
            this.cbTimeWorkedTask.Items.AddRange(new object[] {
            "Any Task"});
            this.cbTimeWorkedTask.Location = new System.Drawing.Point(364, 62);
            this.cbTimeWorkedTask.Name = "cbTimeWorkedTask";
            this.cbTimeWorkedTask.Size = new System.Drawing.Size(103, 21);
            this.cbTimeWorkedTask.TabIndex = 15;
            this.cbTimeWorkedTask.Text = "<Task>";
            this.cbTimeWorkedTask.SelectedIndexChanged += new System.EventHandler(this.cbTimeWorkedTask_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(364, 213);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(103, 13);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Seconds";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(364, 163);
            this.textBox3.MaxLength = 10;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(103, 13);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Minutes";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(364, 19);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(103, 13);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Time Worked On";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(364, 113);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(103, 13);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Hours";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSeconds
            // 
            this.txtSeconds.BackColor = System.Drawing.Color.PeachPuff;
            this.txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeconds.Cursor = System.Windows.Forms.Cursors.No;
            this.txtSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeconds.Location = new System.Drawing.Point(364, 232);
            this.txtSeconds.MaxLength = 10;
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.ReadOnly = true;
            this.txtSeconds.Size = new System.Drawing.Size(103, 13);
            this.txtSeconds.TabIndex = 10;
            this.txtSeconds.Text = "--";
            this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.PeachPuff;
            this.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinutes.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutes.Location = new System.Drawing.Point(364, 182);
            this.txtMinutes.MaxLength = 10;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.ReadOnly = true;
            this.txtMinutes.Size = new System.Drawing.Size(103, 13);
            this.txtMinutes.TabIndex = 9;
            this.txtMinutes.Text = "--";
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.Color.PeachPuff;
            this.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHours.Cursor = System.Windows.Forms.Cursors.No;
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(364, 132);
            this.txtHours.MaxLength = 10;
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(103, 13);
            this.txtHours.TabIndex = 8;
            this.txtHours.Text = "--";
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbTimeWorkedDate
            // 
            this.cbTimeWorkedDate.FormattingEnabled = true;
            this.cbTimeWorkedDate.Items.AddRange(new object[] {
            "Any Day"});
            this.cbTimeWorkedDate.Location = new System.Drawing.Point(364, 35);
            this.cbTimeWorkedDate.Name = "cbTimeWorkedDate";
            this.cbTimeWorkedDate.Size = new System.Drawing.Size(103, 21);
            this.cbTimeWorkedDate.TabIndex = 4;
            this.cbTimeWorkedDate.Text = "<Day>";
            this.cbTimeWorkedDate.SelectedIndexChanged += new System.EventHandler(this.cbTimeWorkedDate_SelectedIndexChanged);
            // 
            // txtTasks
            // 
            this.txtTasks.Location = new System.Drawing.Point(6, 14);
            this.txtTasks.MaxLength = 9999999;
            this.txtTasks.Multiline = true;
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.ReadOnly = true;
            this.txtTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTasks.Size = new System.Drawing.Size(352, 238);
            this.txtTasks.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Andy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.PeachPuff;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(130, 27);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Time Tracker";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimize.Font = new System.Drawing.Font("Jing Jing", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblMinimize.Location = new System.Drawing.Point(565, 9);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(23, 25);
            this.lblMinimize.TabIndex = 3;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // TimeTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 311);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this._MNAREA);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeTrackerForm";
            this.Text = "Time Tracker";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._MNAREA.ResumeLayout(false);
            this.gbActions.ResumeLayout(false);
            this.gbTasks.ResumeLayout(false);
            this.gbTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Panel _MNAREA;
    private System.Windows.Forms.Label lbTitle;
    private System.Windows.Forms.GroupBox gbActions;
    private System.Windows.Forms.GroupBox gbTasks;
    private System.Windows.Forms.Button btnClearTaskLog;
    private System.Windows.Forms.Button btnExportDay;
    private System.Windows.Forms.TextBox txtTasks;
    private System.Windows.Forms.Label lblMinimize;
    private System.Windows.Forms.ComboBox cbTimeWorkedDate;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox txtSeconds;
    private System.Windows.Forms.TextBox txtMinutes;
    private System.Windows.Forms.TextBox txtHours;
    private System.Windows.Forms.ComboBox cbTimeWorkedTask;
  }
}

