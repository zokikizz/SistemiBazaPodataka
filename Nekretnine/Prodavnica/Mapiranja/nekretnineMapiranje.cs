using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SistemiBazaPodataka.Entiteti;

namespace SistemiBazaPodataka.Mapiranja
{
    class nekretnineMapiranje : ClassMap<nekretnina>
    {
        public nekretnineMapiranje()
        {
            Table("NEKRETNINE");

            DiscriminateSubClassesOnColumn("TIP_IZDAVANJA","NULL"); // po difoltu bice null i smatrace se da je za prodaju kada pravis nekretninu

            Id(x => x.Id, "ID_NEKRETNINE").GeneratedBy.TriggerIdentity();



            Map(x => x.Kvadratura, "KVADRATURA");

            Map(x => x.Cena, "CENA");
            Map(x => x.Tip, "TIP");
            Map(x => x.Opis, "OPIS");
            Map(x => x.Sprat_Broj, "SPRAT_BROJ");
            Map(x => x.Id_Ugovora_O_Zastupanju, "ID_UGOVORA_O_ZASTUPANJU");
            Map(x => x.Datum_Izgradnje, "DATUM_IZGRADNJE");
            Map(x => x.Broj, "BROJ");
            Map(x => x.U_Ponudi_Fleg, "U_PONUDI_FLEG");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Lokacija, "LOKACIJA");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Opstina, "OPSTINA");
            Map(x => x.Br_Parcele, "BR_PARCELE");

            Map(x => x.Tip_Ponude, "TIP_PONUDE");
            Map(x => x.Br_Meseci, "BR_MESECI");


            References(x => x.Agent).Column("ID_AGENTA").LazyLoad();
            References(x => x.Vlasnik).Column("ID_VLASNIKA").LazyLoad();

            HasMany(x => x.Fotografije).KeyColumn("ID_NEKRETNINE").LazyLoad().Cascade.All().Inverse();
            

            
        }

       
    }

    public class kraci_period_mapiranje : SubclassMap<kraci_period>
    {
        public kraci_period_mapiranje()
        {
            DiscriminatorValue("kraci");

            Map(x => x.Od, "OD");
            Map(x => x.Do, "DO");
            Map(x => x.Godina, "GODINA");
        }
    }

    public class duzi_period_mapiranje : SubclassMap<duzi_period>
    {
        public duzi_period_mapiranje()
        {
            DiscriminatorValue("duzi");

            Map(x => x.Fizicka_Pavna_Lica_Fleg, "FIZICKA_PRAVNA_LICA_FLEG");

        }
    }
}
