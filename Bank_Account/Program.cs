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

            Client potter = new Client();


            Console.WriteLine("Please make your selection from the following options:");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");

            //if 1 - ViewClientInformation Method
            //if 2 view account balance method
            //if 3 deposit funds method
            //if 4 //withdraw funds method
            //if 5 exit program
            //if 6, return to main menu (put this everywhere except main menu)


            /*
                View account balance method
                    - This method should allow you to view the balance for either the
                     savings account or the checking account.

                    - It should also be able to be reused anywhere to show account balances without
                    user input

            */

            string selection = Console.ReadLine().Trim(); //store input
            string account = "";

            do//keep asking until they put in correct numbers
            {
                if (selection == "1")
                {
                    Console.WriteLine(potter.GetInfo());
                }
                else if (selection == "2")
                {
                    ////Could this be a method?
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


        }

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
