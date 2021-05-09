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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            Pregled_Podataka frm = new Pregled_Podataka();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
