using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNHibernate1
{
    public static class NHFactoryManager
    {
        private static ISessionFactory sessionFactory;

        public static void Initialize()
        {
            sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("NHConnectionString")).ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                        .BuildSessionFactory();
        }

        public static ISession GetSession()
        {
            return sessionFactory.OpenSession();
        }
    }
}
