namespace Time_Tracker
{
  partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClose = new System.Windows.Forms.Button();
            this._MNAREA = new System.Windows.Forms.Panel();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnFinishDay = new System.Windows.Forms.Button();
            this.btnNewDay = new System.Windows.Forms.Button();
            this.gbTasks = new System.Windows.Forms.GroupBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.notifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmrTimeout = new System.Windows.Forms.Timer(this.components);
            this.tmrMinute = new System.Windows.Forms.Timer(this.components);
            this._MNAREA.SuspendLayout();
            this.gbActions.SuspendLayout();
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
            this.gbActions.Controls.Add(this.btnFinishDay);
            this.gbActions.Controls.Add(this.btnNewDay);
            this.gbActions.Location = new System.Drawing.Point(426, 3);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(185, 256);
            this.gbActions.TabIndex = 1;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnFinishDay
            // 
            this.btnFinishDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinishDay.Location = new System.Drawing.Point(6, 48);
            this.btnFinishDay.Name = "btnFinishDay";
            this.btnFinishDay.Size = new System.Drawing.Size(84, 23);
            this.btnFinishDay.TabIndex = 1;
            this.btnFinishDay.Text = "Finish Day";
            this.btnFinishDay.UseVisualStyleBackColor = true;
            this.btnFinishDay.Click += new System.EventHandler(this.btnFinishDay_Click);
            // 
            // btnNewDay
            // 
            this.btnNewDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewDay.Location = new System.Drawing.Point(6, 19);
            this.btnNewDay.Name = "btnNewDay";
            this.btnNewDay.Size = new System.Drawing.Size(84, 23);
            this.btnNewDay.TabIndex = 0;
            this.btnNewDay.Text = "New Day";
            this.btnNewDay.UseVisualStyleBackColor = true;
            this.btnNewDay.Click += new System.EventHandler(this.btnNewDay_Click);
            // 
            // gbTasks
            // 
            this.gbTasks.Location = new System.Drawing.Point(10, 3);
            this.gbTasks.Name = "gbTasks";
            this.gbTasks.Size = new System.Drawing.Size(410, 256);
            this.gbTasks.TabIndex = 0;
            this.gbTasks.TabStop = false;
            this.gbTasks.Text = "Tasks";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.PeachPuff;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(45, 24);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Title";
            // 
            // notifier
            // 
            this.notifier.Text = "Task Timer Notification Agent";
            this.notifier.Visible = true;
            // 
            // tmrTimeout
            // 
            this.tmrTimeout.Interval = 60000;
            this.tmrTimeout.Tick += new System.EventHandler(this.tmrTimeout_Tick);
            // 
            // tmrMinute
            // 
            this.tmrMinute.Interval = 60000;
            this.tmrMinute.Tick += new System.EventHandler(this.tmrMinute_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 311);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this._MNAREA);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Time Tracker";
            this.TransparencyKey = System.Drawing.Color.White;
            this._MNAREA.ResumeLayout(false);
            this.gbActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Panel _MNAREA;
    private System.Windows.Forms.Label lbTitle;
    private System.Windows.Forms.NotifyIcon notifier;
    private System.Windows.Forms.GroupBox gbActions;
    private System.Windows.Forms.Button btnNewDay;
    private System.Windows.Forms.GroupBox gbTasks;
    private System.Windows.Forms.Timer tmrTimeout;
    private System.Windows.Forms.Timer tmrMinute;
    private System.Windows.Forms.Button btnFinishDay;
  }
}

