using FluentNHibernate.Mapping;
using SistemiBazaPodataka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemiBazaPodataka.Mapiranja
{
    class notarMapiranje : ClassMap<notar>
    {
        public notarMapiranje()
        {
            Table("NOTAR");


            Id(x => x.Id, "ID_NOTARA").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");

            Map(x => x.Prezime, "PREZIME");

            HasMany(x => x.Ugovori).KeyColumn("ID_NOTARA").LazyLoad().Cascade.All().Inverse();
        }

    }
}
