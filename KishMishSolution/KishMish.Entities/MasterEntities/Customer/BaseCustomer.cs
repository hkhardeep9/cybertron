using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KishMish.Entities.MasterEntities
{
    public abstract class BaseCustomer
    {
        private string customerCode;
        private string customerName;
        private string addressLine1;
        private string addressLine2;
        private string addressLine3;
        private string city;
        private string state;
        private string country;

        private int contactCountryCode;
        private int officeNumber1;
        private int mobileNumber1;
        private string emailID1;
        private int officeNumber2;
        private int mobileNumber2;
        private string emailID2;
        public string CustomerCode
        {
            get
            {
                return customerCode;
            }

            set
            {
                customerCode = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return addressLine1;
            }

            set
            {
                addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return addressLine2;
            }

            set
            {
                addressLine2 = value;
            }
        }

        public string AddressLine3
        {
            get
            {
                return addressLine3;
            }

            set
            {
                addressLine3 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public int ContactCountryCode
        {
            get
            {
                return contactCountryCode;
            }

            set
            {
                contactCountryCode = value;
            }
        }

        public int OfficeNumber1
        {
            get
            {
                return officeNumber1;
            }

            set
            {
                officeNumber1 = value;
            }
        }

        public int MobileNumber1
        {
            get
            {
                return mobileNumber1;
            }

            set
            {
                mobileNumber1 = value;
            }
        }

        public string EmailID1
        {
            get
            {
                return emailID1;
            }

            set
            {
                emailID1 = value;
            }
        }

        public int OfficeNumber2
        {
            get
            {
                return officeNumber2;
            }

            set
            {
                officeNumber2 = value;
            }
        }

        public int MobileNumber2
        {
            get
            {
                return mobileNumber2;
            }

            set
            {
                mobileNumber2 = value;
            }
        }

        public string EmailID2
        {
            get
            {
                return emailID2;
            }

            set
            {
                emailID2 = value;
            }
        }
    }
}