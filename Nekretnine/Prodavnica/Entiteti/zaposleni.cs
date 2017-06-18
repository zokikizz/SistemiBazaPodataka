using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Entiteti
{
    public abstract class zaposleni
    {
        public virtual int Id_Zaposlenog { get; protected set; }
        public virtual string Email_Zaposlenog { get; set; }
        public virtual string Password_Zaposlenog { get; set; }

        public virtual string Tip { get; set; }

        

        public virtual IList<zaposleniTelefon> BrojeviTelefona { get; set; }

        
    }


    public class agent : zaposleni
    {
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int Staz { get; set; }
        public agent()
        {
            BrojeviTelefona = new List<zaposleniTelefon>();
        }

        public override string ToString()
        {
            return Ime + " " + Prezime ;
        }
    }

    public class admin : zaposleni
    {

    }
}
