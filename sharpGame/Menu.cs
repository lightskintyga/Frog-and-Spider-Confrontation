using System;
using System.Windows.Forms;

namespace sharpGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Application.OpenForms["Form1"].Hide();
        }

        private void btn_play_MouseHover(object sender, EventArgs e)
        {
            btn_play.Image = Properties.Resources.playTrue;
        }

        private void btn_play_MouseLeave(object sender, EventArgs e)
        {
            btn_play.Image = Properties.Resources.playTrue;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Menu"].Dispose();    
            Game game = new Game();
            game.ShowDialog();
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exitTrue;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exitTrue;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Menu"].Dispose();
        }

        private void btn_question_Click(object sender, EventArgs e)
        {
            Form2 rules = new Form2();
            rules.ShowDialog();
        }
    }
}
