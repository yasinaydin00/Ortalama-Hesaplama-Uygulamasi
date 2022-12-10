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
    public partial class FrmLise : Form
    {
        public FrmLise()
        {
            InitializeComponent();
        }

        private void Btn9Sınıf_Click(object sender, EventArgs e)
        {
            Frm9Sınıf frl9 = new Frm9Sınıf();
            frl9.Show();
            this.Hide();
        }

        private void BtnGeriLise_Click(object sender, EventArgs e)
        {
            FrmAnaForm fra = new FrmAnaForm();
            fra.Show();
            this.Hide();
        }

        private void Btn10Sınıf_Click(object sender, EventArgs e)
        {
            Frm10Sınıf frl10 = new Frm10Sınıf();
            frl10.Show();
            this.Hide();
        }

        private void Btn11Sınıf_Click(object sender, EventArgs e)
        {
            Frm11Sınıf frl11 = new Frm11Sınıf();
            frl11.Show();
            this.Hide();
        }

        private void Btn12Sınıf_Click(object sender, EventArgs e)
        {
            Frm12Sınıf frl12 = new Frm12Sınıf();
            frl12.Show();
            this.Hide();
        }
    }
}
