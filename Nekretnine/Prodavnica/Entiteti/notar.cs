using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Entiteti
{
    public class notar
    {
        public virtual int Id { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
       public virtual IList<ugovor> Ugovori { get; set; }

        public notar()
        {
            Ugovori = new List<ugovor>();
        }
    }
}
