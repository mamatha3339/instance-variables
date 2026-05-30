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
        public bankaccount(long accountnumber,double balance)
        {
            this.accountnumber = accountnumber;
            this.balance = balance;
        }


        public void display()
        {
            //accountnumber = accountnumber;
           // balance = balance;
            Console.WriteLine("accont number is:" + accountnumber);
            Console.WriteLine("balance is:" + balance);
            Console.WriteLine("accont name is:" + accountname);

        }
        public void deposit(double amount)
        {
            if (amount >= 0)
            {
                balance += amount;
                Console.WriteLine("balance after deposit is:" + balance);
            }
        }
        public void withdraw(double amount)
        {
            if (amount <=balance )
            {
                
                    balance -= amount;
               
            }
            Console.WriteLine("remaining balance is:" + balance); 
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bankaccount obj = new bankaccount(999888666,10000);
            obj.display();
            obj.deposit(5000);
            obj.withdraw(2000);


            
        }
    }
}
