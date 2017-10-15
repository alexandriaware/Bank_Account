using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class SavingsAccount : Accounts
    {
        //field
        private float minimumBalance;
        
        //Property
        public float MinimumBalance { get; set; }

        //Constructors
        public SavingsAccount()
        {
            //default
            minimumBalance = 10.0f;
            acctType = "Savings Account";
            acctNum = 8775;
            acctBalance = 15000.0f;

        }

        //Method
        public override void Withdraw()
        {
            if (input >= minimumBalance)
            {
                acctBalance = acctBalance - input;
            }
            else
            {
                Console.WriteLine("Insufficient funds, Mr. Potter.");
            }
        }
        public override void Deposit()
        {
            acctBalance = acctBalance + input;
        }
    }
}
