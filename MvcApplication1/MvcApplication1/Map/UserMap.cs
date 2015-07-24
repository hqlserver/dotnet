using FluentNHibernate.Mapping;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Map
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