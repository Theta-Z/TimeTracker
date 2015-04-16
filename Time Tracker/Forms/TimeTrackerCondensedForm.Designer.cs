namespace Time_Tracker.Forms
{
    partial class TimeTrackerCondensedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTrackerCondensedForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmsTrackerRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsMenuSetBGColour = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuTxtColour = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPauseUnpause = new System.Windows.Forms.Label();
            this.lblCurrentTaskTime = new System.Windows.Forms.Label();
            this.lblStopTask = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.cmsTrackerRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.ContextMenuStrip = this.cmsTrackerRightClick;
            this.groupBox1.Controls.Add(this.lblPauseUnpause);
            this.groupBox1.Controls.Add(this.lblCurrentTaskTime);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 39);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Task";
            // 
            // cmsTrackerRightClick
            // 
            this.cmsTrackerRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsMenuSetBGColour,
            this.cmsMenuTxtColour});
            this.cmsTrackerRightClick.Name = "cmsTrackerRightClick";
            this.cmsTrackerRightClick.Size = new System.Drawing.Size(197, 48);
            // 
            // cmsMenuSetBGColour
            // 
            this.cmsMenuSetBGColour.Name = "cmsMenuSetBGColour";
            this.cmsMenuSetBGColour.Size = new System.Drawing.Size(196, 22);
            this.cmsMenuSetBGColour.Text = "Set Background Colour";
            this.cmsMenuSetBGColour.Click += new System.EventHandler(this.cmsMenuSetBGColour_Click);
            // 
            // cmsMenuTxtColour
            // 
            this.cmsMenuTxtColour.Name = "cmsMenuTxtColour";
            this.cmsMenuTxtColour.Size = new System.Drawing.Size(196, 22);
            this.cmsMenuTxtColour.Text = "Set Text Colour";
            this.cmsMenuTxtColour.Click += new System.EventHandler(this.cmsMenuTxtColour_Click);
            // 
            // lblPauseUnpause
            // 
            this.lblPauseUnpause.AutoSize = true;
            this.lblPauseUnpause.BackColor = System.Drawing.Color.Transparent;
            this.lblPauseUnpause.Font = new System.Drawing.Font("Jing Jing", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseUnpause.Location = new System.Drawing.Point(105, 12);
            this.lblPauseUnpause.Name = "lblPauseUnpause";
            this.lblPauseUnpause.Size = new System.Drawing.Size(24, 28);
            this.lblPauseUnpause.TabIndex = 2;
            this.lblPauseUnpause.Text = "▶";
            this.lblPauseUnpause.Click += new System.EventHandler(this.lblPauseUnpause_Click);
            // 
            // lblCurrentTaskTime
            // 
            this.lblCurrentTaskTime.AutoSize = true;
            this.lblCurrentTaskTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTaskTime.Font = new System.Drawing.Font("Jing Jing", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTaskTime.Location = new System.Drawing.Point(6, 12);
            this.lblCurrentTaskTime.Name = "lblCurrentTaskTime";
            this.lblCurrentTaskTime.Size = new System.Drawing.Size(89, 28);
            this.lblCurrentTaskTime.TabIndex = 0;
            this.lblCurrentTaskTime.Text = "0:00:00";
            // 
            // lblStopTask
            // 
            this.lblStopTask.AutoSize = true;
            this.lblStopTask.BackColor = System.Drawing.Color.Transparent;
            this.lblStopTask.ContextMenuStrip = this.cmsTrackerRightClick;
            this.lblStopTask.Font = new System.Drawing.Font("Jing Jing", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopTask.Location = new System.Drawing.Point(158, 12);
            this.lblStopTask.Name = "lblStopTask";
            this.lblStopTask.Size = new System.Drawing.Size(26, 28);
            this.lblStopTask.TabIndex = 3;
            this.lblStopTask.Text = "X";
            this.lblStopTask.Click += new System.EventHandler(this.lblStopTask_Click);
            // 
            // TimeTrackerCondensedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(191, 44);
            this.ContextMenuStrip = this.cmsTrackerRightClick;
            this.Controls.Add(this.lblStopTask);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(191, 44);
            this.MinimumSize = new System.Drawing.Size(191, 44);
            this.Name = "TimeTrackerCondensedForm";
            this.Text = "Time Tracker";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsTrackerRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentTaskTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip cmsTrackerRightClick;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuSetBGColour;
        private System.Windows.Forms.Label lblPauseUnpause;
        private System.Windows.Forms.Label lblStopTask;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuTxtColour;
    }
}