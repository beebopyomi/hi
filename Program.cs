using System;

namespace Hi
{
    class Jayden
    {
        static void Main()
        {
            Console.WriteLine("is jayden marcus dood? Y/N");
            string choice = Console.ReadLine().ToLower();

            if (choice == "n")
            {
                Console.WriteLine("Vermoord Jayden marcus...");
            }
            else if (choice == "y")
            {
                Console.WriteLine("gefeliciteerd ik hou van je");
            }
        }
    }
}
