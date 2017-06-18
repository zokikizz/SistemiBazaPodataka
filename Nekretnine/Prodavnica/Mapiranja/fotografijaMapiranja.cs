using FluentNHibernate.Mapping;
using SistemiBazaPodataka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica.Mapiranja
{
    class fotografijaMapiranja : ClassMap<fotografija>
    {
        public fotografijaMapiranja()
        {
            Table("FOTOGRAFIJA");

            Id(x => x.Id, "ID_FOTO").GeneratedBy.TriggerIdentity();


            Map(x => x.foto, "FOTO_BLOB");

            References(x => x.Pripada).Column("ID_NEKRETNINE").LazyLoad();
        }
    }
}
