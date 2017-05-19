using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemiBazaPodataka.Entiteti;

namespace SistemiBazaPodataka.Mapiranja
{
    public class klijentMapiranje : ClassMap<klijenti>
    {
        public klijentMapiranje()
        {
            Table("KLIJENTI");

            Id(x => x.Id, "ID_KLIJENTA").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");


            Map(x => x.Prezime, "PREZIME");

            Map(x => x.Password, "PASSWORD_KORISNIKA");

            Map(x => x.Grad, "GRAD");

            Map(x => x.Ulica, "ULICA");

            Map(x => x.Email, "EMAIL_KORISNIKA");

            Map(x => x.Broj, "BROJ_U_ULICI");

            Map(x => x.Kupac_fleg, "KUPAC_FLEG");

            Map(x => x.Prodavac_fleg, "PRODAVAC_FLEG");

            HasMany(x => x.UgovorOKupovini).KeyColumn("ID_KUPCA_ILI_ZAKUPCA").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.UgovorOProdaji).KeyColumn("ID_PRODAVCA").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.LicneNekretnine).KeyColumn("ID_VLASNIKA").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.brojeviTelefona).KeyColumn("ID_KLIJENTA").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.pravniZastupnici).Table("ZASTUPA").KeyColumn("ID_KLIJENTA").LazyLoad().Cascade.All().Inverse();
           //// HasManyToMany(x => x.pravniZastupnici)
           //     .Table("ZASTUPA")
           //     .ParentKeyColumn("ID_KLIJENTA")
           //     .ChildKeyColumn("ID_ZASTUPNIKA")
           //     .Cascade.All();

        }
    }
}
