namespace flappy_bird
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
            this.scoreText = new System.Windows.Forms.Label();
            this.lowerPipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.upperPipe = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lowerPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(2, 3);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(210, 59);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // lowerPipe
            // 
            this.lowerPipe.Image = global::flappy_bird.Properties.Resources.pipe;
            this.lowerPipe.Location = new System.Drawing.Point(273, 396);
            this.lowerPipe.Name = "lowerPipe";
            this.lowerPipe.Size = new System.Drawing.Size(92, 260);
            this.lowerPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowerPipe.TabIndex = 3;
            this.lowerPipe.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::flappy_bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-18, 581);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(568, 101);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // upperPipe
            // 
            this.upperPipe.Image = global::flappy_bird.Properties.Resources.pipedown;
            this.upperPipe.Location = new System.Drawing.Point(386, -47);
            this.upperPipe.Name = "upperPipe";
            this.upperPipe.Size = new System.Drawing.Size(100, 263);
            this.upperPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upperPipe.TabIndex = 1;
            this.upperPipe.TabStop = false;
            this.upperPipe.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::flappy_bird.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(12, 254);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(78, 63);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(535, 655);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.lowerPipe);
            this.Controls.Add(this.upperPipe);
            this.Controls.Add(this.scoreText);
            this.Name = "Form1";
            this.Text = "Flappy bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.lowerPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox lowerPipe;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox upperPipe;
        private System.Windows.Forms.Timer gameTimer;
    }
}

