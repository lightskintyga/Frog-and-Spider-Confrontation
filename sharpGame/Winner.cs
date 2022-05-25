using System.Windows.Forms;

namespace sharpGame
{
    public class Winner
    {
        public static void WinFrog(int frogScore, Timer timer1, Label label_frogWin, PictureBox buttonRestart)
        {
            if (frogScore == 50)
            {
                timer1.Stop();
                label_frogWin.Visible = true;
                buttonRestart.Visible = true;
                label_frogWin.BringToFront();
            }
        }

        public static void WinSpider(int spiderScore, Timer timer1, Label label_spiderWin, PictureBox buttonRestart)
        {
            if (spiderScore == 50)
            {
                timer1.Stop();
                label_spiderWin.Visible = true;
                buttonRestart.Visible = true;
                label_spiderWin.BringToFront();
            }
        }
    }
}