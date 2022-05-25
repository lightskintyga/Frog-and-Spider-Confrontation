using System;
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

        public static bool right, left, jump = true;
        public static int jumpSpeed = 1;
        public static int snakeSpeed = 1;

        Random random = new Random();
        public static int spiderSpeed = 1, spd;
        public static int frogScore, spiderScore, p;

        void MakeGameLogic()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "fly")
                {
                    Fly.MaximumHeight(x);

                    Intersection.ContactPlayerWithFly(player, lable_frog_score, p, random, x);

                    Intersection.ContactSpiderWithFly(spider, label_spider_score, p, random, x);

                    Winner.WinFrog(frogScore, timer1, label_frogWin);

                    Winner.WinSpider(spiderScore, timer1, label_spiderWin);

                    Intersection.ContactPlayerWithSpiderAndSnake(player, enemySnake, spider, timer1, label_over);
                }
            }
        }

        void MoveSnake()
        {
            Snake.DirectRight(enemySnake);

            Snake.DirectLeft(enemySnake);

            Spider.DirectDown(spider);

            Spider.DirectUp(spider, random);
        }

        void MovePlayer()
        {
            Player.MoveRight(player, right);

            Player.MoveLeft(player, left);

            Player.JumpRight(player, jump, right);

            Player.JumpLeft(player, jump, left);

            Player.GoDown(player, jump, water);

            Player.LimitUpperBorder(player);

            Player.LimitRightBorder(player);

            Player.LimitLeftBorder(player);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MovePlayer();
            MoveSnake();
            MakeGameLogic();
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            Keys.DownKeys(sender, e);
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            Keys.UpKeys(sender, e);
        }
    }
}
