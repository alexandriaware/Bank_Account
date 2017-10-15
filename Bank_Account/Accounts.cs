﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Accounts
    {
        //fields
        protected string acctType;
        protected int acctNum;
        protected float acctBalance;
        protected float input;

        //Properties
        public string AcctType { get; set; }
        public float AcctBalance { get; set; }
        public int AcctNum
        {
            get { return this.acctNum; }
        }

        //Constructors
        public Accounts()
        {

        }
        public Accounts(string acctType, float acctBalance, int acctNum)
        {
            this.acctType = acctType;
            this.acctBalance = acctBalance;
            this.acctNum = acctNum;
        }

        //methods
        public abstract void Withdraw();

        public abstract void Deposit();


    }
}
