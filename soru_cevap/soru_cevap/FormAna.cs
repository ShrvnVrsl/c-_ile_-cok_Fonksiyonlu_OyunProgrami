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
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        Timer t = new Timer();
        int Genislik = 300, yukseklik = 300, Saniyeibre = 140, Dakikaibre = 110, Saatibre = 80;
        int OrtaX, OrtaY;
        Bitmap bmp;
        Graphics g;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Bilgi_yarismasi frm = new Bilgi_yarismasi();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKostebek frm2 = new FrmKostebek();
            frm2.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            int[] ibrekoordinat = new int[2];
            g.Clear(Color.White);
            g.DrawEllipse(new Pen(Color.Black, 1F), 0, 0, yukseklik, Genislik);

            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            ibrekoordinat = mscoord(ss, Saniyeibre);
            g.DrawLine(new Pen(Color.Red, 1F), new Point(OrtaX, OrtaY), new Point(ibrekoordinat[0], ibrekoordinat[1]));

            ibrekoordinat = mscoord(mm, Dakikaibre);
            g.DrawLine(new Pen(Color.Orange, 2F), new Point(OrtaX, OrtaY), new Point(ibrekoordinat[0], ibrekoordinat[1]));

            ibrekoordinat = hrcoord(hh %12,mm, Saatibre);
            g.DrawLine(new Pen(Color.Green, 3F), new Point(OrtaX, OrtaY), new Point(ibrekoordinat[0], ibrekoordinat[1]));


            pictureBox1.Image = bmp;
            this.Text = "Saat: " + hh + ":" + mm + ":" + ss;
            g.Dispose();

        }

        private int[] mscoord (int saniyedeger, int saataci)
        {
            int[] coord = new int[2];
            saniyedeger *= 6;
            if (saniyedeger >= 0 && saniyedeger <= 180) 
            {
                coord[0] = OrtaX + (int)(saataci * Math.Sin(Math.PI * saniyedeger / 180));
                coord[1] = OrtaY - (int)(saataci * Math.Cos(Math.PI * saniyedeger / 180));
            }
            else
            {
                coord[0] = OrtaX - (int)(saataci * -Math.Sin(Math.PI * saniyedeger / 180));
                coord[1] = OrtaY - (int)(saataci * Math.Cos(Math.PI * saniyedeger / 180));
            }
            return coord;
        }

        int[] coord = new int[2];
        private int[] hrcoord(int saatdeger, int dakikadeger, int saataci)
        {
            int val = (int)((saatdeger * 30) + (dakikadeger * 0.5));
            if (val>=0 && val <=180)
            {
                coord[0] = OrtaX + (int)(saataci * Math.Sin( Math.PI * val / 180));
                coord[1] = OrtaY - (int)(saataci * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = OrtaX - (int)(saataci * -Math.Sin(Math.PI * val / 180));
                coord[1] = OrtaY - (int)(saataci * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMayinTarlasi frm7 = new frmMayinTarlasi();
            frm7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmSehirBul fr8 = new FrmSehirBul();
            fr8.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("ÇIKIŞ yapmak istediğinize emin misiniz", "ÇIKIŞ YAPILSIN MI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmPinPonOyunu frm9 = new FrmPinPonOyunu();
            frm9.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmArabaYarisi fr10 = new FrmArabaYarisi();
            fr10.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmPisti_Oyunu fr11 = new FrmPisti_Oyunu();
            fr11.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmFlappybird fr12 = new FrmFlappybird();
            fr12.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmXoX frm3 = new FrmXoX();
            frm3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAdamAsmaca frm4 = new FrmAdamAsmaca();
            frm4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmYilanOyunu frm5 = new FrmYilanOyunu();
            frm5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKelimeOyunu frm6 = new FrmKelimeOyunu();
            frm6.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(Genislik + 1, yukseklik + 1);
            OrtaX = Genislik / 2;
            OrtaY = yukseklik / 2;
            this.BackColor = Color.White;
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }
    }
}
