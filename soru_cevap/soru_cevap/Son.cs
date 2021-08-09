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
    public partial class Son : Form
    {

        int puan_kull;
        int puan_pcc;

        public Son(int puan_kul, int puan_pc)
        {
            puan_kull = puan_kul;
            puan_pcc = puan_pc;
            InitializeComponent();
        }

        private void Son_Load(object sender, EventArgs e)
        {
            lbl_puan_kul.Text = "Senin Puan: " + puan_kull.ToString();
            lbl_puan_pc.Text = "Rakip Puan: " + puan_pcc.ToString();
            lbl_toplam_puan_kul.Text = FrmPisti_Oyunu.puan_toplam_kul.ToString();
            lbl_toplam_puan_pc.Text = FrmPisti_Oyunu.puan_toplam_pc.ToString();
            if (puan_kull > puan_pcc)
            {
                lbl_sonuc.Text = "Bu Eli Kazandın";
                lbl_sonuc.ForeColor = Color.Green;
            }
            else if (puan_kull == puan_pcc)
            {
                lbl_sonuc.Text = "Bu El Berabere";
                lbl_sonuc.ForeColor = Color.LightYellow;
            }
            else
            {
                lbl_sonuc.Text = "Bu Eli Kaybettin";
                lbl_sonuc.ForeColor = Color.Red;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmPisti_Oyunu.devam_veya_cik = true;
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmPisti_Oyunu.devam_veya_cik = false;
            this.Close();
        }
    }
}
