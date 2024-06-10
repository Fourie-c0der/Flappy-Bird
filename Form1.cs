using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class Form1 : Form
    {


        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            upperPipe.Left -= pipeSpeed;
            lowerPipe.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score.ToString();

            if (upperPipe.Left < -180)
            {
                upperPipe.Left = 950;
                score++;
            }
            if (lowerPipe.Left < -150)
            {
                lowerPipe.Left = 800;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(upperPipe.Bounds) || flappyBird.Bounds.IntersectsWith(lowerPipe.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 10;
            }

            if (score > 10)
            {
                pipeSpeed = 12;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }


        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.BringToFront(); 
            scoreText.Text = ""; 
            scoreText.Text += "Score: "+ score.ToString() +" Game Over!!!";
        }
    }
}
