using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFAOSToolCore.FlashAir
{
    public struct AuthCreds
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public AuthCreds(string uname, string passwd)
        {
            Username = uname;
            Password = passwd;
        }
    }
}
