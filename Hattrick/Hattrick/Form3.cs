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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNapuniPonudu_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection("SERVER=Bosko-HP;DATABASE=ponudaBaza;Trusted_Connection=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ponudaTablica ORDER BY sport DESC", cs);

            DataTable dt = new DataTable();

            da.Fill(dt);

            List<List<string>> listaPonude = new List<List<string>>();
            string trenutniSport = "";
            int top = 115;
            int left = 15;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listaPonude.Add(new List<string>
                {
                    dt.Rows[i]["id"].ToString(), dt.Rows[i]["sport"].ToString(),
                    dt.Rows[i]["domacin"].ToString(), dt.Rows[i]["gost"].ToString(),
                    dt.Rows[i]["kvota1"].ToString(), dt.Rows[i]["kvotaX"].ToString(),
                    dt.Rows[i]["kvota2"].ToString(), dt.Rows[i]["vrijeme"].ToString()
                });

                Label lb = new Label();
                lb.Left = left;
                lb.Top = top;
                lb.Height = 30;

                if(trenutniSport != dt.Rows[i]["sport"].ToString())
                {
                    trenutniSport = dt.Rows[i]["sport"].ToString();
                    lb.Text = dt.Rows[i]["sport"].ToString() + "\n";
                }

                lb.Text += listaPonude[i][2] + "-" + listaPonude[i][3];
                this.Controls.Add(lb);

                CheckBox cb = new CheckBox();
                cb.Left = left + 150;
                cb.Top = top;
                cb.Name = "cb" + listaPonude[i][0] + listaPonude[i][2];
                cb.Text = listaPonude[i][4];
                this.Controls.Add(cb);

                if(listaPonude[i][5] != "1.00")
                {
                    cb = new CheckBox();
                    cb.Left = left + 300;
                    cb.Top = top;
                    cb.Name = "cb" + listaPonude[i][0] + listaPonude[i][2] + listaPonude[i][3];
                    cb.Text = listaPonude[i][5];
                    this.Controls.Add(cb);
                }

                cb = new CheckBox();
                cb.Left = left + 450;
                cb.Top = top;
                cb.Name = "cb" + listaPonude[i][0] + listaPonude[i][3];
                cb.Text = listaPonude[i][6];
                this.Controls.Add(cb);

                top += cb.Height + 15;
            }
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

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
