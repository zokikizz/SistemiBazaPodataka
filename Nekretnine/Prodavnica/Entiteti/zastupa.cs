using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Entiteti
{
    public class zastupa
    {
        public virtual int Id { get; protected set; }
        public virtual klijenti ZastupaKlijent { get; set; }
        public virtual pravniZastupnik ZastupaZastupnik { get; set; }
        public virtual int vazeciFleg { get; set; }
    }
}
