using System.Windows.Forms;

namespace sharpGame
{
    class Restart
    {
        public static void Work()
        {
            Application.Restart();
            Game.check = false;
        }
    }
}
