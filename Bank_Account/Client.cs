using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Client
    {
        //fields
        //an account number for both saving and checking account
        private int savAcctNum;
        private int checkAcctNum;
        //a balance variable for each account
        private float savAcctBal;
        private float checkAcctBal;
        private string clientName;


        //Properties
        public string ClientName //just need to view
        {
            get { return this.clientName; }
        }

        public float CheckAcctBal { get; set; } // view and change checking acct balance
        public float SavAcctBal { get; set; } // view and change checking acct balance

        public int CheckAcctNum
        {
            get { return this.CheckAcctNum; } // no reason for the user to need to change account's number
        }

        public int SavAcctNum
        {
            get { return this.SavAcctNum; } // same as check acct num
        }


        //Constructors
        public Client()
        {
            //default
        }

        public Client(string clientName, int checkAcctNum, int savAcctNum, float checkAcctBal, float savAcctBal)
        {
            this.clientName = clientName;
            this.checkAcctNum = checkAcctNum;
            this.savAcctNum = savAcctNum;
            this.checkAcctBal = checkAcctBal;
            this.savAcctBal = savAcctBal;
        }
        



    }
}
