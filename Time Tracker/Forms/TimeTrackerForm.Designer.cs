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
            this.gbTasks.Controls.Add(this.txtTasks);
            this.gbTasks.Location = new System.Drawing.Point(10, 3);
            this.gbTasks.Name = "gbTasks";
            this.gbTasks.Size = new System.Drawing.Size(473, 256);
            this.gbTasks.TabIndex = 0;
            this.gbTasks.TabStop = false;
            this.gbTasks.Text = "Tasks";
            // 
            // txtTasks
            // 
            this.txtTasks.Location = new System.Drawing.Point(6, 14);
            this.txtTasks.MaxLength = 9999999;
            this.txtTasks.Multiline = true;
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.ReadOnly = true;
            this.txtTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTasks.Size = new System.Drawing.Size(461, 238);
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
            this.TransparencyKey = System.Drawing.Color.Transparent;
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
  }
}

