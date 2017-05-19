using FluentNHibernate.Mapping;
using SistemiBazaPodataka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica.Mapiranja
{
    class zastupaMapiranja : ClassMap<zastupa>
    {
        public zastupaMapiranja()
        {
            Table("ZASTUPA");

            Id(x => x.Id, "ID_ZASTUPA").GeneratedBy.TriggerIdentity();


            Map(x => x.vazeciFleg, "VAZECE_ZASTUPNISTVO_FLEG");
           

            References(x => x.ZastupaKlijent).Column("ID_KLIJENTA").LazyLoad();
            References(x => x.ZastupaZastupnik).Column("ID_ZASTUPNIKA").LazyLoad();


        }
    }
}
