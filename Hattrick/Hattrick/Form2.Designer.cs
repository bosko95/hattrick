namespace Hattrick
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnKraj = new System.Windows.Forms.Button();
            this.btnIzbornik = new System.Windows.Forms.Button();
            this.btnObnoviRacun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStanjeRacuna = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTransakcije = new System.Windows.Forms.Label();
            this.btnIspisTransakcija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(320, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikacija za kladenje";
            // 
            // btnKraj
            // 
            this.btnKraj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKraj.Location = new System.Drawing.Point(825, 299);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(147, 50);
            this.btnKraj.TabIndex = 4;
            this.btnKraj.Text = "Kraj";
            this.btnKraj.UseVisualStyleBackColor = false;
            this.btnKraj.Click += new System.EventHandler(this.btnKraj_Click);
            // 
            // btnIzbornik
            // 
            this.btnIzbornik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzbornik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbornik.Location = new System.Drawing.Point(825, 225);
            this.btnIzbornik.Name = "btnIzbornik";
            this.btnIzbornik.Size = new System.Drawing.Size(147, 50);
            this.btnIzbornik.TabIndex = 5;
            this.btnIzbornik.Text = "Glavni izbornik";
            this.btnIzbornik.UseVisualStyleBackColor = false;
            this.btnIzbornik.Click += new System.EventHandler(this.btnIzbornik_Click);
            // 
            // btnObnoviRacun
            // 
            this.btnObnoviRacun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnObnoviRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObnoviRacun.Location = new System.Drawing.Point(825, 152);
            this.btnObnoviRacun.Name = "btnObnoviRacun";
            this.btnObnoviRacun.Size = new System.Drawing.Size(147, 50);
            this.btnObnoviRacun.TabIndex = 6;
            this.btnObnoviRacun.Text = "Obnovi racun";
            this.btnObnoviRacun.UseVisualStyleBackColor = false;
            this.btnObnoviRacun.Click += new System.EventHandler(this.btnObnoviRacun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stanje racuna (HRK): ";
            // 
            // lblStanjeRacuna
            // 
            this.lblStanjeRacuna.AutoSize = true;
            this.lblStanjeRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStanjeRacuna.Location = new System.Drawing.Point(203, 88);
            this.lblStanjeRacuna.Name = "lblStanjeRacuna";
            this.lblStanjeRacuna.Size = new System.Drawing.Size(64, 20);
            this.lblStanjeRacuna.TabIndex = 8;
            this.lblStanjeRacuna.Text = "100.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Transakcije:";
            // 
            // lblTransakcije
            // 
            this.lblTransakcije.AutoSize = true;
            this.lblTransakcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTransakcije.Location = new System.Drawing.Point(13, 170);
            this.lblTransakcije.Name = "lblTransakcije";
            this.lblTransakcije.Size = new System.Drawing.Size(0, 15);
            this.lblTransakcije.TabIndex = 10;
            // 
            // btnIspisTransakcija
            // 
            this.btnIspisTransakcija.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIspisTransakcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspisTransakcija.Location = new System.Drawing.Point(825, 73);
            this.btnIspisTransakcija.Name = "btnIspisTransakcija";
            this.btnIspisTransakcija.Size = new System.Drawing.Size(147, 50);
            this.btnIspisTransakcija.TabIndex = 11;
            this.btnIspisTransakcija.Text = "Ispis transakcija";
            this.btnIspisTransakcija.UseVisualStyleBackColor = false;
            this.btnIspisTransakcija.Click += new System.EventHandler(this.btnIspisTransakcija_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.btnIspisTransakcija);
            this.Controls.Add(this.lblTransakcije);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStanjeRacuna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObnoviRacun);
            this.Controls.Add(this.btnIzbornik);
            this.Controls.Add(this.btnKraj);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Novcanik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKraj;
        private System.Windows.Forms.Button btnIzbornik;
        private System.Windows.Forms.Button btnObnoviRacun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStanjeRacuna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTransakcije;
        private System.Windows.Forms.Button btnIspisTransakcija;
    }
}

