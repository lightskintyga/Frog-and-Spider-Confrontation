using System;
using System.Drawing;
using System.Windows.Forms;

namespace sharpGame
{
    class Intersection
    {
        public static void ContactPlayerWithFly(PictureBox player, Label lable_frog_score, int p, Random random, Control x)
        {
            if (player.Bounds.IntersectsWith(x.Bounds))
            {
                Game.frogScore += 1;
                lable_frog_score.Text = "Frog : " + Game.frogScore;
                p = random.Next(100, 500);
                x.Location = new Point(p, 500);
            }
        }

        public static void ContactSpiderWithFly(PictureBox spider, Label label_spider_score, int p, Random random, Control x)
        {
            if (spider.Bounds.IntersectsWith(x.Bounds))
            {
                Game.spiderScore += 5;
                label_spider_score.Text = "Spider : " + Game.spiderScore;
                p = random.Next(100, 500);
                x.Location = new Point(p, 500);
            }
        }

        public static void ContactPlayerWithSpiderAndSnake(PictureBox player, PictureBox enemySnake, PictureBox spider, Timer timer1, Label label_over, PictureBox buttonRestart)
        {
            if (player.Bounds.IntersectsWith(enemySnake.Bounds) || player.Bounds.IntersectsWith(spider.Bounds))
            {
                timer1.Stop();
                label_over.Visible = true;
                buttonRestart.Visible = true;
                label_over.BringToFront();
            }
        }
    }
}
