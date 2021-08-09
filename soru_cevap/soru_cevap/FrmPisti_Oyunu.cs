using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace soru_cevap
{
    public partial class FrmPisti_Oyunu : Form
    {
        public FrmPisti_Oyunu()
        {
            puan_kullanici = 0;
            puan_rakip = 0;
            kartlar = new List<kart>();
            InitializeComponent();
        }

        Image resim;
        List<kart> kartlar;
        List<kart> kartlar_aktif;
        List<kart> ortadaki_kartlar;
        kart en_son_atilan_kart;
        int kart_sayisi_toplam;
        int kart_sayisi_kullanici;
        int kart_sayisi_rakip;
        int kart_sayisi_orta;
        bool sira_bende = true;
        int puan_kullanici;
        int puan_rakip;
        Thread th1;
        bool oyun_acik;
        bool is_ben_aldm;
        bool wait;
        Image desen;
        PictureBox anim_kart;
        bool anim_run;
        bool anim_card_run;
        Image back_ground_card;
        Image pisti_a;
        Image pisti_b;
        int a;
        string komut = "devam";
        public static int puan_toplam_kul;
        public static int puan_toplam_pc;
        public static bool devam_veya_cik;
        int el;
        public static int max_el;
        public static int zorluk;

        private void FrmPisti_Oyunu_Load(object sender, EventArgs e)
        {
            a = Convert.ToInt32(pcb_pisti.Tag);
            pcb_pisti.Visible = false;
            string file_n = "";
            try
            {
                file_n = "pisti_1.png";
                pisti_a = Image.FromFile(@"pisti_1.png");
                file_n = "pisti_2.png";
                pisti_b = Image.FromFile(@"pisti_2.png");
                this.WindowState = FormWindowState.Maximized;
                file_n = "cards.png";
                back_ground_card = Image.FromFile(@"cards.png");
                wait = false;
                file_n = "desen.jpg";
                desen = Image.FromFile(@"desen.jpg");
                timer1.Start();
                file_n = "";
                Control.CheckForIllegalCrossThreadCalls = false;
                file_n = "kartlar.png";
                resim = Image.FromFile(@"kartlar.png");
                pcb_cards.BackgroundImage = desen;
                file_n = "";
            }
            catch (Exception ex)
            {
                if (file_n != "")
                {
                    MessageBox.Show(file_n + " Dosyası bulunamadı");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void rakip_kontrol()
        {
            while (true)
            {
                //try
                //{
                Application.DoEvents();
                if (komut == "bekle")
                {
                    Application.DoEvents();
                    Thread.Sleep(700);
                    pcb_pisti.Visible = false;
                }
                else if (komut == "sayi")
                {
                    Thread.Sleep(300);
                }

                komut = "a";
                if (sira_bende == false && anim_run == false && wait == false)
                {
                    bool kart_atti = false;
                    foreach (Control s in panel3.Controls)
                    {
                        int num = Convert.ToInt32(s.Tag.ToString().Split(';')[0]);
                        if (en_son_atilan_kart.numara == num)
                        {
                            PictureBox resimd = (PictureBox)s;
                            resimd.Location = new Point(0, 0);
                            panel3.Controls.Remove(resimd);

                            resimd.BringToFront();
                            resimd.Image = resimd.BackgroundImage;


                            kart_atti = true;
                            kart_sayisi_rakip--;
                            wait = true;
                            animasyon(ref resimd, new Point(panel3.Location.X + resimd.Size.Width, panel3.Location.Y));
                            break;
                        }
                    }
                    if (kart_atti == true)
                    {
                        continue;
                    }
                    else
                    {
                        Random rast = new Random();
                        int ax = rast.Next(0, panel3.Controls.Count);
                        PictureBox resimd = (PictureBox)panel3.Controls[ax];
                        resimd.Location = new Point(0, 0);
                        panel3.Controls.Remove(resimd);

                        resimd.BringToFront();
                        resimd.Image = resimd.BackgroundImage;


                        kart_atti = true;
                        kart_sayisi_rakip--;
                        wait = true;
                        animasyon(ref resimd, new Point(panel3.Location.X + resimd.Size.Width, panel3.Location.Y));

                    }
                }
                //}
                //catch(Exception ex) 
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }
        private void animasyon(ref PictureBox kart, Point konum)
        {
            anim_run = true;
            kart.Location = konum;
            pnl_arka.Controls.Add(kart);
            anim_kart = kart;
            timer2.Start();
        }
        private int puanla(bool is_oyun_acik = true)
        {
            int puan = 0;
            //if (ortadaki_kartlar.Count != 0)
            //{
            if (is_oyun_acik == false)
            {
                puan = puan + 3;
            }
            if (ortadaki_kartlar.Count == 2 && (ortadaki_kartlar[0].numara == ortadaki_kartlar[1].numara))
            {
                komut = "bekle";
                if (ortadaki_kartlar[0].numara == 11)
                {
                    ortayı_temizle();
                    return puan + 20;
                }
                pcb_pisti.Visible = true;

                ortayı_temizle();
                return puan + 10;
            }
            else
            {
                komut = "sayi";
                foreach (var item in ortadaki_kartlar)
                {
                    if (item.numara == 1)
                    {
                        puan++;
                    }
                    else if (item.numara == 11)
                    {
                        puan++;
                    }
                    else if (item.numara == 2 && item.sembol == 0)
                    {
                        puan = puan + 2;
                    }
                    else if (item.numara == 10 && item.sembol == 3)
                    {
                        puan = puan + 3;
                    }
                }

            }

            ortayı_temizle();
            //}



            return puan;
        }
        private void ortayı_temizle()
        {
            if (ortadaki_kartlar != null)
            {
                ortadaki_kartlar.Clear();
            }
            panel2.Controls.Clear();
            panel2.BackgroundImage = null;
            en_son_atilan_kart = new kart();
            en_son_atilan_kart.numara = -1;
        }
        public void kiside_kart_yok()
        {
            if (panel3.Controls.Count == 0 && panel1.Controls.Count == 0)
            {
                kartlari_dagıt();
            }
        }
        public void oyun_bitir()
        {

        }
        public void kartlari_parcala()
        {
            Bitmap bmp_res = new Bitmap(resim);
            int w = 73;
            int h = 98;
            for (int x = 0; x < 13; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    kart yeni_kart = new kart();
                    yeni_kart.numara = x + 1;
                    yeni_kart.sembol = y;
                    yeni_kart.resmi = bmp_res.Clone(new Rectangle(x * w, y * h, w, h), resim.PixelFormat);
                    kartlar.Add(yeni_kart);
                }
            }

        }
        public void yeni_oyun()
        {
            giris q = new giris();
            q.ShowDialog();
            oyun_acik = true;
            ortadaki_kartlar = new List<kart>();
            kartlar_aktif = new List<kart>();
            for (int i = 0; i < kartlar.Count; i++)
            {
                kartlar_aktif.Add(kartlar[i]);
            }
            kart_sayisi_toplam = 52;
            kartlari_dagıt();
        }
        public void kartlari_dagıt()
        {
            if (kartlar_aktif.Count != 0)
            {
                Random rast = new Random();
                PictureBox resimf = new PictureBox();
                if (kartlar_aktif.Count == 52)
                {
                    for (int i = 0; i < 4; i++)
                    {

                        int a = 0;
                        a = rast.Next(0, kartlar_aktif.Count - 1);
                        resimf = new PictureBox();
                        resimf.Image = kartlar_aktif[a].resmi;
                        resimf.Tag = kartlar_aktif[a].numara + ";" + kartlar_aktif[a].sembol;
                        kartlar_aktif.RemoveAt(a);
                        resimf.Size = resimf.Image.Size;
                        resimf.Location = new Point(0, 0);
                        en_son_atilan_kart = kartlar_aktif[a];
                        ortadaki_kartlar.Add(kartlar_aktif[a]);
                        panel2.Controls.Add(resimf);

                    }
                }
                resimf.BringToFront();
                for (int i = 0; i < 4; i++)
                {

                    int a = 0;
                    a = rast.Next(0, kartlar_aktif.Count);
                    PictureBox resime = new PictureBox();
                    resime.Image = kartlar_aktif[a].resmi;
                    resime.Tag = kartlar_aktif[a].numara + ";" + kartlar_aktif[a].sembol;
                    kartlar_aktif.RemoveAt(a);
                    resime.Size = resime.Image.Size;
                    resime.Location = new Point(8 + 30 * i, 8);
                    resime.DoubleClick += new EventHandler(resim_Click);
                    resime.MouseHover += new EventHandler(resime_MouseEnter);
                    resime.MouseLeave += new EventHandler(resime_MouseLeave);
                    panel1.Controls.Add(resime);
                }
                for (int i = 0; i < 4; i++)
                {

                    int a = rast.Next(0, kartlar_aktif.Count);
                    PictureBox resime = new PictureBox();
                    resime.Image = desen;
                    resime.BackgroundImage = kartlar_aktif[a].resmi;
                    resime.SizeMode = PictureBoxSizeMode.StretchImage;
                    resime.Tag = kartlar_aktif[a].numara + ";" + kartlar_aktif[a].sembol;
                    kartlar_aktif.RemoveAt(a);
                    resime.Size = new Size(73, 98);
                    resime.Location = new Point(8 + 30 * i, 8);
                    panel3.Controls.Add(resime);
                }
                kart_sayisi_kullanici = 4;
                kart_sayisi_rakip = 4;
            }
            pcb_cards.Refresh();
        }

        void resime_MouseLeave(object sender, EventArgs e)
        {
            PictureBox[] pbd = new PictureBox[4];
            foreach (PictureBox pb in panel1.Controls)
            {
                int d = pb.Location.X / 30;
                pbd[d] = pb;
            }
            for (int i = 0; i < pbd.Length; i++)
            {
                if (pbd[i] != null)
                {
                    pbd[i].SendToBack();
                }
            }
        }

        void resime_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BringToFront();
        }

        public void resim_Click(object sender, EventArgs e)
        {
            if (sira_bende == true && anim_run == false)
            {
                PictureBox resimd = (sender as PictureBox);
                resimd.Location = new Point(0, 0);
                panel1.Controls.Remove(resimd);
                animasyon(ref resimd, new Point(panel1.Location.X + resimd.Size.Width, panel1.Location.Y));
                resimd.BringToFront();


                kart_sayisi_kullanici--;
            }
        }

        public bool degerlendir(int kart_numarasi, int sembol)
        {
            kart new_kart = kartlar[(kart_numarasi - 1) * 4 + sembol];
            ortadaki_kartlar.Add(new_kart);
            if (ortadaki_kartlar.Count != 0)
            {

                if (kart_numarasi == en_son_atilan_kart.numara)
                {
                    //aldığımızı kartları
                    return true;
                }
                else if (kart_numarasi == 11 && ortadaki_kartlar.Count > 1)
                {
                    return true;
                }
                else
                {



                }
                en_son_atilan_kart = new_kart;
            }
            return false;
        }

        
        private void oyun_bitti_mi()
        {
            if (kartlar_aktif.Count == 0 && kart_sayisi_kullanici == 0 && kart_sayisi_rakip == 0 && oyun_acik)
            {
                th1.Abort();
                oyun_acik = false;
                int puan = puanla(false);
                if (is_ben_aldm == true)
                {
                    puan_kullanici += puan;
                }
                else
                {
                    puan_rakip += puan;
                }
                puan_toplam_kul += puan_kullanici;
                puan_toplam_pc += puan_rakip;
                Son sn = new Son(puan_kullanici, puan_rakip);
                sn.ShowDialog();
                if (devam_veya_cik)
                {
                    dataGridView1.Rows.Add(puan_kullanici, puan_rakip);
                    el++;
                    el_bitir();
                }
                else
                {
                    puan_toplam_kul = 0;
                    puan_toplam_pc = 0;
                    el = 1;
                }
                lbl_toplam_puan_kulla.Text = puan_toplam_kul.ToString();
                lbl_toplam_puan_rakip.Text = puan_toplam_pc.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void FrmPisti_Oyunu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th1 != null)
            {
                th1.Abort();
            }
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (a < 5)
            {
                a++;
                pcb_pisti.Image = pisti_a;

            }
            else if (a < 10)
            {
                pcb_pisti.Image = pisti_b;
                a++;
            }
            else
            {
                a = 0;
            }
            if (anim_run)
            {
                anim_kart.BringToFront();
                if (anim_kart.Location.Y == panel2.Location.Y + panel2.Size.Height / 2 || (anim_kart.Location.Y + anim_kart.Size.Height > panel2.Location.Y + panel2.Size.Height / 2 && anim_kart.Location.Y + anim_kart.Size.Height < panel2.Location.Y + panel2.Size.Height / 2 + 10))
                {
                    anim_run = false;
                    panel2.Controls.Add(anim_kart);
                    anim_kart.BringToFront();
                    if (sira_bende == true)
                    {

                        if (degerlendir(Convert.ToInt32(anim_kart.Tag.ToString().Split(';')[0]), Convert.ToInt32(anim_kart.Tag.ToString().Split(';')[1])))
                        {
                            puan_kullanici += puanla();
                            is_ben_aldm = true;
                            lbl_puan_kullanici.Text = puan_kullanici.ToString();
                        }
                        sira_bende = false;
                    }
                    else
                    {
                        if (degerlendir(Convert.ToInt32(anim_kart.Tag.ToString().Split(';')[0]), Convert.ToInt32(anim_kart.Tag.ToString().Split(';')[1])))
                        {
                            puan_rakip += puanla();
                            is_ben_aldm = false;
                            lbl_puan_rakip.Text = puan_rakip.ToString();
                            panel2.Controls.Clear();
                        }
                        sira_bende = true;
                    }
                    if (ortadaki_kartlar.Count > 1)
                    {
                        panel2.BackgroundImage = back_ground_card;
                    }
                    anim_kart.Location = new Point(0, 0);
                    oyun_bitti_mi();
                    kiside_kart_yok();

                }
                else if (anim_kart.Location.Y > panel2.Location.Y + panel2.Size.Height / 2)
                {
                    anim_kart.Location = new Point(anim_kart.Location.X, anim_kart.Location.Y - 5);
                }
                else if (anim_kart.Location.Y < panel2.Location.Y + panel2.Size.Height / 2)
                {
                    anim_kart.Location = new Point(anim_kart.Location.X, anim_kart.Location.Y + 5);
                }
            }
            else
            {
                wait = false;
            }
        }
        private void pnl_arka_Paint(object sender, PaintEventArgs e)
        {

            SolidBrush firca = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(firca, new Rectangle(0, 0, pnl_arka.Width, 17));
            e.Graphics.FillRectangle(firca, new Rectangle(0, 0, 17, pnl_arka.Height));
            e.Graphics.FillRectangle(firca, new Rectangle(pnl_arka.Width - 17, 0, 17, pnl_arka.Height));
            e.Graphics.FillRectangle(firca, new Rectangle(0, pnl_arka.Height - 17, pnl_arka.Width, 17));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush firca = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(firca, new Rectangle(0, 0, panel3.Width, 8));
            e.Graphics.FillRectangle(firca, new Rectangle(0, 0, 8, panel3.Height));
            e.Graphics.FillRectangle(firca, new Rectangle(panel3.Width - 8, 0, 8, panel3.Height));
            e.Graphics.FillRectangle(firca, new Rectangle(0, panel3.Height - 8, panel3.Width, 8));
        }

        private void pcb_cards_Paint(object sender, PaintEventArgs e)
        {
            if (kartlar_aktif != null)
            {
                if (kartlar_aktif.Count > 0)
                {
                    pcb_cards.Visible = true;
                    SolidBrush kalem = new SolidBrush(Color.Black);
                    e.Graphics.DrawString(kartlar_aktif.Count.ToString(), new Font(this.Font.FontFamily, 25, FontStyle.Bold, GraphicsUnit.Pixel), kalem, new PointF(pcb_cards.Width / 3, pcb_cards.Height / 2));
                }
                else
                {
                    pcb_cards.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            el_bitir();
            puan_toplam_kul = 0;
            puan_toplam_pc = 0;
            lbl_toplam_puan_rakip.Text = "";
            lbl_toplam_puan_kulla.Text = "";
            dataGridView1.Rows.Clear();
        }

        public void el_bitir()
        {
            if (max_el >= el)
            {
                panel2.BackgroundImage = null;
                yeni_oyun_hazirlik();
                panel2.BackgroundImage = back_ground_card;
                kartlari_parcala();
                yeni_oyun();
                th1 = new Thread(rakip_kontrol);
                th1.IsBackground = true;
                th1.Start();
                pcb_cards.Refresh();
            }
            else
            {
                MessageBox.Show("gg");
            }
        }
        private void yeni_oyun_hazirlik()
        {
            ortayı_temizle();
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            if (kartlar_aktif != null)
            {
                kartlar_aktif.Clear();
            }
            if (kartlar != null)
            {
                kartlar.Clear();
            }
            puan_kullanici = 0;
            puan_rakip = 0;
            lbl_puan_kullanici.Text = "0";
            lbl_puan_rakip.Text = "0";
            panel2.BackgroundImage = null;
            pcb_cards.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

      


    }
}
