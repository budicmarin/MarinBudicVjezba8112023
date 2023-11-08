namespace MarinBudicVjezba8112023
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
            this.dGKorisnici = new System.Windows.Forms.DataGridView();
            this.btNoviKorisnik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dGKorisnici
            // 
            this.dGKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGKorisnici.Location = new System.Drawing.Point(53, 84);
            this.dGKorisnici.Name = "dGKorisnici";
            this.dGKorisnici.RowHeadersWidth = 51;
            this.dGKorisnici.RowTemplate.Height = 24;
            this.dGKorisnici.Size = new System.Drawing.Size(662, 359);
            this.dGKorisnici.TabIndex = 0;
            // 
            // btNoviKorisnik
            // 
            this.btNoviKorisnik.Location = new System.Drawing.Point(527, 460);
            this.btNoviKorisnik.Name = "btNoviKorisnik";
            this.btNoviKorisnik.Size = new System.Drawing.Size(180, 23);
            this.btNoviKorisnik.TabIndex = 1;
            this.btNoviKorisnik.Text = "Novi Korisnik";
            this.btNoviKorisnik.UseVisualStyleBackColor = true;
            this.btNoviKorisnik.Click += new System.EventHandler(this.btNoviKorisnik_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btNoviKorisnik);
            this.Controls.Add(this.dGKorisnici);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dGKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGKorisnici;
        private System.Windows.Forms.Button btNoviKorisnik;
    }
}