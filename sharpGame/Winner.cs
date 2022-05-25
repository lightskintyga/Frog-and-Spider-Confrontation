using System.Windows.Forms;

namespace sharpGame
{
    public class Winner
    {
        public static void WinFrog(int frogScore, Timer timer1, Label label_frogWin)
        {
            if (frogScore == 50)
            {
                timer1.Stop();
                label_frogWin.Visible = true;
                label_frogWin.BringToFront();
            }
        }

        public static void WinSpider(int spiderScore, Timer timer1, Label label_spiderWin)
        {
            if (spiderScore == 50)
            {
                timer1.Stop();
                label_spiderWin.Visible = true;
                label_spiderWin.BringToFront();
            }
        }
    }
}