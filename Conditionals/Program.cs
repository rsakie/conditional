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
            ////intro ex. thank you for dining with us..
            //Console.WriteLine("Thank you for Dining with us today");

            //Console.WriteLine("How many people are dining?");
            //int peopleDine = int.Parse(Console.ReadLine());

            //Console.WriteLine("How much did each person pay each?");
            //int payEach = int.Parse(Console.ReadLine());

            //Console.WriteLine("Your total bill is.");

            //double totalBill = peopleDine * payEach;
            //Console.WriteLine("$" + totalBill);


            ////total is above 50 add 10%
            ////below 50 add 5%
            //int total = 50;
            //if (total >= 50)
            //{
            //    Console.WriteLine("You received a 10% discount!");
            //}

            //    else
            //{
            //    Console.WriteLine("You Receive a 5% discount!");
            //    //add discounts onto sub total of bill
            //}
            //{
            //    double discount = totalBill * .10d;

            //    Console.WriteLine( "$" + discount);

            //    double grandTotal = totalBill - discount;
            //    Console.WriteLine("Your Grand total with Discount is $" + grandTotal);

            //}
            //{
            //    Console.WriteLine("Demographic Report based on age");

            //    int age = int.Parse(Console.ReadLine());
            //    if(age 0>= 


            //string loyaltyLevel = "red";
            //switch (loyaltyLevel)
            //{
            //    case "yellow":
            //        Console.WriteLine("discount : 40%");
            //        break;
            //    case "red":
            //        Console.WriteLine("discount: 90%");
            //        break;
            //    default:
            //        Console.WriteLine("error");
            //        break;


            //Console.WriteLine("Demographic report based on age");
            //Console.WriteLine("Your age will determine what category you belong in");
            //Console.WriteLine("What is your age?");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 2)
            //{
            //    Console.WriteLine("Print: Still in moma's arms!");
            //}
            //else if (age >= 3 && age <= 4)
            //{
            //    Console.WriteLine("Print: preschool maniac");
            //}
            //else if (age >= 5 && age <= 11)
            //{
            //    Console.WriteLine("Print: elementary school");
            //}

            //else if (age >= 12 && age <= 14)
            //{
            //    Console.WriteLine("Print: Middle School");
            //}

            //else if (age >= 15 && age <= 18)
            //{
            //    Console.WriteLine("Print: High School");
            //}
            //else if (age >= 19 && age <= 22)
            //{
            //    Console.WriteLine("Print: College");
            //}
            //else if (age >= 23 && age <= 65)
            //{
            //    Console.WriteLine("Print: Workin' for the man! :(");
            //}
            //else if (age >= 66 && age <= 100)
            //{
            //    Console.WriteLine("Print: The Golden Years!");
            //}
            //else if (age <= 0 && age > 100)
            //{
            //    Console.WriteLine("print: This program is for humans.");
            //}

            //{

            //string loyaltyLevel = "red";
            //switch (loyaltyLevel)
            //{
            //    case "yellow":
            //        Console.WriteLine("Discount: 40%");
            //        break;


            //    case "red":
            //        Console.WriteLine("Discount: 90%");
            //        break;
            //    default:
            //        Console.WriteLine("Error!");
            //    //        break;
            //}




            //Console.WriteLine("Spell out your number?");

            //string number = Console.ReadLine();
            //switch (number)
            //{
            //    case "One":
            //        Console.WriteLine("1");
            //        break;

            //    case "Two":
            //        Console.WriteLine("2");
            //        break;
            //    case "Three":
            //        Console.WriteLine("3");
            //        break;

            //    case "Four":
            //        Console.WriteLine("4");
            //        break;

            //    case "Five":
            //        Console.WriteLine("5");
            //        break;

            //    case "Six":
            //        Console.WriteLine("6");
            //        break;
            //    case "Seven":
            //        Console.WriteLine("7");
            //        break;

            //    case "Eight":
            //        Console.WriteLine("8");
            //        break;

            //    case "Nine":
            //        Console.WriteLine("9");
            //        break;

            //    case "Ten":
            //        Console.WriteLine("10");
            //        break;

            //    default:
            //        Console.WriteLine("You're an eff'n moron!?");
            //        break;
            //}

            //ask user for 2 integers
            //are the 2 integers equal to each other
            //inform user if equal,  else not equal
            //input 16, second 18
            //Output: The numbers 16 and 18 are not equal to each other


            //Console.WriteLine("Please type in two integers:");
            //Console.WriteLine("What is you first number?");
            //string A = (Console.ReadLine());


            //Console.WriteLine("What is your second number?");

            //string B = (Console.ReadLine());

            //if (A!= B)
            //    Console.WriteLine("Your Two Numbers are unequal.");

            //else if (A == B)
            //{
            //    Console.WriteLine("Your two numbers are equal.");
            //}


            //Console.WriteLine(" Please enter a number?");
            //int number = int.Parse(Console.ReadLine());

            { // ask player for first number
                Console.WriteLine("Please enter 2 numbers between 1 and 9");
                Console.WriteLine("Enter you first number.");
                int firstnum = int.Parse(Console.ReadLine());

                // ask player for second number

                Console.WriteLine("Please enter your second number.");
                int secondnum = int.Parse(Console.ReadLine());
                
                    if (firstnum < 1 || firstnum > 9 || secondnum < 1 || secondnum > 9) 
                {
                    Console.WriteLine("Start over you suck!!");
                }

                Console.WriteLine("Now please enter a third number.");
                int thirdnum = int.Parse(Console.ReadLine());

                // assign one num to fizz and one to buzz

                int fizz = thirdnum % firstnum;
                int buzz = thirdnum % secondnum;

                // test numbers for multiple of each other(else if)
                if (fizz == 0 && buzz == 0)
                {
                    Console.WriteLine("fizzbuzz!!!");
                }
                else if (fizz == 0)
                {
                    Console.WriteLine("fizz!!!");
                }
                else if (buzz == 0)
                {
                    Console.WriteLine("buzz!!!");
                }
                else 
                {
                    Console.WriteLine("start over " + thirdnum);
                }


            }
            }
        }
    }

   


           

   

        
        



