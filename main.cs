// Aiden McLeod
// ICS2O-Assignment4-CSharp
// April 22 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        string choice;
        int sizeprice;
        double toppingprice;

        void enterSize()
        {
            Console.WriteLine("Enter size of pizza:");
            Console.WriteLine("1 - Large | $6.00");
            Console.WriteLine("2 - Extra Large | $10.00");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                sizeprice = 6;
            }
            else if (choice == "2")
            {
                sizeprice = 10;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                enterSize();
            }
        };

        void enterToppings()
        {
            Console.WriteLine("Enter amount of toppings:");
            Console.WriteLine("1 - One Topping | $1.00");
            Console.WriteLine("2 - Two Toppings | $1.75");
            Console.WriteLine("3 - Three Toppings | $2.50");
            Console.WriteLine("4 - Four Toppings | $3.35");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                toppingprice = 1;
            }
            else if (choice == "2")
            {
                toppingprice = 1.75;
            }
            else if (choice == "3")
            {
                toppingprice = 2.5;
            }
            else if (choice == "4")
            {
                toppingprice = 3.35;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                enterToppings();
            }
        };

        enterSize();
        enterToppings();
        Console.WriteLine("\nThe cost of this pizza is $" + ((sizeprice + toppingprice) + ((sizeprice + toppingprice) * 0.13)).ToString("0.00"));
        Console.WriteLine("\nFinished.");
    }
}