using System;

namespace W5P3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = new List<string>();

            int counter = 1; // Using this integer for every line

            Console.WriteLine("Beş tane kahve ismi girebilir misiniz: ");

            while (true)
            {
                string userInput = Console.ReadLine();
                coffeeList.Add(userInput);

                if (coffeeList.Count >= 5) // Arranging the limit to five
                {
                    break;
                }
            }

            foreach (string coffee in coffeeList)
            {
                Console.WriteLine($"Kahve {counter++}: {coffee}");  // Fixing the displaying message to example : "Kahve 1: user input".
            }
        }
    }
}