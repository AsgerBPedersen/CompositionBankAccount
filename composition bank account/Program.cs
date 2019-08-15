using ComposistionTest;
using System;
using System.Collections.Generic;

namespace composition_bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> acc = null;
            Customer cus = new Customer(acc);
            Console.WriteLine(cus.Accounts);
            Console.ReadLine();
        }
    }
}
