using ConsoleNHibernate1.ObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNHibernate1
{
    class Program
    {
        static void Main(string[] args)
        {
            NHFactoryManager.Initialize();
            using (var session = NHFactoryManager.GetSession())
            {
                //var query = (from user in session.QueryOver<User>()
                //             select user);
                var userList = session.QueryOver<User>()
                               .SelectList(list => list
                                    .Select(u => u.UserName)
                                    .Select(u => u.Password)
                               ).List<object[]>();                               

                foreach (var item in userList)
                {
                    Console.WriteLine(item[0] + "/" + item[1]);
                }

                //Console.WriteLine(userList);
            }
            Console.ReadLine();
        }
    }
}
