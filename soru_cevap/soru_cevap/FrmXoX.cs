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
    public partial class FrmXoX : Form
    {
        bool X_Sıra;
        bool O_Sıra ;
        int islem_sayısı =0;
        public FrmXoX()
        {
            InitializeComponent();
        }

        public void x_belirle()
        {
            //Yatay başlangıç

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")   
            {
                Temizle();
                MessageBox.Show("X KAZANDI", "TEBRİKLER");
            }


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                Temizle();
                MessageBox.Show("X KAZANDI", "TEBRİKLER");
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                Temizle();
                MessageBox.Show("X KAZANDI", "TEBRİKLER");
            }

            //Dikey Başlangıcı

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                Temizle();
                MessageBox.Show("X KAZANDI", "TEBRİKLER");
            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                Temizle();
                MessageBox.Show("X KAZANDI", "TEBRİKLER");
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                Temizle();
                MessageBox.Show("X KAZANDI", "TEBRİKLER");
            }

            //Çapraz başlangıcı

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                Temizle();
                MessageBox.Show("X KAZANDI", "TEBRİKLER");
            }


            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                Temizle();
                MessageBox.Show("X KAZANDI", "TEBRİKLER");
            }
        }

        public void o_belirle()
        {
            //Yatay başlangıç

            if (button1.Text == "O" && button2.Text == "0" && button3.Text == "O")
            {
                Temizle();
                MessageBox.Show("O KAZANDI", "TEBRİKLER");
            }


            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                Temizle();
                MessageBox.Show("O KAZANDI", "TEBRİKLER");
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "X")
            {
                Temizle();
                MessageBox.Show("O KAZANDI", "TEBRİKLER");
            }

            //Dikey Başlangıcı

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "X")
            {
                Temizle();
                MessageBox.Show("O KAZANDI", "TEBRİKLER");
            }


            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                Temizle();
                MessageBox.Show("O KAZANDI", "TEBRİKLER");
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                Temizle();
                MessageBox.Show("O KAZANDI", "TEBRİKLER");
            }

            //Çapraz başlangıcı

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                Temizle();
                MessageBox.Show("O KAZANDI", "TEBRİKLER");
            }


            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                Temizle();
                MessageBox.Show("O KAZANDI", "TEBRİKLER");
            }
        }

        public void Temizle()
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            islem_sayısı = 0;
        }
        public void Beraberlik()
        {
            if (islem_sayısı==9)
            {
                Temizle();
                MessageBox.Show("Berabere Bitti", "BERABERLİK");
            }
        }

        private void toplu_tık(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            islem_sayısı = islem_sayısı + islem_sayısı;

            if (X_Sıra)
            {
                X_Sıra = false;
                O_Sıra = true;

                b.Text = "X";
                b.Enabled = false;

                x_belirle();
                Beraberlik();
            }
            else if (O_Sıra)
            {
                X_Sıra = true;
                O_Sıra = false;

                b.Text = "O";
                b.Enabled = false;
                o_belirle();
                Beraberlik();
            }
        }

        private void FrmXoX_Load(object sender, EventArgs e)
        {
            X_Sıra = true;
        }
    }
}
