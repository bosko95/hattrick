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
    public partial class Form2 : Form
    {
        SqlConnection cs = new SqlConnection("SERVER=Bosko-HP;DATABASE=ponudaBaza;Trusted_Connection=True");

        public double stanjeRacuna;
        public string transakcije;

        public Form2()
        {
            InitializeComponent();
            stanjeRacuna = Varijable.StanjeRacuna;
            lblStanjeRacuna.Text = stanjeRacuna.ToString("0.00");
        }

        private void btnObnoviRacun_Click(object sender, EventArgs e)
        {
            Varijable.StanjeRacuna = 999.00;
            stanjeRacuna = Varijable.StanjeRacuna;
            lblStanjeRacuna.Text = stanjeRacuna.ToString("0.00");

            var src = DateTime.Now;
            var hm = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, src.Second);
            cs.Open();
            SqlCommand cmd = cs.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into transakcije values('" + "obnova racuna" + "', '" + "999.00" + "', '" + hm + "')";
            cmd.ExecuteNonQuery();
            cs.Close();

            IspisTransakcija();
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


        private void btnIspisTransakcija_Click(object sender, EventArgs e)
        {
            IspisTransakcija();
        }

        private void IspisTransakcija()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM transakcije", cs);

            DataTable dt = new DataTable();

            da.Fill(dt);

            string id, tip, iznos, hm;
            lblTransakcije.Text = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = dt.Rows[i]["id"].ToString();
                tip = dt.Rows[i]["tip"].ToString();
                iznos = dt.Rows[i]["iznos"].ToString();
                hm = dt.Rows[i]["vrijeme"].ToString();

                lblTransakcije.Text += id + ". transakcija: \n " + hm + "   " + tip + "   Iznos: " + iznos + "\n" + "\n";
            }
        }
    }
}
