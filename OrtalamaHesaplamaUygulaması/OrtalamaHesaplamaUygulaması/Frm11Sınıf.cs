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
    public partial class Frm11Sınıf : Form
    {
        public Frm11Sınıf()
        {
            InitializeComponent();
        }

        private void BtnGeriLise_Click(object sender, EventArgs e)
        {
            FrmLise frl = new FrmLise();
            frl.Show();
            this.Hide();
        }

        private void BtnSayısal11_Click(object sender, EventArgs e)
        {
            Frm11SınıfSayısal frls = new Frm11SınıfSayısal();
            frls.Show();
            this.Hide();
        }

        private void BtnEsitAgırlık11_Click(object sender, EventArgs e)
        {
            Frm11SınıfEsitAgırlık frles = new Frm11SınıfEsitAgırlık();
            frles.Show();
            this.Hide();
        }
    }
}
