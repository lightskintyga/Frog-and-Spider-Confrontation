using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
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
            Application.Exit();
        }

        private void btn_question_Click(object sender, EventArgs e)
        {
            Form2 rules = new Form2();
            rules.ShowDialog();
        }
    }
}
