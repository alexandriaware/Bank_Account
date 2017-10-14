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
        private string clientName;
        private string acctTypeCheck;
        private string acctTypeSave;
        private string clientAddress;

                       
        //Properties
        public string ClientName //just need to view
        {
            get { return this.clientName; }
        }
        public string AcctTypeCheck //view
        {
            get { return this.acctTypeCheck; }
        }
        public string AcctTypeSave //view
        {
            get { return this.acctTypeSave; }
        }        
        public string ClientAddress { get; set; } //view or edit


        //Constructors
        public Client()
        {
            //default
            this.clientName = "Harry Potter";
            this.clientAddress = "Number 4 Privet Drive, Little Whinging, Surrey";
            this.acctTypeCheck = "Checking Account #2308";
            this.acctTypeSave = "Savings Account #8775";
            

        }

        public Client(string clientName, string acctTypeCheck, string acctTypeSave, string clientAddress)
        {
            this.clientName = clientName;
            this.acctTypeCheck = acctTypeCheck;
            this.acctTypeSave = acctTypeSave;
            
            
            this.clientAddress = clientAddress;
            
        }

        //Methods
        public virtual string GetInfo()
        {
            return clientName + "\t" + clientAddress + "\n" + acctTypeSave + "\t" + acctTypeCheck;
        }
        



    }
}
