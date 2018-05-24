using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KishMish.Web.Models.Traders
{
    public class VMTraders
    {
        private string name;
        private string userName;
        private string password;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}