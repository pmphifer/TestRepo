using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace VacationBudgetPlanner
{
    class Program
    {

        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Hello!");
                Console.WriteLine("Welcome to the Vacation Budget Planner App");

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("What is your name? ");
                string name = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine();
                Console.Write($"Welcome {name}! Where would you like to travel? Choose (1) Mexico or (2) Jamaica! ");
                int destination = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();

                switch (destination)
                {
                    case 1:
                        Console.WriteLine("Great, Mexico sounds like an amazing trip!");
                        Console.WriteLine("***************");
                        Console.Write("How many days would you like to spend on your trip? ");
                        int days = Convert.ToInt16(Console.ReadLine());
                        double hours = days * 24;
                        double minutes = hours * 60;
                        Console.WriteLine($"You would like to be in Mexico for {days} days. That's {hours} hours and {minutes} minutes!");
                        Console.WriteLine();
                        Console.Write("How much spending money (in USD) would you like to bring? ");
                        double value = Convert.ToDouble(Console.ReadLine());
                        string budget = value.ToString("C", CultureInfo.CurrentCulture);
                        double cash = (value / days);
                        double daily = cash * 24.31;
                        string dollar = cash.ToString("C", CultureInfo.CurrentCulture);
                        string peso = daily.ToString("C", CultureInfo.CurrentCulture);
                        Console.WriteLine($"Okay, {name}, you are going to Mexico for {days} days with {budget} USD for spending money! That's {dollar} USD or {peso} pesos per day!.");
                        Console.WriteLine("***************");
                        Console.WriteLine("Enjoy your trip!");
                        break;

                    case 2:
                        Console.WriteLine("Great, Let's get you to Jamaica!");
                        Console.WriteLine("***************");
                        Console.Write("How many days would you like to spend on your trip? ");
                        days = Convert.ToInt16(Console.ReadLine());
                        hours = days * 24;
                        minutes = hours * 60;
                        Console.WriteLine($"You would like to be in Jamaica for {days} days. That's {hours} hours and {minutes} minutes!");
                        Console.WriteLine();
                        Console.Write("How much spending money (in USD) would you like to bring? ");
                        value = Convert.ToDouble(Console.ReadLine());
                        budget = value.ToString("C", CultureInfo.CurrentCulture);
                        cash = (value / days);
                        daily = cash * 146.04;
                        dollar = cash.ToString("C", CultureInfo.CurrentCulture);
                        string jamaican = daily.ToString("C", CultureInfo.CurrentCulture);
                        Console.WriteLine($"Okay, {name}, you are going to Jamaica for {days} days with {budget} USD for spending money! That's {dollar} USD or {jamaican} Jamaican Dollars per day!.");
                        Console.WriteLine("***************");
                        Console.WriteLine("Enjoy your trip!");
                        break;

                    default:
                        Console.WriteLine("That choice is not valid, please choose Mexico or Jamaica.");
                        break;

                }

                Console.WriteLine();
                Console.Write("Would you like me to calculate your budget for another trip? (Y)es or (N)no?: ");
                string answer = (Console.ReadLine().ToLower());

                if (answer == "y")
                {
                    keepGoing = true;
                }

                else if (answer != "y")
                {
                    keepGoing = false;
                    Console.WriteLine("Have a great day.");
                }


            }

            Console.WriteLine("done");


            Console.ReadLine();

        }
    }
}
