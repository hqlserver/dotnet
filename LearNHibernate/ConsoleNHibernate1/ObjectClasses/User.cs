using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNHibernate1.ObjectClasses
{
    public class User
    {
        //public virtual int Id { get; set; }
        public virtual string Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
    }
}
