using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Entiteti
{
    public abstract class ugovor
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime Datum_Potpisivanja { get; set; }
        public virtual float BonusAgentu { get; set; }
        public virtual float Naknada_Za_Agenciju { get; set; }
        public virtual nekretnina Nekretnina { get; set; }
        public virtual zaposleni Agent { get; set; }
        public virtual notar Notar { get; set; }
     //   public virtual pravniZastupnik Zastupnik_kupca  { get; set; }
      //  public virtual pravniZastupnik Zastupnik_prodavca { get; set; }
        //public virtual int Izdavanje_fleg { get; set; }
  

        public virtual string Tip_Ugovora { get; set; }

        
        public virtual klijenti Kupac_ili_zakupac { get; set; }
        public virtual klijenti Prodavac { get; set; }
        public virtual float Naknada_notaru { get; set; }
        public virtual float MesecnaRenta { get; set; }


    }

    public class kupoprodajni_ugovor : ugovor
    {
        public virtual float Osnovna_cena { get; set; }
        public kupoprodajni_ugovor()
        {

        }
    }

    public class ugovor_o_izdavanju : ugovor
    {
        public virtual DateTime Od { get; set; }
        public virtual DateTime Do { get; set; }
    }
}
