using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    internal class BankAccount
    {
        public string owner;
        public double balance;
        public double plus = 500;
        public double minus = 500;

        public void Deposit(string owner, double balance, double plus)
        {
                Console.WriteLine($"{owner}, баланс: {balance + plus}");
        }
        public void WithDraw(string owner, double balance, double minus)
        {
            if (balance - minus > 0)
            {
                Console.WriteLine($"{owner}, баланс: {balance - minus}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }
    }
}
