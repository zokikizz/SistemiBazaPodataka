using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Entiteti
{
    public class klijentTelefon
    {
        public virtual int Id { get; protected set; }
        public virtual long Br_Tel { get; set; }

        public virtual klijenti Pripada { get; set; }
        public virtual int Vazeci_Fleg { get; set; }
       

        
    }
}
