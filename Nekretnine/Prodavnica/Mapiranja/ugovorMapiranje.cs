using FluentNHibernate.Mapping;
using SistemiBazaPodataka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Mapiranja
{
    public class ugovorMapiranje : ClassMap<ugovor>
    {
        public ugovorMapiranje()
        {
            
            Table("UGOVOR");

            DiscriminateSubClassesOnColumn("TIP_UGOVORA");

            Id(x => x.Id, "ID_UGOVORA").GeneratedBy.TriggerIdentity();

            Map(x => x.Datum_Potpisivanja, "DAT_POTPISIVANJA");
            Map(x => x.BonusAgentu, "BONUS_AGENTU");
            Map(x => x.Naknada_Za_Agenciju, "NAKNADA_AGENCIJI");
            Map(x => x.Naknada_notaru, "NAKNADA_NOTARU");

            References(x => x.Kupac_ili_zakupac).Column("ID_KUPCA_ILI_ZAKUPCA").LazyLoad().Cascade.SaveUpdate();

            References(x => x.Prodavac).Column("ID_PRODAVCA").LazyLoad().Cascade.SaveUpdate();

            References(x => x.Nekretnina).Column("ID_NEKRETNINE").LazyLoad().Cascade.SaveUpdate();


            References(x => x.Agent).Column("ID_AGENTA").LazyLoad().Cascade.SaveUpdate();


            References(x => x.Notar).Column("ID_NOTARA").LazyLoad().Cascade.SaveUpdate();

          



        }
    }

    public class kupoprodajni_ugovorMapiranje : SubclassMap<kupoprodajni_ugovor>
    {

        public kupoprodajni_ugovorMapiranje()
        {
            DiscriminatorValue("kupoprodajni");
            Map(x => x.Osnovna_cena, "OSNOVNA_CENA");
        }
    }

    public class ugovor_o_zakupuMapiranje : SubclassMap<ugovor_o_izdavanju>
    {
        public ugovor_o_zakupuMapiranje()
        {
            DiscriminatorValue("o_zakupu");
            Map(x => x.Od, "OD");
            Map(x => x.Do, "DO");
            Map(x => x.MesecnaRenta, "MESECNA_RENTA");
        }
    }
}
