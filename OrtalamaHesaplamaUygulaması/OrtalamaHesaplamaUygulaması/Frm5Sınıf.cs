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
    public partial class Frm5Sınıf : Form
    {
        public Frm5Sınıf()
        {
            InitializeComponent();
        }

        void temizle5()
        {
            TxtBeden5.Text = "";
            TxtDin5.Text = "";
            TxtFen5.Text = "";
            TxtGörsel5.Text = "";
            TxtMatematik5.Text = "";
            TxtMüzik5.Text = "";
            TxtTeknoloji5.Text = "";
            TxtTürkçe5.Text = "";
            TxtYabancıDil5.Text = "";
            TxtSosyal5.Text = "";
            TxtBeden5.Focus();
        }

        private void BtnHesapla5_Click(object sender, EventArgs e)
        {
            double beden5, din5, fen5, gorsel5, matematik5, müzik5, sosyal5, bilisimteknoloji5, türkçe5, yabancıdil5, ortalama5;
            beden5 = Convert.ToDouble(TxtBeden5.Text);
            din5 = Convert.ToDouble(TxtDin5.Text);
            fen5 = Convert.ToDouble(TxtFen5.Text);
            gorsel5 = Convert.ToDouble(TxtGörsel5.Text);
            matematik5 = Convert.ToDouble(TxtMatematik5.Text);
            müzik5 = Convert.ToDouble(TxtMüzik5.Text);
            sosyal5 = Convert.ToDouble(TxtSosyal5.Text);
            bilisimteknoloji5 = Convert.ToDouble(TxtTeknoloji5.Text);
            türkçe5 = Convert.ToDouble(TxtTürkçe5.Text);
            yabancıdil5 = Convert.ToDouble(TxtYabancıDil5.Text);

            double beden4 = (2 * beden5);
            double din4 = (2 * din5);
            double fen4 = (4 * fen5);
            double gorsel4 = (1 * gorsel5);
            double matematik4 = (5 * matematik5);
            double müzik4 = (1 * müzik5);
            double sosyal4 = (3 * sosyal5);
            double bilisimteknoloji4 = (2 * bilisimteknoloji5);
            double türkce4 = (6 * türkçe5);
            double yabancıdil4 = (3 * yabancıdil5);

            ortalama5 = (beden4 + din4 + fen4 + gorsel4 + matematik4 + müzik4 + sosyal4 + bilisimteknoloji4 + türkce4 + yabancıdil4) / 29;

            if (ortalama5 >= 85)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama5.ToString("0.0000") + "\n" + "Tebrikler Takdir Belgesi Almaya Hak Kazandınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama5 >= 70 && ortalama5 <= 85)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama5.ToString("0.0000") + "\n" + "Tebrikler Teşekkür Belgesi Almaya Hak Kazandınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama5 >= 50 && ortalama5 <= 69)
            {
                MessageBox.Show(" Ortalamanın: " + ortalama5.ToString("0.0000") + "\n" + "Maalesef herhangi bir belge almaya hak kazanamadınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama5 <= 49)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama5.ToString("0.0000") + "\n" + "Maalesef Sınıfta Kaldınız Seneye Daha İyi Çalısınız :)", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnTemizle5_Click(object sender, EventArgs e)
        {
            temizle5();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOrtaokul frmo = new FrmOrtaokul();
            frmo.Show();
            this.Hide();
        }
    }
}
