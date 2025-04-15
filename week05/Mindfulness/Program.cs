using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity  breathing= new BreathingActivity();
                breathing.Run();
            }

            else if (choice == "2")
            {
                ReflectionActivity reflecting = new ReflectionActivity();
                reflecting.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using this program. See ya!");
                keepRunning = false;
            }

            else
            {
                Console.WriteLine("Invalid choice, please select a valid response");
                Thread.Sleep(2000);
            }


        }
    }
}