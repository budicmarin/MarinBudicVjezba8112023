using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarinBudicVjezba8112023
{
    public partial class NoviKorisnik : Form
    {
        public NoviKorisnik()
        {
            InitializeComponent();
        }
        private Korisnik _korisnik
;        public Korisnik Korisnik
        {
            get { return _korisnik; }
        }
        private void Kreiraj_Click(object sender, EventArgs e)
        {
            _korisnik = new Korisnik();
            _korisnik.Username = txKorisnickoIme.Text;
            _korisnik.Password=txLozinka.Text;
            _korisnik.Name = txIme.Text;
            _korisnik.Date = dtDatum.Value;

            this.Close();
        }
    }
}
