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
    public partial class FrmOrtaokul : Form
    {
        public FrmOrtaokul()
        {
            InitializeComponent();
        }

        private void Btn8Sınıf_Click(object sender, EventArgs e)
        {
            Frm8Sınıf frm8 = new Frm8Sınıf();
            frm8.Show();
            this.Hide();
        }

        private void Btn7Sınıf_Click(object sender, EventArgs e)
        {
            Frm7Sınıf frm7 = new Frm7Sınıf();
            frm7.Show();
            this.Hide();
        }

        private void Btn6Sınıf_Click(object sender, EventArgs e)
        {
            Frm6Sınıf frm6 = new Frm6Sınıf();
            frm6.Show();
            this.Hide();
        }

        private void Btn5Sınıf_Click(object sender, EventArgs e)
        {
            Frm5Sınıf frm5 = new Frm5Sınıf();
            frm5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frma = new FrmAnaForm();
            frma.Show();
            this.Hide();
        }
    }
}
