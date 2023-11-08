namespace MarinBudicVjezba8112023
{
    partial class NoviKorisnik
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
            this.lbIme = new System.Windows.Forms.Label();
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.lbDatum = new System.Windows.Forms.Label();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.Kreiraj = new System.Windows.Forms.Button();
            this.txIme = new System.Windows.Forms.TextBox();
            this.txKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txLozinka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(68, 62);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(29, 16);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "Ime";
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Location = new System.Drawing.Point(68, 99);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(94, 16);
            this.lbKorisnickoIme.TabIndex = 1;
            this.lbKorisnickoIme.Text = "Korisničko Ime";
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Location = new System.Drawing.Point(68, 143);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(53, 16);
            this.lbLozinka.TabIndex = 2;
            this.lbLozinka.Text = "Lozinka";
            // 
            // lbDatum
            // 
            this.lbDatum.AutoSize = true;
            this.lbDatum.Location = new System.Drawing.Point(68, 191);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDatum.Size = new System.Drawing.Size(46, 16);
            this.lbDatum.TabIndex = 3;
            this.lbDatum.Text = "Datum";
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(204, 184);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 22);
            this.dtDatum.TabIndex = 4;
            // 
            // Kreiraj
            // 
            this.Kreiraj.Location = new System.Drawing.Point(233, 301);
            this.Kreiraj.Name = "Kreiraj";
            this.Kreiraj.Size = new System.Drawing.Size(221, 23);
            this.Kreiraj.TabIndex = 5;
            this.Kreiraj.Text = "Dodaj Korisnika";
            this.Kreiraj.UseVisualStyleBackColor = true;
            this.Kreiraj.Click += new System.EventHandler(this.Kreiraj_Click);
            // 
            // txIme
            // 
            this.txIme.Location = new System.Drawing.Point(251, 62);
            this.txIme.Name = "txIme";
            this.txIme.Size = new System.Drawing.Size(100, 22);
            this.txIme.TabIndex = 6;
            // 
            // txKorisnickoIme
            // 
            this.txKorisnickoIme.Location = new System.Drawing.Point(251, 96);
            this.txKorisnickoIme.Name = "txKorisnickoIme";
            this.txKorisnickoIme.Size = new System.Drawing.Size(100, 22);
            this.txKorisnickoIme.TabIndex = 7;
            // 
            // txLozinka
            // 
            this.txLozinka.Location = new System.Drawing.Point(251, 143);
            this.txLozinka.Name = "txLozinka";
            this.txLozinka.Size = new System.Drawing.Size(100, 22);
            this.txLozinka.TabIndex = 8;
            // 
            // NoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txLozinka);
            this.Controls.Add(this.txKorisnickoIme);
            this.Controls.Add(this.txIme);
            this.Controls.Add(this.Kreiraj);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.lbDatum);
            this.Controls.Add(this.lbLozinka);
            this.Controls.Add(this.lbKorisnickoIme);
            this.Controls.Add(this.lbIme);
            this.Name = "NoviKorisnik";
            this.Text = "NoviKorisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.Label lbDatum;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Button Kreiraj;
        private System.Windows.Forms.TextBox txIme;
        private System.Windows.Forms.TextBox txKorisnickoIme;
        private System.Windows.Forms.TextBox txLozinka;
    }
}