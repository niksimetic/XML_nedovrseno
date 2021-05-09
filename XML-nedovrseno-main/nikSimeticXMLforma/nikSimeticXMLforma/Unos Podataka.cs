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
    public partial class Form2 : Form
    {
        List<Ucenik> listaUcenik = new List<Ucenik>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text) || string.IsNullOrEmpty(txtPrezime.Text) || string.IsNullOrEmpty(cmbRazred.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Niste unjeli sve podatke");
                return;
            }
            Ucenik ucenik = new Ucenik(txtIme.Text, txtPrezime.Text, cmbRazred.Text, txtEmail.Text);
            listaUcenik.Add(ucenik);

            txtIme.Clear();
            txtPrezime.Clear();
            txtEmail.Clear();
            cmbRazred.Text = " ";
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
