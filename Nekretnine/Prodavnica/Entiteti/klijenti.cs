using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Entiteti
{
    public class klijenti
    {
        public virtual int Id { get; protected set; }
        public virtual string Email { get; set; }
        public virtual string Password {get; set;}
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Grad { get; set; }
        public virtual int Broj { get; set; }
        public virtual int Kupac_fleg { get; set; }

        public virtual int Prodavac_fleg { get; set; }

        public virtual IList<ugovor> UgovorOProdaji { get; set; }

        public virtual IList<ugovor> UgovorOKupovini { get; set; }

        public virtual IList<nekretnina> LicneNekretnine { get; set; }

        public virtual IList<klijentTelefon> brojeviTelefona { get; set; }

        public virtual IList<zastupa> pravniZastupnici { get; set; }
        public klijenti()
        {
            UgovorOProdaji = new List<ugovor>();
            UgovorOKupovini = new List<ugovor>();
            LicneNekretnine = new List<nekretnina>();
            brojeviTelefona = new List<klijentTelefon>();
            pravniZastupnici = new List<zastupa>();
        }
    }
}
