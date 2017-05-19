using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Entiteti
{
    public class fotografija
    {
        public virtual int Id {get; protected set;}
        public virtual string Path { get; set; }
        public virtual nekretnina Pripada { get; set; }

    }
}
