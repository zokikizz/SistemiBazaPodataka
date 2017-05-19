using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using SistemiBazaPodataka.Entiteti;


namespace SistemiBazaPodataka.Mapiranja
{
    public class zaposleniMapiranje : ClassMap<zaposleni>
    {
        public zaposleniMapiranje()
        {
            Table("ZAPOSLENI");
            DiscriminateSubClassesOnColumn("TIP");

            Id(x => x.Id_Zaposlenog, "ID_ZAPOSLENOG").GeneratedBy.TriggerIdentity();

            Map(x => x.Email_Zaposlenog, "EMAIL_ZAPOSLENOG");
            Map(x => x.Password_Zaposlenog, "PASSWORD_ZAPOSLENOG");

            HasMany(x => x.BrojeviTelefona).KeyColumn("ID_ZAPOSLENOG").LazyLoad().Cascade.All().Inverse();
        }
        
    }

    public class agentMapiranje : SubclassMap<agent>
    {
        public agentMapiranje()
        {
            DiscriminatorValue("agent");
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Staz, "STAZ");
        }
    }

    public class adminMapiranje : SubclassMap<admin>
    {
        public adminMapiranje()
        {
            DiscriminatorValue("admin");
        }
    }
}
