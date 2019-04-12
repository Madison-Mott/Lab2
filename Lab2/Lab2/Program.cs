using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine($"\n");
                Console.WriteLine($"Please enter the length:");
                decimal roomLength = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"Please enter the width:");
                decimal roomWidth = decimal.Parse(Console.ReadLine());

                decimal area = roomLength * roomWidth;
                decimal perimeter = 2 * (roomWidth + roomLength);

                Console.WriteLine($"The Area of the room is: {area}");
                Console.WriteLine($"The Perimeter of the room is: {perimeter}");

                Console.WriteLine($"Would you like to know the Volume of the room? (yes/no)");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine($"Please enter the height of the room:");
                    decimal roomHeight = decimal.Parse(Console.ReadLine());
                    decimal volume = roomLength * roomWidth * roomHeight;
                    Console.WriteLine($"The Volume of the room is: {volume}");
                }
                else if (Console.ReadLine().ToLower() != "yes")
                {
                    break;
                }

                Console.WriteLine($"Would you like to continue? (yes/no)");
                    if (Console.ReadLine().ToLower() != "yes")
                {
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
