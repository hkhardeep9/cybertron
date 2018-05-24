using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KishMish.Data.DataAccessLayer
{
    public static class DATraders
    {
        public static bool DA_AuthenticateLoginDetails(string userName, string password)
        {
            if (userName == "vaibhav" && password == "vaibhav")
            { return true; }
            else { return false; }
        }
    }
}