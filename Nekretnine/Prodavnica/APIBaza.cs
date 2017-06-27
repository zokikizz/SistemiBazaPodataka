using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using NHibernate.Linq;
using System.Web;


namespace Prodavnica
{
    public static class APIBaza
    {
        public static T setComplexToNull<T>(T entity)
        {
            foreach (var prop in entity.GetType().GetProperties().Where(
                p => !p.PropertyType.IsValueType && p.PropertyType != typeof(string)))
            {
               prop.SetValue(entity, null, null);
           
            }

            return entity;
        }


        public static IEnumerable<T> GetEntities<T>()
        {
            ISession s = DataLayer.GetSession();
            IEnumerable<T> entities = s.Query<T>().Select(p => setComplexToNull(p));
           
            return entities;
        }

        public static T GetEntity<T>(int id)
        {
            ISession s = DataLayer.GetSession();
            T ent = s.Get<T>(id);
            setComplexToNull<T>(ent);
            return ent;
        }


        public static void AddEntity<T>(T ent, bool setToNull = true)
        {
            ISession s = DataLayer.GetSession();
            if (setToNull)
                setComplexToNull(ent);
            s.Save(ent);
            s.Flush();
            s.Close();
        }


        public static void UpdateEntity<T>(int id, T ent)
        {
            ISession s = DataLayer.GetSession();
            T e = s.Load<T>(id);

            var prop = ent.GetType().GetProperties();
            foreach (var p in prop)
            {
                // preskace veze
                if (!p.PropertyType.IsValueType && p.PropertyType != typeof(string))
                    continue;

                var propValEnt = p.GetValue(ent, null);
                if (propValEnt != null && !p.Name.ToUpper().Contains("ID")) //da ne setujem ID na 0 ukoliko nije poslat
                {
                    p.SetValue(e, propValEnt, null);
                }
            }
            s.SaveOrUpdate(e);
            s.Flush();
            s.Close();
        }

        public static void RemoveEntity<T>(int id)
        {
            ISession s = DataLayer.GetSession();
            T ent = s.Get<T>(id);
            setComplexToNull<T>(ent);
            s.Delete(ent);
            s.Flush();
            s.Close();
        }

    }
}
