using System;
using System.Drawing;
using System.Windows.Forms;

namespace sharpGame
{
    class Spider
    {
        public static void DirectDown(PictureBox spider)
        {
            if (spider.Top > 10)
                Game.spiderSpeed -= 4;
        }

        public static void DirectUp(PictureBox spider, Random random)
        {
            if (spider.Top < -200)
            {
                Game.spd = random.Next(0, 550);
                spider.Location = new Point(Game.spd, -200);
                Game.spiderSpeed = 4;
            }
            spider.Top += Game.spiderSpeed;
        }
    }
}
