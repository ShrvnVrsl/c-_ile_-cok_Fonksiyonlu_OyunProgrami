using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace soru_cevap
{
    public partial class Bilgi_yarismasi : Form
    {
        public Bilgi_yarismasi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=.; Initial Catalog =Oyunlar; Integrated Security = SSPI");
        int sayaç = 0;
        int puan = 0;
        int zaman = 21;
        private void BtnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;

            button1.BackColor = Color.Aquamarine ;
            button2.BackColor = Color.Aquamarine;
            button3.BackColor = Color.Aquamarine;
            button4.BackColor = Color.Aquamarine;

            BtnBasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            BtnBasla.Text = "SONRAKİ";
            sayaç++;
            lblsoru.Text = sayaç.ToString();
            if (sayaç==1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru1 order by NEWID() ", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldgr.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayaç==2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru2 order by NEWID() ", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldgr.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayaç == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru3 order by NEWID() ", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldgr.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayaç == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru4 order by NEWID() ", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldgr.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayaç == 5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru5 order by NEWID() ", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldgr.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayaç == 6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru6 order by NEWID() ", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldgr.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayaç == 7)
            {
                BtnBasla.Text = "OYUN BİTTİ";
                BtnBasla.Enabled = false;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru7 order by NEWID() ", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldgr.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayaç==8)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                timer1.Enabled = false;

                DialogResult cevap;
                cevap = MessageBox.Show("Ana Sayfaya Dönmek İster misiniz", "OYUN BİTTİ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (cevap == DialogResult.Yes)
                {
                    FormAna frm = new FormAna();
                    frm.ShowDialog();
                }

            }
        }

        private void Bilgi_yarismasi_Load(object sender, EventArgs e)
        {
            lbldgr.Visible = false;
            lblsoru.Text = sayaç.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text==lbldgr.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == lbldgr.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
        
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == lbldgr.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
        
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == lbldgr.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
        
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblzaman.Text = zaman.ToString();
            if (zaman==0)
            {
                timer1.Enabled = false;
                BtnBasla.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show("SORUYU ARTIK CEVAPLAYAMAZSINIZ", "SÜRE BİTTİ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}
