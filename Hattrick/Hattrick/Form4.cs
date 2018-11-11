using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hattrick
{
    public partial class Form4 : Form
    {
        SqlConnection cs = new SqlConnection("SERVER=Bosko-HP;DATABASE=ponudaBaza;Trusted_Connection=True");

        public Form4()
        {
            InitializeComponent();
            DobaviListice();
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

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DobaviListice()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM uplaceniListici", cs);

            DataTable dt = new DataTable();

            da.Fill(dt);

            lblListici.Text = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["id"].ToString();
                string bonus = dt.Rows[i]["bonus"].ToString();
                string ukupnaKvota = dt.Rows[i]["ukupnaKvota"].ToString();
                string uplata = dt.Rows[i]["uplata"].ToString();
                string isplata = dt.Rows[i]["isplata"].ToString();

                string sportovi = dt.Rows[i]["sport"].ToString();
                string[] sport = sportovi.Split(',');

                string ekipe1 = dt.Rows[i]["ekipa1"].ToString();
                string[] ekipa1 = ekipe1.Split(',');

                string ekipe2 = dt.Rows[i]["ekipa2"].ToString();
                string[] ekipa2 = ekipe2.Split(',');

                string tipovi = dt.Rows[i]["tip"].ToString();
                string[] tip = tipovi.Split(',');

                string kvote = dt.Rows[i]["kvota"].ToString();
                string[] kvota = kvote.Split(',');

                lblListici.Text += "Listic broj: " + id + "\n";
                lblListici.Text += "Broj parova: " + (sport.Length - 1) + "\n";

                for (int j = 0; j < sport.Length -1; j++)
                {
                    lblListici.Text += sport[j] + ": " + ekipa1[j] + " - " + ekipa2[j] + " " + tip[j] + " " + kvota[j] + "\n";
                }
                lblListici.Text += "\nBonus: " + bonus + "   Kvota: " + ukupnaKvota + "\nUplata: " + uplata + "   Isplata: " + isplata + "\n" + "\n" + "\n";
            }
        }
    }
}
