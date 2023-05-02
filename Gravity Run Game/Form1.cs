using System.Media;

namespace Gravity_Run_Game
{
    public partial class Form1 : Form
    {
        // Global Variables
        int gravity;
        int gravityValue = 8;
        int obstacleSpeed = 10;
        int score = 0;
        int highScore = 0;
        bool gameOver = false;
        Random random = new Random();

        SoundPlayer player = new SoundPlayer(@"C:\Users\cbatt\source\repos\Gravity Run Game\Another Winter.wav");
        SoundPlayer over = new SoundPlayer(@"C:\Users\cbatt\source\repos\Gravity Run Game\gameover.wav");

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblscore_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            lblscore.Text = "Score: " + score;
            lblHighScore.Text = "High Score: " + highScore;
            Player.Top += gravity;

            // When the player land on the platforms

            if (Player.Top > 330)
            {
                gravity = 0;
                Player.Top = 330;
                Player.Image = Properties.Resources.run_down0;
            }

            else if (Player.Top < 38)
            {
                gravity = 0;
                Player.Top = 38;
                Player.Image = Properties.Resources.run_up01;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = random.Next(1200, 3000);
                        score += 1;
                    }

                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        gameTimer.Stop();
                        player.Stop();
                        over.Play();
                        gameOverGif.Visible = true;
                        lblscore.Text += " Game Over! Press Enter to Restart.";
                        gameOver = true;

                        //highscore

                        if (score > highScore)
                        {
                            highScore = score;
                        }

                    }
                }
            }

            //speed  increase
            if (score > 5)
            {
                obstacleSpeed = 20;
                gravityValue = 12;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (Player.Top == 330)
                {
                    Player.Top -= 10;
                    gravity = -gravityValue;
                }

                else if (Player.Top == 38)
                {
                    Player.Top += 10;
                    gravity = gravityValue;
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

        }

        private void RestartGame()
        {
            gameOverGif.Visible = false;
            over.Stop();
            player.Play();
            lblscore.Parent = pictureBox1;  
            lblHighScore.Parent = pictureBox2;
            coin.Parent = pictureBox2;
            coin.Top = 0;
            lblHighScore.Top = 0;
            Player.Location = new Point(180, 149);
            Player.Image = Properties.Resources.run_down0;
            score = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 10;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left = random.Next(1200, 3000);
                }
            }

            gameTimer.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }
    }
}