using FluentNHibernate.Mapping;
using SistemiBazaPodataka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica.Mapiranja
{
    class pravniZastupnikMapiranja : ClassMap<pravniZastupnik>
    {
        public pravniZastupnikMapiranja()
        {
            Table("PRAVNI_ZASTUPNIK");

            Id(x => x.Id, "ID_ZASTUPNIKA").GeneratedBy.TriggerIdentity();


            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.MatBr, "MAT_BR");
            Map(x => x.NazivAgencije, "NAZIV_AGENCIJE");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Broj, "BROJ_U_ULICI");

            //HasManyToMany(x => x.KlijetiKojeZastupa)
            //    .Table("ZASTUPA")
            //    .ParentKeyColumn("ID_ZASTUPNIKA")
            //    .ChildKeyColumn("ID_KLIJENTA").Cascade.All();

            HasMany(x => x.KlijetiKojeZastupa).Table("ZASTUPA").KeyColumn("ID_ZASTUPNIKA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
