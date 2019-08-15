using ComposistionTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace composition_bank_account
{
    public class Customer
    {
        private int id;
        private List<Account> accounts;

        /// <summary>
        /// sets or gets accounts
        /// </summary>
        public List<Account> Accounts
        {
            get { return accounts; }
            set {
                    if (value == null)
                    {
                        throw new NullReferenceException();
                    }
                    else {
                        accounts = value;
                    }
            }
        }

        /// <summary>
        /// sets or gets id
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        /// <summary>
        /// returns the rating which is dependent on the customers total debts and assets
        /// </summary>
        public int Rating
        {
           
            get {
                decimal debts = GetDebts();
                decimal assets = GetAssets();
                if (debts < -2500000) {
                    if(assets > 1250000)
                    {
                        return 1;
                    } else if(assets >= 50000)
                    {
                        return 2;
                    } else
                    {
                        return 0;
                    }
                } else if(debts <= -250000 && assets >= 50000 && assets <= 1250000) {
                    return 3;
                } else if(debts < 0 && debts > -250000 && assets > 0 && assets < 50000)
                {
                    if(assets + debts >= 0)
                    {
                        return 4;
                    } else
                    {
                        return 5;
                    }
                } else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// initializes customer with id
        /// </summary>
        /// <param name="accounts"></param>
        /// <param name="id"></param>
        public Customer(List<Account> accounts, int id)
        {
            Accounts = accounts;
            Id = id;
        }
        /// <summary>
        /// initializes customer without id
        /// </summary>
        /// <param name="accounts"></param>
        public Customer(List<Account> accounts)
        {
            Accounts = accounts;
            id = 0;
        }
        /// <summary>
        /// returns the total debts of the customers accounts
        /// </summary>
        /// <returns></returns>
        public decimal GetDebts()
        {
            if(accounts.Count == 0)
            {
                return 0;
            } else
            {
                return Accounts.Where(ac => ac.Balance <= 0).Sum(ac => ac.Balance);
            }
        }
        /// <summary>
        /// returns the total assests of the customers accounts
        /// </summary>
        /// <returns></returns>
        public decimal GetAssets()
        {
            if (accounts.Count == 0)
            {
                return 0;
            }
            else
            {
                return Accounts.Where(ac => ac.Balance >= 0).Sum(ac => ac.Balance);
            }
        }
        /// <summary>
        /// returns the total balance of all the customers accounts
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalBalance()
        {
            if (accounts.Count == 0)
            {
                return 0;
            }
            else
            {
                return GetAssets() + GetDebts();
            }
        }


    }
}
