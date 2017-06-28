using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro ex. thank you for dining with us..
            Console.WriteLine("Thank you for Dining with us today");

            Console.WriteLine("How many people are dining?");
            int peopleDine = int.Parse(Console.ReadLine());

            Console.WriteLine("How much did each person pay each?");
            int payEach = int.Parse(Console.ReadLine());

            Console.WriteLine("Your total bill is.");

            double totalBill = peopleDine * payEach;
            Console.WriteLine("$" + totalBill);

          
            //total is above 50 add 10%
            //below 50 add 5%
            int total = 50;
            if (total >= 50)
            {
                Console.WriteLine("You received a 10% discount!");
            }

                else
            {
                Console.WriteLine("You Receive a 5% discount!");
                //add discounts onto sub total of bill
            }
            {
                double discount = totalBill * .10d;
               
                Console.WriteLine( "$" + discount);
                
                double grandTotal = totalBill - discount;
                Console.WriteLine("Your Grand total with Discount is $" + grandTotal);
                
              

              
            }

            


        }
    }
}
