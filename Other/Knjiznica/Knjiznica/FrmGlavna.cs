using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class FrmGlavna : Form
    {
        List<IPretraga> Knjiznica { get; set; }
        private Knjiga _knjiga;

        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            Knjiznica = new List<IPretraga>();
            _knjiga = null;
            OsvjeziPopisKnjiga();
        }

        private void OsvjeziPopisKnjiga()
        {
            lstbKnjige.DataSource = null;
            lstbKnjige.DataSource = Knjiznica;
        }

        private void OsvjeziPopisAutora()
        {
            if (_knjiga != null)
            {
                lstbAutori.DataSource = null;
                lstbAutori.DataSource = _knjiga.Autori;
            }
        }

        private void DodajKnjigu_Click(object sender, EventArgs e)
        {
            UnesiKnjigu();
        }

        public void UnesiKnjigu()
        {
            string nazivKnjige = tbxNazivKnjige.Text;
            int godinaKnjige = int.Parse(tbxGodinaKnjige.Text);

            _knjiga = new Knjiga(nazivKnjige, godinaKnjige);
            Knjiznica.Add(_knjiga);

            tbxNazivKnjige.Clear();
            tbxGodinaKnjige.Clear();
            OsvjeziPopisKnjiga();
        }

        public void DodajAutora()
        {
                string imeAutora = tbxImeAutora.Text;
                string prezimeAutora = tbxPrezimeAutora.Text;
                Autor autor = new Autor(imeAutora, prezimeAutora);

                _knjiga = lstbKnjige.SelectedItem as Knjiga;
                _knjiga.DodajAutora(autor);

                OsvjeziPopisAutora();
                tbxImeAutora.Clear();
                tbxPrezimeAutora.Clear();
        }

        private void DodajAutora_Click(object sender, EventArgs e)
        {
            if (lstbKnjige.SelectedItem != null)
                DodajAutora();
        }

        private void LstbKnjige_MouseClick(object sender, MouseEventArgs e)
        {
            _knjiga = lstbKnjige.SelectedItem as Knjiga;
            OsvjeziPopisAutora();
        }

        private void BtnPretraga_Click(object sender, EventArgs e)
        {
            Pretrazi(tbxPretraga.Text);
        }

        public void Pretrazi(string keyword)
        {
            foreach (var knjiga in Knjiznica)
                if (knjiga.Usporedi(keyword.ToLower()))
                    txtRezultat.Text = knjiga.Ispis();
        }
    }
}
