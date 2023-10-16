using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Solution
{
    internal class TicketSeller
    {
        private string name;
        private double price = 100;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;


        public void Start()
        {
            getCustomerInfo();
            showReceipt();

        }
        public void getCustomerInfo()
        {
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("Children get always a 75% discount!");
            Console.WriteLine("Your name please:");
            name = Console.ReadLine();
            Console.WriteLine("Number of aldults:");
            numOfAdults = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of children:");
            numOfChildren = int.Parse(Console.ReadLine());
        }

        public double calculatePayment()
        {
            //children get 75% discount, so children only pay 25 for a ticket
            amountToPay = (numOfAdults * price) + (numOfChildren * (price * 0.25));
            return amountToPay;
        }

        public void showReceipt()
        {
            Console.WriteLine(" +++ Your receipt +++");
            Console.WriteLine(" +++ Amount to pay = " + $"{calculatePayment():0.00}");
            Console.WriteLine(" +++ Thank you " + name + " and please come back! +++");
        }
    }
}
