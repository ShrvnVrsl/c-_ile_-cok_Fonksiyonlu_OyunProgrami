using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_cevap
{
    public partial class FrmFlappybird : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        public FrmFlappybird()
        {
            InitializeComponent();
        }

        private void gameTimer(object sender, EventArgs e)
        {
            pictureBox_Bird.Top += gravity;
            pictureBox_Boru.Left -= pipeSpeed;
            picturebox_top.Left -= pipeSpeed;
            label1.Text = "SCORE: " + score;

            if (pictureBox_Boru.Left < -150)
            {
                pictureBox_Boru.Left = 800;
                score++;
            }
            if (picturebox_top.Left < -180)
            {
                picturebox_top.Left = 950;
                score++;
            }
            if (pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Boru.Bounds) ||
                pictureBox_Bird.Bounds.IntersectsWith(picturebox_top.Bounds) ||
                pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Ground.Bounds) || pictureBox_Bird.Top < -25)
            {
                EndGame();
            }
        }

        public void EndGame()
        {
            timer_GameControl.Stop();
            label1.Text = "GAME OVER!";
        }

        private void FrmFlappybird_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void FrmFlappybird_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
    }
}
