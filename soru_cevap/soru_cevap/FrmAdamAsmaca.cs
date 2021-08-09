using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace soru_cevap
{
    public partial class FrmAdamAsmaca : Form
    {
        public FrmAdamAsmaca()
        {
            InitializeComponent();
        }
        #region Değişkenler
        string[] harfler = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "i", "ı", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z", "t" };
        Adam_Asmaca_Islemleri cl_adam_asmaca;
        string kelime;
        string[] secilen_harfler;
        int can_hakki = 7;
        int kalan_hakkımız;
        int width, height;
        #endregion
        private void FrmAdamAsmaca_Load(object sender, EventArgs e)
        {
            konum_ayarla();
            width = pctrAdam.Width;
            height = pctrAdam.Height;
            kalan_hakkımız = can_hakki;
            secilen_harfler = new string[0];
            cl_adam_asmaca = new Adam_Asmaca_Islemleri();
        }

        private void  kelime_sec()
        {
           Adam_Asmaca_Islemleri.YeniKelime kelimemiz = cl_adam_asmaca.kelime_al();
            lblkategori.Text = "Bu Bir  "+kelimemiz.kategori;
            kelime = kelimemiz.kelime;

            foreach (char harf in kelime.ToCharArray())
            {
                lblkelime.Text = lblkelime.Text + "_ ";
            }
            button1.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            lbl_soylenenler.Visible = true;
            lblkelime.Visible = true;
            lblkategori.Visible = true;
            button2.Visible = true;
            label1.Visible = true;
            pctrAdam.Visible = true;
            kelime_sec();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String veri = textBox1.Text;
            bool buldu = false;
            bool soylendi = false;
            foreach (var item in secilen_harfler)
            {
                if (veri.ToLower() == item.ToLower())
                {
                    soylendi = true;
                    MessageBox.Show("Bu Harfi Daha Önce Söylediniz ", "BİLDİRİM!!");
                }
            }

            if (!soylendi)
            {

                for (int i = 0; i < harfler.Length; i++) 
            {
                    
                if (veri.ToLower()==harfler[i])
                {
                    buldu = true;
                    kelimede_bul(veri);
                    break;
                }
            }
            if (!buldu)
            {
                MessageBox.Show("29 Harften Birini Yazınız!!", "BİLDİRİM");
            }
            guncelle();

            }
            int index = lblkelime.Text.IndexOf("_");
            if (index==-1)
            {
                sonraki_bolum();
            }
            textBox1.Clear();
        }

        private void kelimede_bul(string harf)
        {
            bool dogru_mu = false;
            char[] dizi = kelime.ToCharArray();
            for (int a=0; a < dizi.Length; a++) 
            {
                if (dizi[a].ToString() != "")
                {
                    if (harf==dizi[a].ToString().ToLower())
                    {
                        dogru_mu = true;
                        lblkelime.Text = lblkelime.Text.Remove(a * 2, 1);
                        lblkelime.Text = lblkelime.Text.Insert(a * 2, harf).ToUpper();                
                    }
                }
            }
            if (!dogru_mu)
            {
                kalan_hakkımız--;
                pctrAdam.Invalidate();
            }
            ekle_harf(harf);
        }

        private void guncelle()
        {
            lbl_soylenenler.Text = " ";
            foreach (string item in secilen_harfler)
            {
                lbl_soylenenler.Text = lbl_soylenenler.Text + item + " ";
            }
        }

        private void pctrAdam_Paint(object sender, PaintEventArgs e)
        {
            Pen kalem = new Pen(Color.Black, 12);
            if (kalan_hakkımız<can_hakki)
            {
                e.Graphics.DrawLine(kalem, width / 10, height / 15, width / 10, height / 15 * 14);
                e.Graphics.DrawLine(kalem, width / 10, height / 15, width / 2, height / 15);
            }
            if (kalan_hakkımız<can_hakki-1)//baş ve ip
            {
                e.Graphics.DrawLine(kalem, width / 2, height / 15, width / 2, height / 15 * 3);
                e.Graphics.DrawEllipse(kalem, width / 2 - width / 10, height / 5, width / 5, height / 10);
            }
            if (kalan_hakkımız<can_hakki-2)//gövde
            {
                e.Graphics.DrawLine(kalem, width / 2, height / 10 * 3, width / 2, height / 10 * 6);
            }
            if (kalan_hakkımız<can_hakki-3)//sağ kol
            {
                e.Graphics.DrawLine(kalem, width / 2, height / 10 * 3, width / 2 + width / 10, height / 10 * 3 + height / 5);
            }
            if (kalan_hakkımız<can_hakki-4)//kol
            {
                e.Graphics.DrawLine(kalem, width / 2, height / 10 * 3, width / 2 - width / 10, height / 10 * 3 + height / 5);
            }
            if (kalan_hakkımız<can_hakki-5)//sağ ayak
            {
                e.Graphics.DrawLine(kalem, width / 2, height / 10 * 6, width / 2 + width / 10, height / 10 * 6 + height / 10);
            }
            if (kalan_hakkımız < can_hakki - 6)//sol ayak
            {
                e.Graphics.DrawLine(kalem, width / 2, height / 10 * 6, width / 2 - width / 10, height / 10 * 6 + height / 10);
                oyun_bitti();
            }        

        }

        private void sonraki_bolum()
        {
            temizle();
            kelime_sec();
        }
        private   void oyun_bitti()
        {
            MessageBox.Show("OYUN BİTTİ. DOĞRU KELİME :  "+kelime, "BİLDİRİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            button1.Visible = true;
            textBox1.Visible = false;
            button2.Visible = false;
            pctrAdam.Visible = false;
            label1.Visible = false;
            temizle();
        }

        private void temizle()
        {
            secilen_harfler = new string[0];
            kalan_hakkımız = can_hakki;
            pctrAdam.Invalidate();
            lblkategori.Text = " ";
            lblkelime.Text = " ";
            lbl_soylenenler.Text = " ";
            textBox1.Text = " ";

        }

        private void FrmAdamAsmaca_SizeChanged(object sender, EventArgs e)
        {
            konum_ayarla();

        }
        public void konum_ayarla()
        {
            int width, heigth;
            width = this.Width;
            height = this.Height;
            panel1.Width = width;
            panel1.Height = height;
            panel1.Location = new Point(0, 0);
            pctrAdam.Width = width / 9 * 4;
            pctrAdam.Height = height / 4 * 3;
            pctrAdam.Location = new Point(width -pctrAdam.Width - 10, 10);
            lblkategori.Location = new Point(10, 10);
            lblkelime.Location = new Point(10, 50);
        }

        private void ekle_harf(string harf)
        {
            string[] a = new string[secilen_harfler.Length + 1];
            for (int i = 0; i < secilen_harfler.Length; i++)
            {
                a[i] = secilen_harfler[i];
            }
            a[a.Length  -1] = harf;
            secilen_harfler = a;
        }
    }     

    class Adam_Asmaca_Islemleri
    {
        private List<YeniKelime> yeni_kelime_listesi;
        private List<YeniKelime> kelime_liste;
        public Adam_Asmaca_Islemleri()
        {
            Data_dosyasını_al();
        }
      public struct YeniKelime
        {
          public string kelime;
          public string kategori;
        }
        public YeniKelime kelime_al()
        {
            if (kelime_liste.Count==0)
            {
                kelime_liste = yeni_kelime_listesi;
            }
            Random rasg = new Random();
            int a = rasg.Next(0, kelime_liste.Count);
            YeniKelime kelimemiz = kelime_liste[a];
            return kelimemiz;
        }
       private YeniKelime Yeni_kelime_olustur(string kelime , string kategori)
        {
            YeniKelime kelimemiz = new YeniKelime();
            kelimemiz.kelime = kelime;
            kelimemiz.kategori = kategori;
            return kelimemiz;
        }
        private void Data_dosyasını_al()
        {
            yeni_kelime_listesi = new List<YeniKelime>();
            StreamReader oku = new StreamReader(@"data.txt",Encoding.Default);
            string veri;
            while ((veri = oku.ReadLine()) != null) 
            {
                if (veri != " ")
                {
                    yeni_kelime_listesi.Add(Yeni_kelime_olustur(veri.Split(',')[0], veri.Split(',')[1]));
                }
            }
            kelime_liste = yeni_kelime_listesi;
        }
    }
}
