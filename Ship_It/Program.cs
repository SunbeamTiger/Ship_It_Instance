using System;

namespace Ship_It
{
    internal class Program
    {
        private static bool isRunning = true;
        public static Shipper shipper = new Shipper();
        static void Main(string[] args)
        {
            while (isRunning)
            { runMenu(); }
        }
        private static bool runMenu()
        {
            Console.Clear();
            ConsoleKeyInfo choice;
            Console.WriteLine("Choose from the following options:\n");
            Console.WriteLine("__________________________________\n");
            Console.WriteLine("1. Add a Bicycle to the shipment ");
            Console.WriteLine("2. Add a Baseball Glove to the Shipment");
            Console.WriteLine("3. Add a Lawn Mower to the shipment ");
            Console.WriteLine("4. Add Crackers to the shipment ");
            Console.WriteLine("5. List Shipment Items");
            Console.WriteLine("6. Compute Shipping Charges");
            Console.WriteLine("7. Exit Program");
            Console.WriteLine("__________________________________");
            choice = Console.ReadKey();
            char charchoice = choice.KeyChar;
       
            switch (charchoice)
            {
                // add items to list
            case '1':
                addToList(new Bicycles());
                return true;
            case '2':
                addToList(new BaseballGlove());
                return true;
            case '3':
                addToList(new LawnMower());
                return true;
            case '4':
                addToList(new Crackers());
                return true;
            case '5':
                Console.Clear();
                Console.WriteLine(shipper.ShippingManifest());
                Console.WriteLine("Press any key to return to the menu");
                Console.ReadKey();
                return true;
            case '6':
                Console.Clear();
                Console.WriteLine("Total shipping costs for this order are $" + shipper.CalculateTotal());
                Console.WriteLine("Press any key to return to the menu");
                Console.ReadKey();
                return true;
            case '7':
                Console.Clear();
                Console.WriteLine("Press any key to close Program...");
                Console.ReadKey();
                isRunning = false;
                return isRunning;
            default:
                Console.Clear();
                Console.WriteLine("Please enter an apropriate response. Press any key to retry...");
                Console.ReadKey();
                return true;
            }
        }      
        private static void addToList(IShippable item)
        {
            Console.Clear();
            Console.WriteLine("1 " + item.Product + " has been added");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
            shipper.Add(item);
            
        }
    }
}
