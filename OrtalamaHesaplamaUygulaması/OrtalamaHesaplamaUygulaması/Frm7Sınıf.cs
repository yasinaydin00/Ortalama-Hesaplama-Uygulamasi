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
    public partial class Frm7Sınıf : Form
    {
        public Frm7Sınıf()
        {
            InitializeComponent();
        }

        void temizle7()
        {
            TxtBeden7.Text = "";
            TxtDin7.Text = "";
            TxtFen7.Text = "";
            TxtGörsel7.Text = "";
            TxtMatematik7.Text = "";
            TxtMüzik7.Text = "";
            TxtTeknoloji7.Text = "";
            TxtTürkçe7.Text = "";
            TxtYabancıDil7.Text = "";
            TxtSosyal7.Text = "";
            TxtSecmeli1.Text = "";
            TxtSecmeli2.Text = "";
            TxtSecmeli3.Text = "";
            TxtDersSaat1.Text = "";
            TxtDersSaat2.Text = "";
            TxtDersSaat3.Text = "";
            TxtBeden7.Focus();
        }

        private void BtnHesapla8_Click(object sender, EventArgs e)
        {
            double beden7, din7, fen7, gorsel7, matematik7, müzik7, sosyal7, teknoloji7, türkçe7, yabancıdil7, ortalama7;
            beden7 = Convert.ToDouble(TxtBeden7.Text);
            din7 = Convert.ToDouble(TxtDin7.Text);
            fen7 = Convert.ToDouble(TxtFen7.Text);
            gorsel7 = Convert.ToDouble(TxtGörsel7.Text);
            matematik7 = Convert.ToDouble(TxtMatematik7.Text);
            müzik7 = Convert.ToDouble(TxtMüzik7.Text);
            sosyal7 = Convert.ToDouble(TxtSosyal7.Text);
            teknoloji7 = Convert.ToDouble(TxtTeknoloji7.Text);
            türkçe7 = Convert.ToDouble(TxtTürkçe7.Text);
            yabancıdil7 = Convert.ToDouble(TxtYabancıDil7.Text);

            double beden2 = (2 * beden7);
            double din2 = (2 * din7);
            double fen2 = (4 * fen7);
            double gorsel2 = (1 * gorsel7);
            double matematik2 = (5 * matematik7);
            double müzik2 = (1 * müzik7);
            double sosyal2 = (3 * sosyal7);
            double teknoloji2 = (2 * teknoloji7);
            double türkce2 = (5 * türkçe7);
            double yabancıdil2 = (4 * yabancıdil7);

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

            toplam = (secmelisaat1 + secmelisaat2 + secmelisaat3 + 29);

            ortalama7 = (beden2 + din2 + fen2 + gorsel2 + matematik2 + müzik2 + sosyal2 + teknoloji2 + türkce2 + yabancıdil2 + secmeli01 + secmeli02 + secmeli03) / toplam;

            if (ortalama7 >= 85)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama7.ToString("0.0000") + "\n" + "Tebrikler Takdir Belgesi Almaya Hak Kazandınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama7 >= 70 && ortalama7 <= 85)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama7.ToString("0.0000") + "\n" + "Tebrikler Teşekkür Belgesi Almaya Hak Kazandınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama7 >= 50 && ortalama7 <= 69)
            {
                MessageBox.Show(" Ortalamanın: " + ortalama7.ToString("0.0000") + "\n" + "Maalesef herhangi bir belge almaya hak kazanamadınız", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ortalama7 <= 49)
            {
                MessageBox.Show(" Ortalamanız: " + ortalama7.ToString("0.0000") + "\n" + "Maalesef Sınıfta Kaldınız Seneye Daha İyi Çalısınız :)", "Ortalama Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnTemizle7_Click(object sender, EventArgs e)
        {
            temizle7();
        }

        private void BtnGeri5Sınıf_Click(object sender, EventArgs e)
        {
            FrmOrtaokul frmo = new FrmOrtaokul();
            frmo.Show();
            this.Hide();
        }
    }
}
