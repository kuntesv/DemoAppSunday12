using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppSunday12
{
    public class UserInterface
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        private IBusiness obj = null;
        public UserInterface(IBusiness business) { 
            obj = business;
        }

        public void getData()
        {
            Console.WriteLine("Please enter username : ");
            UserName=  Console.ReadLine();

            Console.WriteLine("Please enter password : ");
            Password = Console.ReadLine();

            obj.SignUp(UserName, Password);
        }
    }
}
