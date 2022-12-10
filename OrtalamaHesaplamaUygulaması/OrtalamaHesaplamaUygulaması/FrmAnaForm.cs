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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void BtnOrtaokul_Click(object sender, EventArgs e)
        {
            FrmOrtaokul fro = new FrmOrtaokul();
            fro.Show();
            this.Hide();
        }

        private void BtnLise_Click(object sender, EventArgs e)
        {
            FrmLise frl = new FrmLise();
            frl.Show();
            this.Hide();
        }
    }
}
