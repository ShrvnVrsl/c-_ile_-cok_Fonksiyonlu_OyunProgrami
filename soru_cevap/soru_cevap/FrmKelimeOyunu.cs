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
    public partial class FrmKelimeOyunu : Form
    {
        public FrmKelimeOyunu()
        {
            InitializeComponent();
        }

        Random rasgele = new Random();
        int harfsayac = 0;
        int sayisayac = 0;
        private void btnharfgetir_Click(object sender, EventArgs e)
        {
            harfsayac++;
            string karakter1, karakter2, karakter3, karakter4, karakter5, karakter6, karakter7, karakter8;
            int harfler;
            string[] dizi = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "V", "Y", "Z"};

            if (harfsayac==1)
            {
                harfler = rasgele.Next(0, dizi.Length);
                karakter1 = (dizi[harfler]);
                btnharf1.Text = karakter1.ToString();
                btnharf1.Visible = true;
            }
            if (harfsayac == 2)
            {
                harfler = rasgele.Next(0, dizi.Length);
                karakter2 = (dizi[harfler]);
                btnharf2.Text = karakter2.ToString();
                btnharf2.Visible = true;
            }
            if (harfsayac == 3)
            {
                harfler = rasgele.Next(0, dizi.Length);
                karakter3 = (dizi[harfler]);
                btnharf3.Text = karakter3.ToString();
                btnharf3.Visible = true;
            }
            if (harfsayac == 4)
            {
                harfler = rasgele.Next(0, dizi.Length);
                karakter4 = (dizi[harfler]);
                btnharf4.Text = karakter4.ToString();
                btnharf4.Visible = true;
            }
            if (harfsayac == 5)
            {
                harfler = rasgele.Next(0, dizi.Length);
                karakter5 = (dizi[harfler]);
                btnharf5.Text = karakter5.ToString();
                btnharf5.Visible = true;
            }
            if (harfsayac == 6)
            {
                harfler = rasgele.Next(0, dizi.Length);
                karakter6 = (dizi[harfler]);
                btnharf6.Text = karakter6.ToString();
                btnharf6.Visible = true;
            }
            if (harfsayac == 7)
            {
                harfler = rasgele.Next(0, dizi.Length);
                karakter7 = (dizi[harfler]);
                btnharf7.Text = karakter7.ToString();
                btnharf7.Visible = true;
            }

            if (harfsayac == 8)
            {
                harfler = rasgele.Next(0, dizi.Length);
                karakter8 = (dizi[harfler]);
                btnharf8.Text = karakter8.ToString();
                btnharf8.Visible = true;
                btnjoker.Text = "?";
                btnjoker.Visible = true;
            }
        }

        private void btnsayigetir_Click(object sender, EventArgs e)
        {
            sayisayac++;
            string deger1, deger2, deger3, deger4, deger5, deger6;
            int deger7;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] dizi3 = { "50", "60", "75" };
            int sayilar;

            if (sayisayac==1)
            {
                sayilar = rasgele.Next(0, dizi2.Length);
                deger1 = (dizi2[sayilar]);
                btnsayi1.Text = deger1.ToString();
                btnsayi1.Visible = true;
            }
            if (sayisayac == 2)
            {
                sayilar = rasgele.Next(0, dizi2.Length);
                deger2 = (dizi2[sayilar]);
                btnsayi2.Text = deger2.ToString();
                btnsayi2.Visible = true;
            }
            if (sayisayac == 3)
            {
                sayilar = rasgele.Next(0, dizi2.Length);
                deger3 = (dizi2[sayilar]);
                btnsayi3.Text = deger3.ToString();
                btnsayi3.Visible = true;
            }
            if (sayisayac == 4)
            {
                sayilar = rasgele.Next(0, dizi2.Length);
                deger4 = (dizi2[sayilar]);
                btnsayi4.Text = deger4.ToString();
                btnsayi4.Visible = true;
            }
            if (sayisayac == 5)
            {
                sayilar = rasgele.Next(0, dizi2.Length);
                deger5 = (dizi2[sayilar]);
                btnsayi5.Text = deger5.ToString();
                btnsayi5.Visible = true;
            }
            if (sayisayac == 6)
            {
                sayilar = rasgele.Next(0, dizi3.Length);
                deger6 = (dizi3[sayilar]);
                btnsayi6.Text = deger6.ToString();
                btnsayi6.Visible = true;

                deger7 = rasgele.Next(100, 500);
                btnSoru.Text = deger7.ToString();
                btnSoru.Visible = true;
                btnesittir.Visible = true;

            }
        }

        private void btnyenioyun_Click(object sender, EventArgs e)
        {
            harfsayac = 0;
            sayisayac = 0;
            btnharf1.Visible = false;
            btnharf2.Visible = false;
            btnharf3.Visible = false;
            btnharf4.Visible = false;
            btnharf5.Visible = false;
            btnharf6.Visible = false;
            btnharf7.Visible = false;
            btnharf8.Visible = false;
            btnjoker.Visible = false;


            btnsayi1.Visible = false;
            btnsayi2.Visible = false;
            btnsayi3.Visible = false;
            btnsayi4.Visible = false;
            btnsayi5.Visible = false;
            btnsayi6.Visible = false;
            btnesittir.Visible = false;
            btnSoru.Visible = false;
        }
    }
}
