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
    public partial class Frm6Sınıf : Form
    {
        public Frm6Sınıf()
        {
            InitializeComponent();
        }

        void temizle6()
        {
            TxtBeden6.Text = "";
            TxtDin6.Text = "";
            TxtFen6.Text = "";
            TxtGörsel6.Text = "";
            TxtMatematik6.Text = "";
            TxtMüzik6.Text = "";
            TxtTeknoloji6.Text = "";
            TxtTürkçe6.Text = "";
            TxtYabancıDil6.Text = "";
            TxtSosyal6.Text = "";
            TxtBeden6.Focus();
        }

        private void BtnHesapla6_Click(object sender, EventArgs e)
        {
            double beden6, din6, fen6, gorsel6, matematik6, müzik6, sosyal6, bilisimteknoloji6, türkçe6, yabancıdil6, ortalama6;
            beden6 = Convert.ToDouble(TxtBeden6.Text);
            din6 = Convert.ToDouble(TxtDin6.Text);
            fen6 = Convert.ToDouble(TxtFen6.Text);
            gorsel6 = Convert.ToDouble(TxtGörsel6.Text);
            matematik6 = Convert.ToDouble(TxtMatematik6.Text);
            müzik6 = Convert.ToDouble(TxtMüzik6.Text);
            sosyal6 = Convert.ToDouble(TxtSosyal6.Text);
            bilisimteknoloji6 = Convert.ToDouble(TxtTeknoloji6.Text);
            türkçe6 = Convert.ToDouble(TxtTürkçe6.Text);
            yabancıdil6 = Convert.ToDouble(TxtYabancıDil6.Text);

            double beden3 = (2 * beden6);
            double din3 = (2 * din6);
            double fen3 = (4 * fen6);
            double gorsel3 = (1 * gorsel6);
            double matematik3 = (5 * matematik6);
            double müzik3 = (1 * müzik6);
            double sosyal3 = (3 * sosyal6);
            double bilisimteknoloji3 = (2 * bilisimteknoloji6);
            double türkce3 = (6 * türkçe6);
            double yabancıdil3 = (3 * yabancıdil6);

            ortalama6 = (beden3 + din3 + fen3 + gorsel3 + matematik3 + müzik3 + sosyal3 + bilisimteknoloji3 + türkce3 + yabancıdil3) / 29;

            if (ortalama6 >= 85)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama6.ToString("0.0000") + "\n" + "Tebrikler Takdir Belgesi Almaya Hak Kazandınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama6 >= 70 && ortalama6 <= 85)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama6.ToString("0.0000") + "\n" + "Tebrikler Teşekkür Belgesi Almaya Hak Kazandınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama6 >= 50 && ortalama6 <= 69)
            {
                MessageBox.Show(" Ortalamanın: " + ortalama6.ToString("0.0000") + "\n" + "Maalesef herhangi bir belge almaya hak kazanamadınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama6 <= 49)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama6.ToString("0.0000") + "\n" + "Maalesef Sınıfta Kaldınız Seneye Daha İyi Çalısınız :)", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnTemizle6_Click(object sender, EventArgs e)
        {
            temizle6();
        }

        private void BtnGeri6Sınıf_Click(object sender, EventArgs e)
        {
            FrmOrtaokul frmo = new FrmOrtaokul();
            frmo.Show();
            this.Hide();
        }
    }
}
