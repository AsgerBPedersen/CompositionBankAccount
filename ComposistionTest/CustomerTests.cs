﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using composition_bank_account;
using System.Collections.Generic;

namespace ComposistionTest
{
    [TestClass]
    public class CustomerTests
    {
        [DataTestMethod]
        [DataRow(-999999998, -1)]
        [DataRow(-123123, -21312)]
        [DataRow(-1, -1)]
        public void GetDebts(int value1, int value2)
        {
            Customer customer = new Customer(
                new List<Account>() {
                    new Account(value1),
                    new Account(value2)
                }
            );
            if(customer.GetDebts() == value1 + value2)
            {
                Assert.IsTrue(true);
            }
            else if (customer.GetDebts() <= 0 && customer.GetDebts() > -1000000000)
            {
                Assert.IsTrue(true);
            } else
            {
                Assert.IsTrue(false);
            }
           
        }

        [DataTestMethod]
        [DataRow(999999999)]
        [DataRow(123123)]
        [DataRow(1)]
        public void GetAssets(int value)
        {
            Customer customer = new Customer(
                new List<Account>() {
                    new Account(value)
                }
            );
            if (customer.GetAssets() >= 0 && customer.GetAssets() < 1000000000)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }

        [DataTestMethod]
        [DataRow(2132, -545493)]
        [DataRow(123123, -12000121)]
        [DataRow(1231245, -21123)]
        public void GetTotalBalance(int asset, int debt)
        {
            Customer customer = new Customer(
               new List<Account>() {
                    new Account(asset),
                    new Account(debt)
               }
           );
            if ((customer.GetAssets() + customer.GetDebts()) != customer.GetTotalBalance())
            {
                Assert.IsTrue(false);
            } else
            {
                Assert.IsTrue(true);
            }

        }

        [DataTestMethod]
        [DataRow(1250001, -2500001)]
        [DataRow(21312585, -999999999)]
        [DataRow(99999999, -12328803)]
        public void RatingOne(int asset, int debt)
        {
            Customer customer = new Customer(
               new List<Account>() {
                    new Account(asset),
                    new Account(debt)
               }
           );
            if (customer.Rating == 1)
            {
                Assert.IsTrue(true);
            } else
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(50000, -2500001)]
        [DataRow(500000, -999999999)]
        [DataRow(1250000, -11238803)]
        public void RatingTwo(int asset, int debt)
        {
            Customer customer = new Customer(
               new List<Account>() {
                    new Account(asset),
                    new Account(debt)
               }
           );
            if (customer.Rating == 2)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }

        [DataTestMethod]
        [DataRow(50000, -250000)]
        [DataRow(500000, -1000000)]
        [DataRow(1250000, -2500000)]
        public void RatingThree(int asset, int debt)
        {
            Customer customer = new Customer(
               new List<Account>() {
                    new Account(asset),
                    new Account(debt)
               }
           );
            if (customer.Rating == 3)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(49999, -1)]
        [DataRow(4321, -33)]
        [DataRow(423, -2)]
        public void RatingFour(int asset, int debt)
        {
            Customer customer = new Customer(
               new List<Account>() {
                    new Account(asset),
                    new Account(debt)
               }
           );
            if (customer.Rating == 4)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(1, -2)]
        [DataRow(49999, -249999)]
        [DataRow(1233, -1234)]
        public void RatingFive(int asset, int debt)
        {
            Customer customer = new Customer(
               new List<Account>() {
                    new Account(asset),
                    new Account(debt)
               }
           );
            if (customer.Rating == 5)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}
