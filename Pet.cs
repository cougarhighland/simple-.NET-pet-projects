using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Solution
{
    internal class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        public void Start()
        {

            readPetInfo();
            showPetInfo();
        }

        //this method gets a pet's information
        public void readPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Greeting from myPet class!");
            Console.WriteLine();
            Console.Write("What is the name of your pet? ");
            name = Console.ReadLine();
            Console.Write("what is " + name + "'s age? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Is your pet a female (y/n)? ");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'y' || answer == 'Y')
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }

        }

        //this method shows to the terminal the pet 's information
        public void showPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++");
            Console.WriteLine("Name: " + name + " Age: " + age);
            if (isFemale is true)
            {
                Console.WriteLine(name + " is a good girl!");
            }
            else
            {
                Console.WriteLine(name + " is a good boy!");
            }
            Console.WriteLine("++++++++++++++++++++++");

        }
    }
}
