namespace Snake_project
{
    partial class MenuForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.ScreenShotButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.yourScore = new System.Windows.Forms.Label();
            this.HighScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartButton.Location = new System.Drawing.Point(645, 30);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(146, 73);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartGame);
            this.StartButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartGameMC);
            // 
            // ScreenShotButton
            // 
            this.ScreenShotButton.BackColor = System.Drawing.Color.Lime;
            this.ScreenShotButton.Location = new System.Drawing.Point(645, 121);
            this.ScreenShotButton.Name = "ScreenShotButton";
            this.ScreenShotButton.Size = new System.Drawing.Size(146, 45);
            this.ScreenShotButton.TabIndex = 1;
            this.ScreenShotButton.Text = "LeaderBoard";
            this.ScreenShotButton.UseVisualStyleBackColor = false;
            this.ScreenShotButton.Click += new System.EventHandler(this.TakeScreenshot);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(639, 722);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxGraph);
            // 
            // yourScore
            // 
            this.yourScore.AutoSize = true;
            this.yourScore.Location = new System.Drawing.Point(657, 216);
            this.yourScore.Name = "yourScore";
            this.yourScore.Size = new System.Drawing.Size(58, 13);
            this.yourScore.TabIndex = 3;
            this.yourScore.Text = "yourScore:";
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.Location = new System.Drawing.Point(657, 263);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(60, 13);
            this.HighScore.TabIndex = 3;
            this.HighScore.Text = "HighScore:";
            // 
            // timer
            // 
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 734);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.yourScore);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ScreenShotButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ScreenShotButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label yourScore;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.Timer timer;
    }
}

