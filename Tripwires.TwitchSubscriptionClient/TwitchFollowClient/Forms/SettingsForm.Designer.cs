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
            this.nmrTimer = new System.Windows.Forms.NumericUpDown();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.nmrFollowsPerTick = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFollowsPerTick)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(355, 94);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 94);
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
            this.lblTimer.Location = new System.Drawing.Point(13, 40);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(98, 13);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "Timer in N seconds";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(167, 93);
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
            this.lblNumberPerTicks.Location = new System.Drawing.Point(13, 62);
            this.lblNumberPerTicks.Name = "lblNumberPerTicks";
            this.lblNumberPerTicks.Size = new System.Drawing.Size(158, 13);
            this.lblNumberPerTicks.TabIndex = 7;
            this.lblNumberPerTicks.Text = "Max. Number of Follows per tick";
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 128);
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
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nmrTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFollowsPerTick)).EndInit();
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
    }
}