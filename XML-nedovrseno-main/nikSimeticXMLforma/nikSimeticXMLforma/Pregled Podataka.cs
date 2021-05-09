using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikSimeticXMLforma
{
    public partial class Pregled_Podataka : Form
    {
        public Pregled_Podataka()
        {
            InitializeComponent();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            var listaUcenika = from ucenik in ///
                select ucenik;
            richTextBox1.Clear();
            foreach (var item in listaUcenika)
            {
                richTextBox1.Text += item.ToString() + "\n";
            }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filtriranje_Podataka frm = new Filtriranje_Podataka();
            frm.ShowDialog();
            this.Show();
            var listaUcenika = from Ucenik in ///
            
            richTextBox1.Clear();
            foreach(var item in listaUcenika)
            {
                richTextBox1.Text += item.ToString() + "\n";
            }
        }
        private void Pregled_Podataka_Load(object sender, EventArgs e)
        {

        }
        private void Pregled_Podataka_Load_1(object sender, EventArgs e)
        {

        }
    }
}
