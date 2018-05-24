using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KishMish.Entities.TradersEntities
{
    public class BaseTraders
    {
        private string name;
        private string username;
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

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
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