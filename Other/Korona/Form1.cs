using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korona
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            int ukupni = 0, umrli=0, oporavak=0;
            DržavnaStatistika državna = new DržavnaStatistika(KoronaAPI.Podaci.Dohvati());
            
            for (int i = 0; i <državna.lista.Count; i++)
            {

                dataGridView1.Rows.Add(državna.lista[i].Datum.ToString(), državna.lista[i].BrojNovoZaraženih, državna.lista[i].BrojUmrlih, državna.lista[i].BrojOporavljenih);
                ukupni += državna.lista[i].BrojNovoZaraženih;
                umrli += državna.lista[i].BrojUmrlih;
                oporavak += državna.lista[i].BrojOporavljenih;

            }
            textBox1.Text = ukupni.ToString();
            textBox2.Text = oporavak.ToString();
            textBox3.Text = (ukupni-umrli).ToString();
            textBox4.Text = umrli.ToString();



        }
    } }

