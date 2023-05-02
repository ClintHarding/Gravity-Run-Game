namespace Gravity_Run_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Player = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblscore = new Label();
            lblHighScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            coin = new PictureBox();
            gameOverGif = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameOverGif).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.platform_tilespink;
            pictureBox1.Location = new Point(-6, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(814, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.platform_tilespink;
            pictureBox2.Location = new Point(-6, 399);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(827, 58);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = Properties.Resources.run_up02;
            Player.Location = new Point(145, 38);
            Player.Name = "Player";
            Player.Size = new Size(65, 78);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 2;
            Player.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.box;
            pictureBox3.Location = new Point(305, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "obstacle";
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.box;
            pictureBox4.Location = new Point(543, 315);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 87);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "obstacle";
            // 
            // lblscore
            // 
            lblscore.AutoSize = true;
            lblscore.BackColor = Color.Transparent;
            lblscore.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblscore.ForeColor = Color.Snow;
            lblscore.Location = new Point(12, 9);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(91, 30);
            lblscore.TabIndex = 5;
            lblscore.Text = "Score: 0";
            lblscore.Click += lblscore_Click;
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.BackColor = Color.Transparent;
            lblHighScore.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHighScore.ForeColor = Color.Snow;
            lblHighScore.Location = new Point(12, 411);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(145, 30);
            lblHighScore.TabIndex = 6;
            lblHighScore.Text = "High Score: 0";
            lblHighScore.Click += label1_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimerEvent;
            // 
            // coin
            // 
            coin.BackColor = Color.Transparent;
            coin.Image = Properties.Resources.coin;
            coin.Location = new Point(163, 411);
            coin.Name = "coin";
            coin.Size = new Size(30, 33);
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.TabIndex = 7;
            coin.TabStop = false;
            // 
            // gameOverGif
            // 
            gameOverGif.BackColor = Color.Transparent;
            gameOverGif.Image = Properties.Resources.gameover;
            gameOverGif.Location = new Point(273, 164);
            gameOverGif.Name = "gameOverGif";
            gameOverGif.Size = new Size(248, 185);
            gameOverGif.SizeMode = PictureBoxSizeMode.StretchImage;
            gameOverGif.TabIndex = 8;
            gameOverGif.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pixel_city_chill;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(gameOverGif);
            Controls.Add(coin);
            Controls.Add(lblHighScore);
            Controls.Add(lblscore);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(Player);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "   ";
            Load += Form1_Load;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameOverGif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox Player;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblscore;
        private Label lblHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox coin;
        private PictureBox gameOverGif;
        private PictureBox pictureBox5;
    }
}