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
    public partial class Frm9Sınıf : Form
    {
        public Frm9Sınıf()
        {
            InitializeComponent();
        }

        void temizle9()
        {
            TxtBeden9.Text = "";
            TxtMatematik9.Text = "";
            TxtFizik9.Text = "";
            TxtKimya9.Text = "";
            TxtBiyoloji9.Text = "";
            TxtDin9.Text = "";
            TxtTarih9.Text = "";
            TxtCoğrafya9.Text = "";
            TxtEdebiyat9.Text = "";
            TxtGorselMüzik9.Text = "";
            TxtYabancıDil9.Text = "";
            Txt2YabancıDil9.Text = "";
            TxtSaglık9.Text = "";
            TxtBeden9.Focus();
        }

        private void BtnHesapla8_Click(object sender, EventArgs e)
        {
            double beden, matematik, fizik, kimya, biyoloji, din, tarih, cografya, edebiyat, gorsel, yabancıdil, yabancıdil2, saglık, ortalama;
            beden = Convert.ToDouble(TxtBeden9.Text);
            matematik = Convert.ToDouble(TxtMatematik9.Text);
            fizik = Convert.ToDouble(TxtFizik9.Text);
            kimya = Convert.ToDouble(TxtKimya9.Text);
            biyoloji = Convert.ToDouble(TxtBiyoloji9.Text);
            din = Convert.ToDouble(TxtDin9.Text);
            tarih = Convert.ToDouble(TxtTarih9.Text);
            cografya = Convert.ToDouble(TxtCoğrafya9.Text);
            edebiyat = Convert.ToDouble(TxtEdebiyat9.Text);
            gorsel = Convert.ToDouble(TxtGorselMüzik9.Text);
            yabancıdil = Convert.ToDouble(TxtYabancıDil9.Text);
            yabancıdil2 = Convert.ToDouble(Txt2YabancıDil9.Text);
            saglık = Convert.ToDouble(TxtSaglık9.Text);

            double beden9 = (2 * beden);
            double matematik9 = (6 * matematik);
            double fizik9 = (2 * fizik);
            double kimya9 = (2 * kimya);
            double biyoloji9 = (2 * biyoloji);
            double din9 = (2 * din);
            double tarih9 = (2 * tarih);
            double cografya9 = (2 * cografya);
            double edebiyat9 = (5 * edebiyat);
            double gorsel9 = (2 * gorsel);
            double yabancıdil9 = (4 * yabancıdil);
            double yabancil2dil9 = (2 * yabancıdil2);
            double saglık9 = (2 * saglık);

            ortalama = (beden9 + matematik9 + fizik9 + kimya9 + biyoloji9 + din9 + tarih9 + cografya9 + edebiyat9 + gorsel9 + yabancıdil9 + yabancil2dil9 + saglık9) / 35;

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

        private void BtnTemizle9_Click(object sender, EventArgs e)
        {
            temizle9();
        }

        private void BtnGeri8Sınıf_Click(object sender, EventArgs e)
        {
            FrmLise frl = new FrmLise();
            frl.Show();
            this.Hide();
        }
    }
}
