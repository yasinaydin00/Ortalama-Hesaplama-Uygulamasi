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
    public partial class Frm10Sınıf : Form
    {
        public Frm10Sınıf()
        {
            InitializeComponent();
        }

        void temizle10()
        {
            TxtBeden10.Text = "";
            TxtMatematik10.Text = "";
            TxtFizik10.Text = "";
            TxtKimya10.Text = "";
            TxtBiyoloji10.Text = "";
            TxtDin10.Text = "";
            TxtTarih10.Text = "";
            TxtCoğrafya10.Text = "";
            TxtEdebiyat10.Text = "";
            TxtGorselMüzik10.Text = "";
            TxtYabancıDil10.Text = "";
            Txt2YabancıDil10.Text = "";
            TxtFelsefe10.Text = "";
            TxtBeden10.Focus();
        }

        private void BtnHesapla10_Click(object sender, EventArgs e)
        {
            double beden, matematik, fizik, kimya, biyoloji, din, tarih, cografya, edebiyat, gorsel, yabancıdil, yabancıdil2, felsefe, ortalama;
            beden = Convert.ToDouble(TxtBeden10.Text);
            matematik = Convert.ToDouble(TxtMatematik10.Text);
            fizik = Convert.ToDouble(TxtFizik10.Text);
            kimya = Convert.ToDouble(TxtKimya10.Text);
            biyoloji = Convert.ToDouble(TxtBiyoloji10.Text);
            din = Convert.ToDouble(TxtDin10.Text);
            tarih = Convert.ToDouble(TxtTarih10.Text);
            cografya = Convert.ToDouble(TxtCoğrafya10.Text);
            edebiyat = Convert.ToDouble(TxtEdebiyat10.Text);
            gorsel = Convert.ToDouble(TxtGorselMüzik10.Text);
            yabancıdil = Convert.ToDouble(TxtYabancıDil10.Text);
            yabancıdil2 = Convert.ToDouble(Txt2YabancıDil10.Text);
            felsefe = Convert.ToDouble(TxtFelsefe10.Text);

            double beden10 = (2 * beden);
            double matematik10 = (6 * matematik);
            double fizik10 = (2 * fizik);
            double kimya10 = (2 * kimya);
            double biyoloji10 = (2 * biyoloji);
            double din10 = (2 * din);
            double tarih10 = (2 * tarih);
            double cografya10 = (2 * cografya);
            double edebiyat10 = (5 * edebiyat);
            double gorsel10 = (2 * gorsel);
            double yabancıdil10 = (4 * yabancıdil);
            double yabancil2dil10 = (2 * yabancıdil2);
            double felsefe10 = (2 * felsefe);

            ortalama = (beden10 + matematik10 + fizik10 + kimya10 + biyoloji10 + din10 + tarih10 + cografya10 + edebiyat10 + gorsel10 + yabancıdil10 + yabancil2dil10 + felsefe10) / 35;

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

        private void BtnTemizle10_Click(object sender, EventArgs e)
        {
            temizle10();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmLise frl = new FrmLise();
            frl.Show();
            this.Hide();
        }
    }
}
