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
    public partial class Frm12SınıfSayısal : Form
    {
        public Frm12SınıfSayısal()
        {
            InitializeComponent();
        }

        void temizle11()
        {
            TxtBeden12.Text = "";
            TxtDin12.Text = "";
            TxtTarih12.Text = "";
            TxtEdebiyat12.Text = "";
            TxtGorsel12.Text = "";
            TxtYabancıDil12.Text = "";
            Txt2YabancıDil12.Text = "";
            TxtFelsefe12.Text = "";
            TxtSecmeliMat12.Text = "";
            TxtSecmeliFizik12.Text = "";
            TxtSecmeliKimya12.Text = "";
            TxtSecmeliBiyoloji12.Text = "";
            TxtBeden12.Focus();
        }

        private void BtnHesapla12_Click(object sender, EventArgs e)
        {
            double beden, din, tarih, edebiyat, muzik, yabancıdil, ikinciyabancıdil, felsefe, secmelimatematik, secmelifizik, secmelikimya, secmelibiyoloji, ortalama;
            beden = Convert.ToDouble(TxtBeden12.Text);
            din = Convert.ToDouble(TxtDin12.Text);
            tarih = Convert.ToDouble(TxtTarih12.Text);
            edebiyat = Convert.ToDouble(TxtEdebiyat12.Text);
            muzik = Convert.ToDouble(TxtGorsel12.Text);
            yabancıdil = Convert.ToDouble(TxtYabancıDil12.Text);
            ikinciyabancıdil = Convert.ToDouble(Txt2YabancıDil12.Text);
            felsefe = Convert.ToDouble(TxtFelsefe12.Text);
            secmelimatematik = Convert.ToDouble(TxtSecmeliMat12.Text);
            secmelifizik = Convert.ToDouble(TxtSecmeliFizik12.Text);
            secmelikimya = Convert.ToDouble(TxtSecmeliKimya12.Text);
            secmelibiyoloji = Convert.ToDouble(TxtSecmeliBiyoloji12.Text);

            double beden11 = (2 * beden);
            double din11 = (2 * din);
            double tarih11 = (2 * tarih);
            double edebiyat11 = (5 * edebiyat);
            double muzik11 = (2 * muzik);
            double yabancil11 = (4 * yabancıdil);
            double ikinciyabancıdil11 = (2 * ikinciyabancıdil);
            double felsefe11 = (2 * felsefe);
            double secmelimatematik11 = (6 * secmelimatematik);
            double secmelifizik11 = (4 * secmelifizik);
            double secmelikimya11 = (4 * secmelikimya);
            double secmelibiyoloji11 = (4 * secmelibiyoloji);

            ortalama = (beden11 + din11 + tarih11 + edebiyat11 + muzik11 + yabancil11 + ikinciyabancıdil11 + felsefe11 + secmelimatematik11 + secmelifizik11 + secmelikimya11 + secmelibiyoloji11) / 39;

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

        private void BtnTemizle12_Click(object sender, EventArgs e)
        {
            temizle11();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Frm12Sınıf frl12 = new Frm12Sınıf();
            frl12.Show();
            this.Hide();
        }
    }
}
