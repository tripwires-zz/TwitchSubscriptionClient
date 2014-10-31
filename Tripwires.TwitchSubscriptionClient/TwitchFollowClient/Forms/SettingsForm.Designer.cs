namespace TwitchFollowClient
{
    partial class SettingsForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblNumberPerTicks = new System.Windows.Forms.Label();
            this.lblNotificationSound = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtNotificationSound = new System.Windows.Forms.TextBox();
            this.ntfSoundFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.nmrFollowsPerTick = new System.Windows.Forms.NumericUpDown();
            this.nmrTimer = new System.Windows.Forms.NumericUpDown();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFollowsPerTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(350, 135);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chanel name";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(13, 39);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(98, 13);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "Timer in N seconds";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(162, 135);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(101, 23);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "&Restore defaults";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblNumberPerTicks
            // 
            this.lblNumberPerTicks.AutoSize = true;
            this.lblNumberPerTicks.Location = new System.Drawing.Point(13, 66);
            this.lblNumberPerTicks.Name = "lblNumberPerTicks";
            this.lblNumberPerTicks.Size = new System.Drawing.Size(158, 13);
            this.lblNumberPerTicks.TabIndex = 7;
            this.lblNumberPerTicks.Text = "Max. Number of Follows per tick";
            // 
            // lblNotificationSound
            // 
            this.lblNotificationSound.AutoSize = true;
            this.lblNotificationSound.Location = new System.Drawing.Point(13, 99);
            this.lblNotificationSound.Name = "lblNotificationSound";
            this.lblNotificationSound.Size = new System.Drawing.Size(94, 13);
            this.lblNotificationSound.TabIndex = 9;
            this.lblNotificationSound.Text = "Notification Sound";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(394, 96);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtNotificationSound
            // 
            this.txtNotificationSound.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TwitchFollowClient.Properties.Settings.Default, "NotificationSoundFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNotificationSound.Location = new System.Drawing.Point(183, 96);
            this.txtNotificationSound.Name = "txtNotificationSound";
            this.txtNotificationSound.Size = new System.Drawing.Size(205, 20);
            this.txtNotificationSound.TabIndex = 10;
            // 
            // ntfSoundFileDialog
            // 
            this.ntfSoundFileDialog.FileName = global::TwitchFollowClient.Properties.Settings.Default.NotificationSoundFile;
            this.ntfSoundFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ntfSoundFileDialog_FileOk);
            // 
            // nmrFollowsPerTick
            // 
            this.nmrFollowsPerTick.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::TwitchFollowClient.Properties.Settings.Default, "PageSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nmrFollowsPerTick.Location = new System.Drawing.Point(303, 64);
            this.nmrFollowsPerTick.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nmrFollowsPerTick.Name = "nmrFollowsPerTick";
            this.nmrFollowsPerTick.Size = new System.Drawing.Size(120, 20);
            this.nmrFollowsPerTick.TabIndex = 8;
            this.nmrFollowsPerTick.Value = global::TwitchFollowClient.Properties.Settings.Default.PageSize;
            // 
            // nmrTimer
            // 
            this.nmrTimer.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::TwitchFollowClient.Properties.Settings.Default, "Timer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nmrTimer.Location = new System.Drawing.Point(304, 37);
            this.nmrTimer.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nmrTimer.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrTimer.Name = "nmrTimer";
            this.nmrTimer.Size = new System.Drawing.Size(120, 20);
            this.nmrTimer.TabIndex = 5;
            this.nmrTimer.Value = global::TwitchFollowClient.Properties.Settings.Default.Timer;
            // 
            // txtChannelName
            // 
            this.txtChannelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TwitchFollowClient.Properties.Settings.Default, "ChannelName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtChannelName.Location = new System.Drawing.Point(183, 10);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(242, 20);
            this.txtChannelName.TabIndex = 3;
            this.txtChannelName.Text = global::TwitchFollowClient.Properties.Settings.Default.ChannelName;
            this.txtChannelName.TextChanged += new System.EventHandler(this.txtChannelName_TextChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 170);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtNotificationSound);
            this.Controls.Add(this.lblNotificationSound);
            this.Controls.Add(this.nmrFollowsPerTick);
            this.Controls.Add(this.lblNumberPerTicks);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.nmrTimer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txtChannelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nmrFollowsPerTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChannelName;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NumericUpDown nmrTimer;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblNumberPerTicks;
        private System.Windows.Forms.NumericUpDown nmrFollowsPerTick;
        private System.Windows.Forms.Label lblNotificationSound;
        private System.Windows.Forms.TextBox txtNotificationSound;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ntfSoundFileDialog;
    }
}