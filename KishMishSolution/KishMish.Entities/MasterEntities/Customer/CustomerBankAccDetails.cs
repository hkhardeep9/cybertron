using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KishMish.Entities.MasterEntities.Customer
{
    public class CustomerBankAccDetails
    {
        private string bankAccountName;
        private UInt64 bankAccountNumber;
        private string ifscCode;
        private string bankBranch;

        public string BankAccountName
        {
            get
            {
                return bankAccountName;
            }

            set
            {
                bankAccountName = value;
            }
        }

        public UInt64 BankAccountNumber
        {
            get
            {
                return bankAccountNumber;
            }

            set
            {
                bankAccountNumber = value;
            }
        }

        public string IfscCode
        {
            get
            {
                return ifscCode;
            }

            set
            {
                ifscCode = value;
            }
        }

        public string BankBranch
        {
            get
            {
                return bankBranch;
            }

            set
            {
                bankBranch = value;
            }
        }
    }
}