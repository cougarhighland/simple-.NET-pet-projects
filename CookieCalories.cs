using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Solution
{
    internal class CookieCalories
    {
        private string name;
        private int numOfCookies;
        private double calories = 501.9;
        private double totalCalories;
        private string currentTime = DateTime.Now.ToString("ddd, dd MMM yyy HH':'mm':'ss 'GMT'");
        private const int maxCalories = 2500;
        private bool isTooMany;

        public void Start()
        {
            getCookiesInfo();
            printInfo();
        }

        public void getCookiesInfo()
        {
            Console.WriteLine();
            Console.WriteLine("This program is to calculate cookies calories");
            Console.WriteLine();
            Console.WriteLine("Today is " + currentTime);
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How many cookies do " + name + " want to have?");
            numOfCookies = int.Parse(Console.ReadLine());
            totalCalories = numOfCookies * calories;
            if (totalCalories > maxCalories)
            {
                isTooMany = true;
            }
            else
            {
                isTooMany = false;
            }
        }

        public void printInfo()
        {
            Console.WriteLine("++++++++++");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Number of cookies obtained:" + numOfCookies);
            Console.WriteLine("Calories: " + totalCalories);
            if (isTooMany is true)
            {
                Console.WriteLine("You eat too many cookies today " + currentTime);
                Console.WriteLine("It is not good for your health");
            }
            else
            {
                Console.WriteLine("You are living healthy lifestyle today " + currentTime);
            }
            Console.WriteLine("++++++++++");
            Console.WriteLine();
            Console.WriteLine("Enjoy your cookies");
        }
    }
}
