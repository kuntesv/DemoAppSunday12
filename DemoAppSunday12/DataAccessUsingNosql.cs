using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppSunday12
{
    public class DataAccessUsingNosql : IDataAccess
    {
        public void SignUp(string username, string password)
        {
            Console.WriteLine("Username " + username + "password " +
                password + "added using nosql database");
        }
    }
}
