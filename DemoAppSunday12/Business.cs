using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppSunday12
{
    public class Business
    {

        public void SignUp(string username, string password)
        {

            DataAccess obj = new DataAccess();
            obj.SignUp(username, password);
        }
    }
}
