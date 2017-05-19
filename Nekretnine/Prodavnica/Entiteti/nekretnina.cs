using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Entiteti
{
    public class nekretnina
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime Datum_Izgradnje { get; set; }
        public virtual int Kvadratura { get; set; }
        public virtual int Cena { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Opis { get; set; }
        public virtual string Sprat_Broj { get; set; }
        public virtual int Id_Ugovora_O_Zastupanju { get; set; }
        public virtual int U_Ponudi_Fleg { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual string Opstina { get; set; }
        public virtual int Br_Parcele { get; set; }

        public virtual agent Agent { get; set; }
        public virtual klijenti Vlasnik { get; set; }

        public virtual IList<fotografija> Fotografije { get; set; }

        public virtual string Tip_Ponude { get; set; }
        public virtual string Tip_Izdavanja { get; set; }
        public virtual int Br_Meseci { get; set; }

        public nekretnina()
        {
            Tip_Ponude = "prodaja";
            Fotografije = new List<fotografija>();
        }


    }

    public class kraci_period : nekretnina
    {
        public virtual DateTime Od { get; set; }
        public virtual DateTime Do { get; set; }
        public virtual int Godina { get; set; }
        public kraci_period()
        {
            
            Tip_Ponude = "izdavanje";
        }
    }

    public class duzi_period : nekretnina
    {
        
        public virtual int? Fizicka_Pavna_Lica_Fleg { get; set; }
        public duzi_period()
        {
             //ovo ispravi u bazi da bude nullable ovde treba da se setuje BR_MESECI, a ne u caletovoj klasi ispravi!!!
            Tip_Ponude = "izdavanje";
        }
    }
}
