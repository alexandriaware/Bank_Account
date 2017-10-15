using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate
            Client potter = new Client();
            CheckingAccount check = new CheckingAccount();


            Console.WriteLine("Please make your selection from the following options:");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");

            string selection = Console.ReadLine().Trim(); //store input
            string account = "";

            do//keep asking until they put in correct numbers
            {
                if (selection == "1") //Client information
                {
                    Console.WriteLine(potter.GetInfo());
                }
                else if (selection == "2") //Account balance
                {
                    ////Could this be a method?
                    Console.WriteLine("Please make a selection:");
                    Console.WriteLine("1. Checking Account");
                    Console.WriteLine("2. Savings Account");
                    account = Console.ReadLine().Trim();
                    if (account == "1")
                    {
                        Console.WriteLine(check.acctBalance);
                        //insert checking account balance
                    }
                    else if (account == "2")
                    {
                        //insert savings account balance
                    }
                    else
                    {
                        Console.WriteLine("Please make a valid selection: enter 1 or 2");
                        Console.WriteLine("1. Checking Account");
                        Console.WriteLine("2. Savings Account");
                        account = Console.ReadLine().Trim();

                    }
                }
                else if (selection == "3")
                {
                    ////Yeah...definitely could be a method
                    Console.WriteLine("Please make a selection:");
                    Console.WriteLine("1. Checking Account");
                    Console.WriteLine("2. Savings Account");
                    account = Console.ReadLine().Trim();
                    if (account == "1")
                    {
                        //insert checking account method
                    }
                    else if (account == "2")
                    {
                        //insert savings account method
                    }
                    else
                    {
                        Console.WriteLine("Please make a valid selection: enter 1 or 2");
                        Console.WriteLine("1. Checking Account");
                        Console.WriteLine("2. Savings Account");
                        account = Console.ReadLine().Trim();

                    }
                }
                else if (selection == "4")
                {
                    Console.WriteLine("Please make a selection:");
                    Console.WriteLine("1. Checking Account");
                    Console.WriteLine("2. Savings Account");
                    account = Console.ReadLine().Trim();
                    if (account == "1")
                    {
                        //insert checking account method
                    }
                    else if (account == "2")
                    {
                        //insert savings account method
                    }
                    else
                    {
                        Console.WriteLine("Please make a valid selection: enter 1 or 2");
                        Console.WriteLine("1. Checking Account");
                        Console.WriteLine("2. Savings Account");
                        account = Console.ReadLine().Trim();

                    }
                }

            } while (account != "1" || account != "2");
            var testAcocunt = new SavingsAccount();

        }


        //Console.WriteLine("What would you like to do?");
        // Console.WriteLine("1. Deposit");
        // Console.WriteLine("2. Withdraw");
        //       if (account == "1")
        //        input = Console.ReadLine().Trim();


        //public void Validate()
        //{
        //    account = Console.ReadLine().Trim();
        //    if (account == "1")
        //    {
        //        //insert checking account method
        //    }
        //    else if (account == "2")
        //    {
        //        //insert savings account method
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please make a valid selection: enter 1 or 2");
        //        Console.WriteLine("1. Checking Account");
        //        Console.WriteLine("2. Savings Account");
        //        //account = Console.ReadLine().Trim();
        //    }
        //}
    }
}
