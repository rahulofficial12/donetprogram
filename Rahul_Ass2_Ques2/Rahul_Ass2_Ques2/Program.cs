﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank(3296, "Rahul Tomar", 10000);
            b1.displayData();
        }
    }
    class Bank
    {
        public int AccountNumber;
        public string name;
        public double balance;
        public Bank(int AccountNumber, string name, double balance)
        {
            this.AccountNumber = AccountNumber;
            this.name = name;
            this.balance = balance;
        }
        public void deposit(double balance)
        {
            balance += balance;
        }
        public void withdrawl(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficinent Balance");
            }
            else
            {
                balance = balance - amount;
            }
        }
        public void displayData()
        {
            Console.WriteLine("AccountNumber:" + this.AccountNumber);
            Console.WriteLine("Name :" + this.name);
            Console.WriteLine("Balance :" + this.balance);
            Console.ReadKey();
        }
    }
}