using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a pet object
            Pet pet = new Pet();
            //call a method from the object to run
            pet.Start();

            Console.WriteLine("Please enter to start a next part");
            Console.ReadLine();

            TicketSeller ticketSeller = new TicketSeller();
            ticketSeller.Start();

            Console.WriteLine("Please enter to start a next part");
            Console.ReadLine();

            Album album = new Album();
            album.Start();

            Console.WriteLine("Please enter to start a next part");
            Console.ReadLine();

            CookieCalories cookies = new CookieCalories();
            cookies.Start();

            Console.WriteLine("Please press e to end the program");
            char response = char.Parse(Console.ReadLine());
            if ((response == 'e') || (response == 'E'))
            {
                Environment.Exit(-1);
            }
        }
    }
}
