using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class CheckingAccount : Accounts
    {
        //I DON'T NEED NO FIELDS OR PROPERTIES cuz they are SHARED
        
        //Constructors
        public CheckingAccount()
        {
            acctBalance = 7887.5f;
            acctNum = 2308;
            acctType = "Checking Account";
            
        }

        //Method
        public override string Withdraw()
        {
            throw new NotImplementedException();
        }

    }
}
