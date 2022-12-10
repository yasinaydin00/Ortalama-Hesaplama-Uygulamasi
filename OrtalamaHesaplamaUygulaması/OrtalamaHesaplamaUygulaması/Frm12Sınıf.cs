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
    public partial class Frm12Sınıf : Form
    {
        public Frm12Sınıf()
        {
            InitializeComponent();
        }

        private void BtnSayısal11_Click(object sender, EventArgs e)
        {
            Frm12SınıfSayısal frl12s = new Frm12SınıfSayısal();
            frl12s.Show();
            this.Hide();
        }

        private void BtnGeriLise_Click(object sender, EventArgs e)
        {
            FrmLise frl = new FrmLise();
            frl.Show();
            this.Hide();
        }

        private void BtnEsitAgırlık11_Click(object sender, EventArgs e)
        {
            Frm12SınıfEsitAgırlık frl12es = new Frm12SınıfEsitAgırlık();
            frl12es.Show();
            this.Hide();
        }
    }
}
