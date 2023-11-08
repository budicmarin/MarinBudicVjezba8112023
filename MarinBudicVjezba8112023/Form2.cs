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
    public partial class Form2 : Form
    {
        List<Korisnik> lista=new List<Korisnik>();

        public Form2()
        {
            InitializeComponent();
             lista= DAL.GetKorisnici();
            Refresh();
        }
        public void Refresh()
        {
            dGKorisnici.DataSource=new List<Korisnik>(lista);
            dGKorisnici.Refresh();
        }

        private void btNoviKorisnik_Click(object sender, EventArgs e)
        {
            NoviKorisnik noviKorisnik=new NoviKorisnik();   
            noviKorisnik.ShowDialog();
            if (noviKorisnik.Korisnik!=null) {
                lista.Add(noviKorisnik.Korisnik);
                
            }
            Refresh();
        }
    }
}
