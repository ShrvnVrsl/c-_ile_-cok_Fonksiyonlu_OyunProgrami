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
    public partial class FrmSehirBul : Form
    {
        public FrmSehirBul()
        {
            InitializeComponent();
        }

        String[] sehirlistesi = {"Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
"Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir","Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
"Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya","Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
"Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak","Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman",
"Şırnak","Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };

        string bulunacaksehirismi = "";
        int bulunanharfsayisi = 0;
        int kalanhak = 4;
        Random rasgele;
        private void btnHarfGir_Click(object sender, EventArgs e)
        {
            bool harfvarmi = false;
            if (txtharf.Text.Length!=1)
            {
                MessageBox.Show("Lütfen Tek Harf Girin", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            }
            else
            {
                if (lblgirilenharf.Text.Contains(txtharf.Text))
                {
                    MessageBox.Show("Bu Harfi Daha Önce Girmiştiniz", "BİLDİRİM" , MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    txtharf.Text = "";
                    txtharf.Focus();

                    return ;
                }
                foreach (Control item in GrpOyunalani.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        if (label.Text.ToUpper()==txtharf.Text.ToUpper())
                        {
                            label.ForeColor = Color.Black;
                            label.BackColor = Color.Lime;
                            harfvarmi = true;
                        }
                    }
                }
            }

            if (!harfvarmi)
            {
                kalanhak--;
                lblkalanhak.Text = kalanhak.ToString();
                if (kalanhak == 0) 
                {
                    btnHarfGir.Enabled = false;
                    btntahminet.Enabled = false;
                    MessageBox.Show("KAYBETTİNİZ. YENİ OYUN İÇİN YENİ OYUN BUTONUNA TIKLAYINIZ  " + "\n" + "Doğru Cevap :  " + bulunacaksehirismi, "OYUN BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

            lblgirilenharf.Text += txtharf.Text + " ";
            if (bulunanharfsayisi==bulunacaksehirismi.Length)
            {
                btnHarfGir.Enabled = false;
                btntahminet.Enabled = false;
                MessageBox.Show("KAZANDINIZ", "OYUN BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtharf.Text = "";
            txtharf.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bulunanharfsayisi = 0;
            btnHarfGir.Enabled = true;
            btntahminet.Enabled = true;
            lblgirilenharf.Text = " ";
            kalanhak = 4;
            YeniSehirSec();
            GrpOyunalani.Controls.Clear();
            for (int i = 0; i < bulunacaksehirismi.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 30, 20);
                label.Text = bulunacaksehirismi[i].ToString();
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label.Size = new System.Drawing.Size(15, 20);
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                GrpOyunalani.Controls.Add(label);
            }
        }

        private void btntahminet_Click(object sender, EventArgs e)
        {
            if (bulunacaksehirismi.ToUpper()==txtkelime.Text.ToUpper())
            {
                foreach (Control item in GrpOyunalani.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        label.ForeColor = Color.Black;
                        label.BackColor = Color.Lime;
                    }
                }
                MessageBox.Show("TEBRİKLER KAZANDINIZ :) ", "OYUN BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("MAALESEF KAYBETTİNİZ :/ " + "\n" + "Doğru Cevap :  " + bulunacaksehirismi, "OYUN BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnHarfGir.Enabled = false;
            btntahminet.Enabled = false;
        }

        private void FrmSehirBul_Load(object sender, EventArgs e)
        {
            btnHarfGir.Enabled = false;
            btntahminet.Enabled = false;
            rasgele = new Random();

            this.AcceptButton = btnHarfGir;
        }

        private void YeniSehirSec()
        {
            int rasgelesayi = rasgele.Next(0, sehirlistesi.Length);
            bulunacaksehirismi = sehirlistesi[rasgelesayi];
        }
    }
}
