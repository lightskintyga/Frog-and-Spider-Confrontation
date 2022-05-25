using System.Windows.Forms;

namespace sharpGame
{
    class Player
    {
        public static void LimitUpperBorder(PictureBox player)
        {
            if (player.Top < 150)
                player.Top = 150;
        }

        public static void LimitRightBorder(PictureBox player)
        {
            if (player.Left > 530)
                player.Left = 530;
        }

        public static void LimitLeftBorder(PictureBox player)
        {
            if (player.Left < 0)
                player.Left = 0;
        }

        public static void MoveRight(PictureBox player, bool right)
        {
            if (right == true)
            {
                player.Left += 2;
                player.Image = Properties.Resources.frogRightOrig1;
            }
        }

        public static void MoveLeft(PictureBox player, bool left)
        {
            if (left == true)
            {
                player.Left -= 2;
                player.Image = Properties.Resources.frogLeftOrig1;
            }
        }

        public static void JumpRight(PictureBox player, bool jump, bool right)
        {
            if (jump == true && right)
            {
                player.Top -= 2;
                player.Left += 3;
                player.Image = Properties.Resources.frogRightOrig1;
                Game.jumpSpeed = 3;
            }
        }

        public static void JumpLeft(PictureBox player, bool jump, bool left)
        {
            if (jump == true && left)
            {
                player.Top -= 2;
                player.Left -= 3;
                player.Image = Properties.Resources.frogLeftOrig1;
                Game.jumpSpeed = 3;
            }
        }

        public static void GoDown(PictureBox player, bool jump, PictureBox water)
        {
            if (jump == false)
            {
                player.Top += Game.jumpSpeed;
                if (player.Bounds.IntersectsWith(water.Bounds))
                {
                    player.Top = water.Top - player.Height;
                    Game.jumpSpeed = 0;
                }
            }
        }
    }
}
