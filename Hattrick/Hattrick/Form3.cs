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
        SqlConnection cs = new SqlConnection("SERVER=Bosko-HP;DATABASE=ponudaBaza;Trusted_Connection=True");

        public double trenutnaKvota = 1.0;
        public double bonus = 0.0;
        public double uplata = 2.0;
        public double dobitak = 0.0;
        public double stanjeRacuna = Varijable.StanjeRacuna;
        Form2 frm2 = new Form2();
        
        List<CheckBox> groupOfCheckBoxes = new List<CheckBox>();
        List<List<string>> listaPonude = new List<List<string>>();
        List<string> listaSportova = new List<string>();

        public Form3()
        {
            InitializeComponent();
            lblStanjeRacuna.Text = stanjeRacuna.ToString("0.00");
        }

        private void btnNapuniPonudu_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ponudaTablica ORDER BY sport DESC", cs);

            DataTable dt = new DataTable();

            da.Fill(dt);

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
                    listaSportova.Add(trenutniSport);
                }

                lb.Text += listaPonude[i][2] + "-" + listaPonude[i][3];
                this.Controls.Add(lb);

                CheckBox cb = new CheckBox();
                groupOfCheckBoxes.Add(cb);
                cb.CheckStateChanged += PromijeniUkupnuKvotu;
                cb.Left = left + 150;
                cb.Top = top;
                cb.Name = listaPonude[i][1] +  "," + listaPonude[i][2];
                cb.Text = listaPonude[i][4];
                this.Controls.Add(cb);

                cb = new CheckBox();
                groupOfCheckBoxes.Add(cb);
                cb.CheckStateChanged += PromijeniUkupnuKvotu;
                cb.Left = left + 300;
                cb.Top = top;
                if(listaPonude[i][5] == "1.00")
                    cb.Visible = false;
                cb.Name = listaPonude[i][1] + "," + listaPonude[i][2] + "," + listaPonude[i][3];
                cb.Text = listaPonude[i][5];
                this.Controls.Add(cb);

                cb = new CheckBox();
                groupOfCheckBoxes.Add(cb);
                cb.CheckStateChanged += PromijeniUkupnuKvotu;
                cb.Left = left + 450;
                cb.Top = top;
                cb.Name = listaPonude[i][1] + "," + listaPonude[i][3];
                cb.Text = listaPonude[i][6];
                this.Controls.Add(cb);

                top += cb.Height + 15;

                btnNapuniPonudu.Enabled = false;
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

        private void btnUplatiListic_Click(object sender, EventArgs e)
        {
            bool oznacenBaremJedan = false;
            foreach (Control c in Controls.OfType<CheckBox>())
            {
                if (((CheckBox)c).Checked == true)
                {
                    oznacenBaremJedan = true;
                }
            }
            if (!oznacenBaremJedan)
                MessageBox.Show("Niste odabrali nijedan par!");
            else if (uplata < 2)
                MessageBox.Show("Minimalna uplata je 2 HRK!");
            else if (uplata > stanjeRacuna)
                MessageBox.Show("Nemate dovoljno novca na racunu!");
            else
            {
                string nazivCheckBoxa = "";
                string[] puniNaziv;
                string nazivSporta = "";
                string ekipa1 = "";
                string ekipa2 = "";
                string tip = "";
                string kvota = "";

                for (int i = 0; i < groupOfCheckBoxes.Count; i += 3)
                {
                    if ((groupOfCheckBoxes[i].Checked && (groupOfCheckBoxes[i + 1].Checked == false && groupOfCheckBoxes[i + 2].Checked == false)
                        || (groupOfCheckBoxes[i + 1].Checked && (groupOfCheckBoxes[i].Checked == false && groupOfCheckBoxes[i + 2].Checked == false)
                        || (groupOfCheckBoxes[i + 2].Checked && groupOfCheckBoxes[i].Checked == false && groupOfCheckBoxes[i + 1].Checked == false))))
                    {
                        if (groupOfCheckBoxes[i].Checked)
                        {
                            nazivCheckBoxa = (groupOfCheckBoxes[i+1].Name).ToString();
                            puniNaziv = nazivCheckBoxa.Split(',');
                            nazivSporta += puniNaziv[0] + ",";
                            ekipa1 += puniNaziv[1] + ",";
                            ekipa2 += puniNaziv[2] + ",";
                            tip += "1" + ",";
                            kvota += groupOfCheckBoxes[i].Text + ",";
                        }
                        else if (groupOfCheckBoxes[i + 1].Checked)
                        {
                            nazivCheckBoxa = (groupOfCheckBoxes[i + 1].Name).ToString();
                            puniNaziv = nazivCheckBoxa.Split(',');
                            nazivSporta += puniNaziv[0] + ",";
                            ekipa1 += puniNaziv[1] + ",";
                            ekipa2 += puniNaziv[2] + ",";
                            tip += "X" + ",";
                            kvota += groupOfCheckBoxes[i + 1].Text + ",";
                        }
                        else if (groupOfCheckBoxes[i + 2].Checked)
                        {
                            nazivCheckBoxa = (groupOfCheckBoxes[i + 1].Name).ToString();
                            puniNaziv = nazivCheckBoxa.Split(',');
                            nazivSporta += puniNaziv[0] + ",";
                            ekipa1 += puniNaziv[1] + ",";
                            ekipa2 += puniNaziv[2] + ",";
                            tip += "2" + ",";
                            kvota += groupOfCheckBoxes[i + 2].Text + ",";
                        }
                    }
                }

                cs.Open();
                SqlCommand cmd = cs.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into uplaceniListici values('" + nazivSporta + "', '" + ekipa1 + "', '" + ekipa2 + "', '" + tip +  "', '" + kvota + "', '" + lblBonus.Text + "', '" + lblUkupnaKvota.Text + "', '" + tbUplata.Text + "', '" + lblIsplata.Text + "')";
                cmd.ExecuteNonQuery();
                cs.Close();

                Varijable.StanjeRacuna -= double.Parse(tbUplata.Text, System.Globalization.CultureInfo.InvariantCulture);
                stanjeRacuna = Varijable.StanjeRacuna;
                lblStanjeRacuna.Text = stanjeRacuna.ToString("0.00");
                var src = DateTime.Now;
                var hm = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, src.Second);

                cs.Open();
                cmd = cs.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into transakcije values('" + "uplata" + "', '" + tbUplata.Text + "', '" + hm + "')";
                cmd.ExecuteNonQuery();
                cs.Close();

                MessageBox.Show("Uspjesno ste uplatili listic!");
            }
        }

        private void PromijeniUkupnuKvotu(object sender, EventArgs e)
        {
            trenutnaKvota = 1.0;
            int oznacenSusret = 0;
            int josJeSusret = 0;
            
            foreach (Control c in Controls.OfType<CheckBox>())
            {
                if (((CheckBox)c).Checked == true)
                {
                    oznacenSusret++;
                    if (oznacenSusret > 1)
                        ((CheckBox)c).Checked = false;    
                }
                josJeSusret++;
                if (josJeSusret == 3)
                {
                    oznacenSusret = 0;
                    josJeSusret = 0;
                }
            }

            trenutnaKvota = 1.00;
            int brojParova = 0;
            for (int i = 0; i < groupOfCheckBoxes.Count; i += 3)
            {
                if((groupOfCheckBoxes[i].Checked && (groupOfCheckBoxes[i+1].Checked == false && groupOfCheckBoxes[i+2].Checked == false)
                    || (groupOfCheckBoxes[i+1].Checked && (groupOfCheckBoxes[i].Checked == false && groupOfCheckBoxes[i+2].Checked == false)
                    || (groupOfCheckBoxes[i+2].Checked && groupOfCheckBoxes[i].Checked == false && groupOfCheckBoxes[i+1].Checked == false))))
                    {
                        brojParova++;
                        if(groupOfCheckBoxes[i].Checked)
                            trenutnaKvota *= double.Parse(groupOfCheckBoxes[i].Text.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                        else if(groupOfCheckBoxes[i+1].Checked)
                            trenutnaKvota *= double.Parse(groupOfCheckBoxes[i+1].Text.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                        else if(groupOfCheckBoxes[i+2].Checked)
                            trenutnaKvota *= double.Parse(groupOfCheckBoxes[i+2].Text.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            lblBrojParova.Text = brojParova.ToString();
            lblUkupnaKvota.Text = trenutnaKvota.ToString("0.00");

            ProvjeriBonuse();
        }

        private void ProvjeriBonuse()
        {
            bonus = 0.00;
            
            string nazivCheckBoxa = "";
            string[] nazivSporta;
            List<string> odabraniSportovi = new List<string>();

            for (int i = 0; i < groupOfCheckBoxes.Count; i += 3)
            {
                if ((groupOfCheckBoxes[i].Checked && (groupOfCheckBoxes[i + 1].Checked == false && groupOfCheckBoxes[i + 2].Checked == false)
                    || (groupOfCheckBoxes[i + 1].Checked && (groupOfCheckBoxes[i].Checked == false && groupOfCheckBoxes[i + 2].Checked == false)
                    || (groupOfCheckBoxes[i + 2].Checked && groupOfCheckBoxes[i].Checked == false && groupOfCheckBoxes[i + 1].Checked == false))))
                {
                    if (groupOfCheckBoxes[i].Checked)
                    {
                        nazivCheckBoxa = (groupOfCheckBoxes[i].Name).ToString();
                        nazivSporta = nazivCheckBoxa.Split(',');
                        odabraniSportovi.Add(nazivSporta[0]);
                    }
                    else if (groupOfCheckBoxes[i + 1].Checked)
                    {
                        nazivCheckBoxa = (groupOfCheckBoxes[i+1].Name).ToString();
                        nazivSporta = nazivCheckBoxa.Split(',');
                        odabraniSportovi.Add(nazivSporta[0]);
                    }
                    else if (groupOfCheckBoxes[i + 2].Checked)
                    {
                        nazivCheckBoxa = (groupOfCheckBoxes[i+2].Name).ToString();
                        nazivSporta = nazivCheckBoxa.Split(',');
                        odabraniSportovi.Add(nazivSporta[0]);
                    }
                }
            }

            int[] brojParovaSvakogSporta = new int[listaSportova.Count];

            for (int i = 0; i < listaSportova.Count; i++)
            {
                brojParovaSvakogSporta[i] = odabraniSportovi.Count(s => s.Contains(listaSportova[i]));
            }

            bool svakiSport = true;
            bonus = 0.00;
            for (int i = 0; i < brojParovaSvakogSporta.Length; i++)
            {
                if (brojParovaSvakogSporta[i] >= 3)
                    bonus += 5.00;
                if (brojParovaSvakogSporta[i] == 0)
                    svakiSport = false;
            }
            if (svakiSport == true)
                bonus += 10.00;

            lblBonus.Text = bonus.ToString();

            IzracunajDobitak();
        }

        private void tbUplata_TextChanged(object sender, EventArgs e)
        {
            IzracunajDobitak();
        }

        private void IzracunajDobitak()
        {
            dobitak = 2;
            try
            {
                uplata = double.Parse(tbUplata.Text.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                dobitak = (trenutnaKvota + bonus) * uplata;
                double porez = 0.1 * dobitak;
                dobitak = Math.Round(dobitak - porez, 2);
                lblIsplata.Text = dobitak.ToString("0.00");
            }
            catch { }
        }
    }
}
