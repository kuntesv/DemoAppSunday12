using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppSunday12
{
    public class Business: IBusiness
    {
        IDataAccess obj = null;

        public Business(IDataAccess dataAccess)
        { 
         obj = dataAccess;
        }

        public void SignUp(string username, string password)
        {

           // IDataAccess obj = new DataAccessUsingNosql();
            obj.SignUp(username, password);
        }
    }
}
