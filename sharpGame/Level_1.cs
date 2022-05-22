using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharpGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            label_over.Visible = false;
            label_frogWin.Visible = false;
            label_spiderWin.Visible = false;
        }

        bool right, left, jump = true;
        int jumpSpeed = 1;
        int snakeSpeed = 1;

        Random random = new Random();
        int spiderSpeed = 1, spd;
        int frogScore, spiderScore, p;

        void MakeGameLogic()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "fly")
                {
                    x.Top -= 3;
                    if (x.Top < 200)
                        x.Top = 200;

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        frogScore += 1;
                        lable_frog_score.Text = "Frog : " + frogScore;
                        p = random.Next(100, 500);
                        x.Location = new Point(p, 500);
                    }

                    if (spider.Bounds.IntersectsWith(x.Bounds))
                    {
                        spiderScore += 5;
                        label_spider_score.Text = "Spider : " + spiderScore;
                        p = random.Next(100, 500);
                        x.Location = new Point(p, 500);
                    }

                    if (frogScore == 50)
                    {
                        timer1.Stop();
                        label_frogWin.Visible = true;
                        label_frogWin.BringToFront();
                    }

                    if (spiderScore == 50)
                    {
                        timer1.Stop();
                        label_spiderWin.Visible = true;
                        label_spiderWin.BringToFront();
                    }

                    if (player.Bounds.IntersectsWith(enemySnake.Bounds) || player.Bounds.IntersectsWith(spider.Bounds))
                    {
                        timer1.Stop();
                        label_over.Visible = true;
                        label_over.BringToFront();
                    }
                }
            }
        }

        void MoveSnake()
        {
            if (enemySnake.Left > 500)
                snakeSpeed -= 1;

            if (enemySnake.Left < 50)
                snakeSpeed = 1;
            enemySnake.Left += snakeSpeed;
            
            if (spider.Top > 10)
                spiderSpeed -= 4;

            if (spider.Top < -200)
            {
                spd = random.Next(0, 550);
                spider.Location = new Point(spd, -200);
                spiderSpeed = 4;
            }
            spider.Top += spiderSpeed;
        }

        void MovePlayer()
        {
            if (right == true)
            {
                player.Left += 2;
                player.Image = Properties.Resources.frogRightOrig1;
            }

            if (left == true)
            {
                player.Left -= 2;
                player.Image = Properties.Resources.frogLeftOrig1;
            }

            if (jump == true && right)
            {
                player.Top -= 2;
                player.Left += 3;
                player.Image = Properties.Resources.frogRightOrig1;
                jumpSpeed = 3;
            }

            if (jump == true && left)
            {
                player.Top -= 2;
                player.Left -= 3;
                player.Image = Properties.Resources.frogLeftOrig1;
                jumpSpeed = 3;
            }

            if (jump == false)
            {
                player.Top += jumpSpeed;
                if (player.Bounds.IntersectsWith(water.Bounds))
                {
                    player.Top = water.Top - player.Height;
                    jumpSpeed = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MovePlayer();
            MoveSnake();
            MakeGameLogic();
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {   
            if (e.KeyCode == Keys.Right)
                right = true;

            if (e.KeyCode == Keys.Left)
                left = true;

            if (e.KeyCode == Keys.Space)
                jump = true;
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = false;

            if (e.KeyCode == Keys.Left)
                left = false;

            if (e.KeyCode == Keys.Space)
                jump = false;
        }
    }
}
