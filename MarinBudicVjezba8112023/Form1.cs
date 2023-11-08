using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarinBudicVjezba8112023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        string username = "Milenko";
        string password = "lozinka";
        private void btLogin_Click(object sender, EventArgs e)
        {
            Form2 forma=new Form2();
            
           
            foreach (Korisnik korisnik in DAL.GetKorisnici() )
            {
                if (txUsername.Text == korisnik.Username) {

                    if (txPassword.Text == korisnik.Password) {
                        forma.Show();
                    }
                    else MessageBox.Show("Progrešano Korisničko Ime ili Lozinka");

                } 
                
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
