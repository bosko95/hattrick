using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hattrick
{
    public partial class Form2 : Form
    {
        public int stanjeRacuna = 1000;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnObnoviRacun_Click(object sender, EventArgs e)
        {
            stanjeRacuna = 1000;
            lblStanjeRacuna.Text = stanjeRacuna.ToString();
        }

        private void btnIzbornik_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }

        private void btnKraj_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
