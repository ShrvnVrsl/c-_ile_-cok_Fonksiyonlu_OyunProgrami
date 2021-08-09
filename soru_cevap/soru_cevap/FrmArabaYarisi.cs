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
    public partial class FrmArabaYarisi : Form
    {
        public FrmArabaYarisi()
        {
            InitializeComponent();
        }

        Araba yeni_araba;
        Motor yeni_motor;
        int hareket_mesafesi=50;
        bool ileri_git = false;
        int sayac = 0;
        int max_araba = 3;
        int suanki_araba = 0;
        private void FrmArabaYarisi_Load(object sender, EventArgs e)
        {
            yeni_motor = new m1();
            yeni_araba = new Araba(yeni_motor);
            yeni_araba.hiz = 70;
            //çizgi oluşturma
            for (int i = 0; i < panel1.Height; i++)
            {
                for (int t = 50; t < panel1.Width - 50; t++) 
                {
                    cizgi_olustur(t, i);
                    t = t + 150;              
                }
                i = i + 150;
            }

            timer1.Start();
        }

        private void rakip_araba_olustur()
        {
            PictureBox pb = new PictureBox();
            pb.Height = 100;
            pb.Width =60;
            Random rd = new Random();
            int xd = rd.Next(0, panel1.Width - pb.Width);
            pb.Location = new Point(xd, 0);
            pb.Name = "araba";
            pb.BackColor = Color.Turquoise;
            pb.Tag = (yeni_araba.hiz / 3*2).ToString();
            panel1.Controls.Add(pb);
            pb.BringToFront();
            
        }

        private void cizgi_olustur(int x, int y)
        {
            PictureBox cizgi = new PictureBox();
            cizgi.Width = 40;
            cizgi.Height = 100;
            cizgi.Name = "cizgi";
            cizgi.BackColor = Color.White;
            cizgi.Location = new Point(x, y);
            panel1.Controls.Add(cizgi);
            cizgi.SendToBack();
        }

        private void FrmArabaYarisi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ileri_git = true;

            }  

        }
      
        #region hareketler
        public void sola_git()
        {
            if (pbaraba.Location.X - hareket_mesafesi > 0) 
            {
                pbaraba.Location = new Point(pbaraba.Location.X - hareket_mesafesi, pbaraba.Location.Y);
            }
        }

        public void saga_git()
        {
            if (pbaraba.Location.X + hareket_mesafesi + pbaraba.Width < panel1.Width) 
            {
                pbaraba.Location = new Point(pbaraba.Location.X + hareket_mesafesi, pbaraba.Location.Y);
            }
        }
        #endregion

        private void FrmArabaYarisi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ileri_git = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                sola_git();
            }
            else if (e.KeyCode == Keys.Right)
            {
                saga_git();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac >= 15 && suanki_araba < max_araba) 
            {
                sayac = 0;
                rakip_araba_olustur();
                suanki_araba++;
            }
            else
            {
                sayac++;
            }

            if (ileri_git==true)
            {
                yeni_araba.hiz = yeni_araba.hiz + yeni_araba.ivme;
            }
            else
            {
                yeni_araba.hiz = yeni_araba.hiz - yeni_araba.yavaslama;
            }

            label1.Text = "Araba Hızı :  " + yeni_araba.hiz.ToString();

            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (panel1.Controls[i].Name=="cizgi")
                {
                    PictureBox pb = (PictureBox)panel1.Controls[i];
                    if (pb.Location.Y>panel1.Height)
                    {
                        pb.Location = new Point(pb.Location.X, max_deger(pb.Location.X)-150);
                    }
                    else
                    {
                        int deger = yeni_araba.hiz / 3;
                        pb.Location = new Point(pb.Location.X, pb.Location.Y + deger);
                      
                    }
                }
                else if (panel1.Controls[i].Name=="araba")
                {
                    PictureBox pb = (PictureBox)panel1.Controls[i];
                    if (((pbaraba.Location.X > pb.Location.X && pbaraba.Location.X < pb.Location.X + pb.Width)||pbaraba.Location.X+pbaraba.Width>pb.Location.X&&pbaraba.Location.X+pbaraba.Width<pb.Location.X+pb.Width) && pbaraba.Location.Y > pb.Location.Y && pbaraba.Location.Y < pb.Location.Y + pb.Height) 
                    {
                        timer1.Stop();
                        MessageBox.Show("OYUN BİTTİ");
                        
                    }

                    if (pb.Location.Y > panel1.Height)
                    {
                        panel1.Controls.RemoveAt(i);
                        suanki_araba--;
                    }
                    else
                    {
                        int hizz = Convert.ToInt32(pb.Tag);
                        pb.Location = new Point(pb.Location.X, pb.Location.Y + (yeni_araba.hiz - hizz)/5);

                    }
                }
            }
            }
         

        private int max_deger(int x)
        {
            int sonuc = panel1.Height;

            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (panel1.Controls[i].Name == "cizgi" && panel1.Controls[i].Location.X == x) 
                {
                    if (panel1.Controls[i].Location.Y < sonuc) 
                    {
                        sonuc = panel1.Controls[i].Location.Y;
                    }
                }
            }
            return sonuc;
        }
    }
}
