namespace u23
{
    partial class microphone
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changeTheme = new System.Windows.Forms.Button();
            this.micophoneButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(36, 283);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(113, 29);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Enter text";
            this.inputLabel.Click += new System.EventHandler(this.inputLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(150, 242);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 146);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // changeTheme
            // 
            this.changeTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTheme.Location = new System.Drawing.Point(573, 318);
            this.changeTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeTheme.Name = "changeTheme";
            this.changeTheme.Size = new System.Drawing.Size(176, 52);
            this.changeTheme.TabIndex = 7;
            this.changeTheme.Text = "Change theme";
            this.changeTheme.UseVisualStyleBackColor = true;
            this.changeTheme.Click += new System.EventHandler(this.changeTheme_Click);
            // 
            // micophoneButton
            // 
            this.micophoneButton.BackgroundImage = global::u23.Properties.Resources.micrphone1;
            this.micophoneButton.Location = new System.Drawing.Point(573, 242);
            this.micophoneButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.micophoneButton.Name = "micophoneButton";
            this.micophoneButton.Size = new System.Drawing.Size(48, 52);
            this.micophoneButton.TabIndex = 6;
            this.micophoneButton.UseVisualStyleBackColor = true;
            this.micophoneButton.UseWaitCursor = true;
            this.micophoneButton.Click += new System.EventHandler(this.micophoneButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackgroundImage = global::u23.Properties.Resources.stop_button_icon;
            this.stopButton.Location = new System.Drawing.Point(363, 397);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(56, 54);
            this.stopButton.TabIndex = 5;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.BackgroundImage = global::u23.Properties.Resources.resume_button_icon;
            this.resumeButton.Location = new System.Drawing.Point(306, 398);
            this.resumeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(48, 49);
            this.resumeButton.TabIndex = 4;
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = global::u23.Properties.Resources.pause_button_icon;
            this.pauseButton.Location = new System.Drawing.Point(252, 397);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(45, 51);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::u23.Properties.Resources.play_button_icon;
            this.playButton.Location = new System.Drawing.Point(196, 397);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(46, 51);
            this.playButton.TabIndex = 2;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(1063, 626);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(112, 45);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // microphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.changeTheme);
            this.Controls.Add(this.micophoneButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inputLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "microphone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text to speech convertor";
            this.Load += new System.EventHandler(this.microphone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button micophoneButton;
        private System.Windows.Forms.Button changeTheme;
        private System.Windows.Forms.Button settingsButton;
    }
}

