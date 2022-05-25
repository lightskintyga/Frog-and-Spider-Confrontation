using System.Windows.Forms;

namespace sharpGame
{
    class Fly
    {
        public static void MaximumHeight(Control x)
        {
            x.Top -= 3;
            if (x.Top < 200)
                x.Top = 200;
        }
    }
}
