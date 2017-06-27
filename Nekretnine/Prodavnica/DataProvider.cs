using NHibernate;
using SistemiBazaPodataka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class DataProvider
    {
        public void Get()
        {
            ISession s = DataLayer.GetSession();
        }
    }
}
