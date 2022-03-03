using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUnitTestsPoc.Pages
{
    public class LoginProcessor : ILoginProcessor
    {
        public bool Login(string email, string password)
        {
            return true;
        }
    }
}
