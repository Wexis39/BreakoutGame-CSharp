using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TableTennis
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += KeyControl;
            MakeObstacle();
        }

        List<PictureBox> removeObstacleList = new List<PictureBox>();
        int score = 0;
        bool engelleCarpıstı = false;
        private void RemoveObstacle()
        {
            foreach (var item in obstacleList)
            {
                if (Ball.Bounds.IntersectsWith(item.Bounds))
                {
                    removeObstacleList.Add(item);
                    engelleCarpıstı = true;
                    score++;
                    lbScore.Text = score.ToString();
                    break;
                }
            }
        }

        PictureBox obstacle;
        List<PictureBox> obstacleList = new List<PictureBox>();

        private void MakeObstacle()
        {
            Random rnd = new Random();
            int posX = 70;
            int posY = 100;

            for (int i = 0; i < 3; i++)
            {
                posX = 70;
                for (int j = 0; j < 8; j++)
                {
                    obstacle = new PictureBox();
                    obstacle.Size = new Size(70, 20);
                    obstacle.Location = new Point(posX, posY);
                    int R = rnd.Next(0, 255), G = rnd.Next(0, 200), B = rnd.Next(0, 255);
                    obstacle.BackColor = Color.FromArgb(R, G, B);
                    obstacleList.Add(obstacle);
                    this.Controls.Add(obstacle);
                    posX += 90;
                }
                posY+=40;
            }
        }

        int playerSpeed = 13;
        private void KeyControl(object sender, KeyEventArgs e)
        {
            Point oldPosition = new Point(pnlPlayer.Location.X, pnlPlayer.Location.Y);

            if (e.KeyCode == Keys.Left)
            {
                pnlPlayer.Location = new Point(pnlPlayer.Location.X - playerSpeed, pnlPlayer.Location.Y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                pnlPlayer.Location = new Point(pnlPlayer.Location.X + playerSpeed, pnlPlayer.Location.Y);
            }
            if (pnlPlayer.Bounds.IntersectsWith(pnlLeftWall.Bounds) || pnlPlayer.Bounds.IntersectsWith(pnlRightWall.Bounds))
            {
                pnlPlayer.Location = oldPosition;

            }

        }
        
        int ballSpeed  = 7;
        bool kesistiMi = false;
        int leftRightDirection;

        private void tmrBallMovement_Tick(object sender, EventArgs e)
        {
            RemoveObstacle();
            foreach (var item in removeObstacleList)
            {
                this.Controls.Remove(item);
                obstacleList.Remove(item);

            }
            if (Ball.Bounds.IntersectsWith(pnlPlayer.Bounds))
            {
                Random rnd = new Random();
                leftRightDirection = rnd.Next(-12, 13);
                kesistiMi = true;
            }
            if (Ball.Bounds.IntersectsWith(pnlUpWall.Bounds))
            {
                kesistiMi = false;
            }
            if (engelleCarpıstı)
            {
                Ball.Location = new Point(Ball.Location.X + leftRightDirection, Ball.Location.Y + ballSpeed);
                kesistiMi = false;
                engelleCarpıstı=false;
            }
            if (kesistiMi)
            {
                Ball.Location = new Point(Ball.Location.X + leftRightDirection, Ball.Location.Y - ballSpeed);
            }
            else
            {
                Ball.Location = new Point(Ball.Location.X + leftRightDirection, Ball.Location.Y + ballSpeed);
                kesistiMi = false;
            }
            if (Ball.Bounds.IntersectsWith(pnlRightWall.Bounds))
            {
                leftRightDirection *= -1;
            }
            if (Ball.Bounds.IntersectsWith(pnlLeftWall.Bounds))
            {
                leftRightDirection *= -1;
            }
            GameOverAndWinCheck();
        }  
        private void GameOverAndWinCheck()
        {
            if (Ball.Location.Y > 620)
            {
                tmrBallMovement.Stop();
                GameOverForm gameOverForm = new GameOverForm(score);
                gameOverForm.Show();
                this.Hide();
            }
            if(score == 24)
            {
                tmrBallMovement.Stop();
                GameOverForm gameOverForm = new GameOverForm(score);
                gameOverForm.Show();
                this.Hide();
            }
        }
    }
}
