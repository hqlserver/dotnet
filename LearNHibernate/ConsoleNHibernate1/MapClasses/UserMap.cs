using ConsoleNHibernate1.ObjectClasses;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNHibernate1.MapClasses
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("[User]");
            Id(u => u.Id).Column("username");
            Map(u => u.UserName).Column("username");
            Map(u => u.Password).Column("pwd");
        }
    }
}
