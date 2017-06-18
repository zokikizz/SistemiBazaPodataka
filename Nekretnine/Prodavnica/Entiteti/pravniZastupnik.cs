using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Entiteti
{
    public class pravniZastupnik
    {
        public virtual int Id { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }

        public virtual long MatBr { get; set; }
        public virtual string NazivAgencije { get; set; }
        public virtual string Grad { get; set; }

        public virtual string Ulica { get; set; }

        public virtual int Broj { get; set; }

        public virtual IList<zastupa> KlijetiKojeZastupa { get; set; }

        public pravniZastupnik()
        {
            KlijetiKojeZastupa = new List<zastupa>();
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
