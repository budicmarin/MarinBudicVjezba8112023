using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinBudicVjezba8112023
{
    public class DAL
    {
        
        public static List<Korisnik> GetKorisnici()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            korisnici.Add(new Korisnik("Marinko", "Lozinka", "Marin", new DateTime(2002, 10, 27)));
            korisnici.Add(new Korisnik("Lukica", "Lozinka", "Lukic", new DateTime(2003, 12, 25)));
            return korisnici;
        }

    }
}
