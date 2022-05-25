using System.Windows.Forms;

namespace sharpGame
{
    class Keys
    {
        public static void DownKeys(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Right)
                Game.right = true;

            if (e.KeyCode == System.Windows.Forms.Keys.Left)
                Game.left = true;

            if (e.KeyCode == System.Windows.Forms.Keys.Space)
                Game.jump = true;
        }

        public static void UpKeys(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Right)
                Game.right = false;

            if (e.KeyCode == System.Windows.Forms.Keys.Left)
                Game.left = false;

            if (e.KeyCode == System.Windows.Forms.Keys.Space)
                Game.jump = false;
        }
    }
}
