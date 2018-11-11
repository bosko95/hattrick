namespace Hattrick
{
    partial class Form1
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
            this.btnNovcanik = new System.Windows.Forms.Button();
            this.btnUplataListica = new System.Windows.Forms.Button();
            this.btnPregledListica = new System.Windows.Forms.Button();
            this.btnKraj = new System.Windows.Forms.Button();
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
            // btnNovcanik
            // 
            this.btnNovcanik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNovcanik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovcanik.Location = new System.Drawing.Point(370, 100);
            this.btnNovcanik.Name = "btnNovcanik";
            this.btnNovcanik.Size = new System.Drawing.Size(205, 50);
            this.btnNovcanik.TabIndex = 1;
            this.btnNovcanik.Text = "Novcanik";
            this.btnNovcanik.UseVisualStyleBackColor = false;
            this.btnNovcanik.Click += new System.EventHandler(this.btnNovcanik_Click);
            // 
            // btnUplataListica
            // 
            this.btnUplataListica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUplataListica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUplataListica.Location = new System.Drawing.Point(370, 174);
            this.btnUplataListica.Name = "btnUplataListica";
            this.btnUplataListica.Size = new System.Drawing.Size(205, 50);
            this.btnUplataListica.TabIndex = 2;
            this.btnUplataListica.Text = "Uplata listica";
            this.btnUplataListica.UseVisualStyleBackColor = false;
            this.btnUplataListica.Click += new System.EventHandler(this.btnUplataListica_Click);
            // 
            // btnPregledListica
            // 
            this.btnPregledListica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPregledListica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregledListica.Location = new System.Drawing.Point(370, 250);
            this.btnPregledListica.Name = "btnPregledListica";
            this.btnPregledListica.Size = new System.Drawing.Size(205, 50);
            this.btnPregledListica.TabIndex = 3;
            this.btnPregledListica.Text = "Pregled listica";
            this.btnPregledListica.UseVisualStyleBackColor = false;
            this.btnPregledListica.Click += new System.EventHandler(this.btnPregledListica_Click);
            // 
            // btnKraj
            // 
            this.btnKraj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKraj.Location = new System.Drawing.Point(872, 299);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(100, 50);
            this.btnKraj.TabIndex = 4;
            this.btnKraj.Text = "Kraj";
            this.btnKraj.UseVisualStyleBackColor = false;
            this.btnKraj.Click += new System.EventHandler(this.btnKraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.btnKraj);
            this.Controls.Add(this.btnPregledListica);
            this.Controls.Add(this.btnUplataListica);
            this.Controls.Add(this.btnNovcanik);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Glavni izbornik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovcanik;
        private System.Windows.Forms.Button btnUplataListica;
        private System.Windows.Forms.Button btnPregledListica;
        private System.Windows.Forms.Button btnKraj;
    }
}

