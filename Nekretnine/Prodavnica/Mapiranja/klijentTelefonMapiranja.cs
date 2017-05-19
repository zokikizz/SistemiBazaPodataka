using FluentNHibernate.Mapping;
using SistemiBazaPodataka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica.Mapiranja
{
    class klijentTelefonMapiranja : ClassMap<klijentTelefon>
    {
        public klijentTelefonMapiranja()
        {
            Table("BR_TEL_KLIJENATA");

            Id(x => x.Id, "ID_BR_TEL").GeneratedBy.TriggerIdentity();


            Map(x => x.Br_Tel, "BR_TEL");
            Map(x => x.Vazeci_Fleg, "VAZECI_FLEG");

            References(x => x.Pripada).Column("ID_KLIJENTA").LazyLoad();
        }
    }
}
