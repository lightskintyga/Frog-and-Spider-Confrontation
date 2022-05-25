using System.Windows.Forms;

namespace sharpGame
{
    class Snake
    {
        public static void DirectRight(PictureBox enemySnake)
        {
            if (enemySnake.Left > 500)
                Game.snakeSpeed -= 1;
        }

        public static void DirectLeft(PictureBox enemySnake)
        {
            if (enemySnake.Left < 50)
                Game.snakeSpeed = 1;
            enemySnake.Left += Game.snakeSpeed;
        }
    }
}
