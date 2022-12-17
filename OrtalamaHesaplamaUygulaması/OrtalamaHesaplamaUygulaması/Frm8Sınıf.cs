using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaHesaplamaUygulaması
{
    public partial class Frm8Sınıf : Form
    {
        public Frm8Sınıf()
        {
            InitializeComponent();
        }

        void temizle()
        {
            TxtBeden8.Text = "";
            TxtDin8.Text = "";
            TxtFen8.Text = "";
            TxtGörsel8.Text = "";
            TxtMatematik8.Text = "";
            TxtMüzik8.Text = "";
            TxtTeknoloji8.Text = "";
            TxtTürkçe8.Text = "";
            TxtYabancıDil8.Text = "";
            Txtİnkılap8.Text = "";
            TxtSecmeli1.Text = "";
            TxtSecmeli2.Text = "";
            TxtSecmeli3.Text = "";
            TxtDersSaat1.Text = "";
            TxtDersSaat2.Text = "";
            TxtDersSaat3.Text = "";
            TxtBeden8.Focus();
        }

        private void BtnHesapla8_Click(object sender, EventArgs e)
        {
            double beden, din, fen, gorsel, matematik, müzik, inkılap, teknoloji, türkçe, yabancıdil, ortalama;
            beden = Convert.ToDouble(TxtBeden8.Text);
            din = Convert.ToDouble(TxtDin8.Text);
            fen = Convert.ToDouble(TxtFen8.Text);
            gorsel = Convert.ToDouble(TxtGörsel8.Text);
            matematik = Convert.ToDouble(TxtMatematik8.Text);
            müzik = Convert.ToDouble(TxtMüzik8.Text);
            inkılap = Convert.ToDouble(Txtİnkılap8.Text);
            teknoloji = Convert.ToDouble(TxtTeknoloji8.Text);
            türkçe = Convert.ToDouble(TxtTürkçe8.Text);
            yabancıdil = Convert.ToDouble(TxtYabancıDil8.Text);

            double beden1 = (2 * beden);
            double din1 = (2 * din);
            double fen1 = (4 * fen);
            double gorsel1 = (1 * gorsel);
            double matematik1 = (5 * matematik);
            double müzik1 = (1 * müzik);
            double inkılap1 = (2 * inkılap);
            double teknoloji1 = (2 * teknoloji);
            double türkce1 = (5 * türkçe);
            double yabancıdil1 = (4 * yabancıdil);

            int secmeli1, secmeli2, secmeli3, secmelisaat1, secmelisaat2, secmelisaat3, toplam;
            secmeli1 = Convert.ToInt16(TxtSecmeli1.Text);
            secmeli2 = Convert.ToInt16(TxtSecmeli2.Text);
            secmeli3 = Convert.ToInt16(TxtSecmeli3.Text);
            secmelisaat1 = Convert.ToInt16(TxtDersSaat1.Text);
            secmelisaat2 = Convert.ToInt16(TxtDersSaat2.Text);
            secmelisaat3 = Convert.ToInt16(TxtDersSaat3.Text);

            int secmeli01 = (secmeli1 * secmelisaat1);
            int secmeli02 = (secmeli2 * secmelisaat2);
            int secmeli03 = (secmeli3 * secmelisaat3);

            toplam = (secmelisaat1 + secmelisaat2 + secmelisaat3 + 28);

            ortalama = (beden1 + din1 + fen1 + gorsel1 + matematik1 + müzik1 + inkılap1 + teknoloji1 + türkce1 + yabancıdil1 + secmeli01 + secmeli02 + secmeli03) / toplam;
            if (ortalama >= 85)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama.ToString("0.0000") + "\n" + "Tebrikler Takdir Belgesi Almaya Hak Kazandınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama >= 70 && ortalama <= 85)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama.ToString("0.0000") + "\n" + "Tebrikler Teşekkür Belgesi Almaya Hak Kazandınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama >= 50 && ortalama <= 69)
            {
                MessageBox.Show(" Ortalamanın: " + ortalama.ToString("0.0000") + "\n" + "Maalesef herhangi bir belge almaya hak kazanamadınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama <= 49)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama.ToString("0.0000") + "\n" + "Maalesef Sınıfta Kaldınız Seneye Daha İyi Çalısınız :)", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnTemizle8_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnGeri8Sınıf_Click(object sender, EventArgs e)
        {
            FrmOrtaokul frmo = new FrmOrtaokul();
            frmo.Show();
            this.Hide();
        }
    }
}
