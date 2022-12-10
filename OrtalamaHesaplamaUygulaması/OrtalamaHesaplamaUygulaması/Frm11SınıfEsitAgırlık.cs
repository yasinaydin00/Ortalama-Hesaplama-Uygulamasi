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
    public partial class Frm11SınıfEsitAgırlık : Form
    {
        public Frm11SınıfEsitAgırlık()
        {
            InitializeComponent();
        }

        void temizle11()
        {
            TxtBeden11.Text = "";
            TxtDin11.Text = "";
            TxtTarih11.Text = "";
            TxtEdebiyat11.Text = "";
            TxtGorsel11.Text = "";
            TxtYabancıDil11.Text = "";
            Txt2YabancıDil11.Text = "";
            TxtFelsefe11.Text = "";
            TxtSecmeliMat11.Text = "";
            TxtSecmeliEdebi11.Text = "";
            TxtSecmeliCog11.Text = "";
            TxtSecmeliTarih11.Text = "";
            TxtBeden11.Focus();
        }

        private void BtnHesapla11_Click(object sender, EventArgs e)
        {
            double beden, din, tarih, edebiyat, muzik, yabancıdil, ikinciyabancıdil, felsefe, secmelimatematik, secmeliedebiyat, secmelicografya, secmelitarih, ortalama;
            beden = Convert.ToDouble(TxtBeden11.Text);
            din = Convert.ToDouble(TxtDin11.Text);
            tarih = Convert.ToDouble(TxtTarih11.Text);
            edebiyat = Convert.ToDouble(TxtEdebiyat11.Text);
            muzik = Convert.ToDouble(TxtGorsel11.Text);
            yabancıdil = Convert.ToDouble(TxtYabancıDil11.Text);
            ikinciyabancıdil = Convert.ToDouble(Txt2YabancıDil11.Text);
            felsefe = Convert.ToDouble(TxtFelsefe11.Text);
            secmelimatematik = Convert.ToDouble(TxtSecmeliMat11.Text);
            secmeliedebiyat = Convert.ToDouble(TxtSecmeliEdebi11.Text);
            secmelicografya = Convert.ToDouble(TxtSecmeliCog11.Text);
            secmelitarih = Convert.ToDouble(TxtSecmeliTarih11.Text);

            double beden11 = (2 * beden);
            double din11 = (2 * din);
            double tarih11 = (2 * tarih);
            double edebiyat11 = (5 * edebiyat);
            double muzik11 = (2 * muzik);
            double yabancil11 = (4 * yabancıdil);
            double ikinciyabancıdil11 = (2 * ikinciyabancıdil);
            double felsefe11 = (2 * felsefe);
            double secmelimatematik11 = (6 * secmelimatematik);
            double secmeliedebiyat11 = (3 * secmeliedebiyat);
            double secmelicografya11 = (4 * secmelicografya);
            double secmelitarih11 = (4 * secmelitarih);

            ortalama = (beden11 + din11 + tarih11 + edebiyat11 + muzik11 + yabancil11 + ikinciyabancıdil11 + felsefe11 + secmelimatematik11 + secmeliedebiyat11 + secmelicografya11 + secmelitarih11) / 38;

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

        private void BtnTemizle11_Click(object sender, EventArgs e)
        {
            temizle11();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Frm11Sınıf frm11 = new Frm11Sınıf();
            frm11.Show();
            this.Hide();
        }
    }
}
