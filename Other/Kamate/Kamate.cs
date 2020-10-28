using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamate
{
    public partial class Kamate : Form
    {
        Kredit kredit = new Kredit();
        public Kamate()
        {
            InitializeComponent();
        }

       

        private void izracun()
        {
            kredit.izracun();
            txtOtpPlan.Refresh();
            txtOtpPlan.Text = kredit.Otp_Plan.ToString();
        }


        private void txtGlavnica_Enter(object sender, EventArgs e)
        {
            izracun();
            txtGlavnica.Clear();
        }

        private void txtKamStopa_Enter(object sender, EventArgs e)
        {
            izracun();
            txtKamStopa.Clear();
        }

        private void txtTrajanje_Enter(object sender, EventArgs e)
        {
            izracun();
            txtTrajanje.Clear();
        }

        private void txtGlavnica_Leave(object sender, EventArgs e)
        {
            if(txtGlavnica.Text!=null)
            kredit.Glavnica = int.Parse(txtGlavnica.Text);
            izracun();
        }

        private void txtKamStopa_Leave(object sender, EventArgs e)
        {
            if (txtKamStopa.Text != null)
                kredit.Kamatna_Stopa = int.Parse(txtKamStopa.Text);
            izracun();
        }

        private void txtTrajanje_Leave(object sender, EventArgs e)
        {
            if (txtTrajanje.Text != null)
                kredit.Trajanje = int.Parse(txtTrajanje.Text);
            izracun();
        }
    }
}
