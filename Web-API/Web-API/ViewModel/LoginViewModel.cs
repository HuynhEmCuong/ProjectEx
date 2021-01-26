using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.ViewModel
{
    public class LoginViewModel
    {
        public string  UserName { get; set; }
        public string  Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
