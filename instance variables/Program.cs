using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instance_variables
{
    class bankaccount
    {
        long accountnumber;
        double balance;
        static string accountname = "Axix bank";


        public void display(int accountnumber,double balance)
        {
            accountnumber = accountnumber;
            balance = balance;
            Console.WriteLine("accont number is:" + accountnumber);
            Console.WriteLine("balance is:" + balance);
            Console.WriteLine("accont name is:" + accountname);

        }
        public void deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        public void withdraw(double amount)
        {
            if (amount <=balance )
            {
                {
                    balance -= amount;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bankaccount obj = new bankaccount();
            obj.display(999888666,10000);
            obj.deposit(5000);
            obj.withdraw(2000);


            
        }
    }
}
