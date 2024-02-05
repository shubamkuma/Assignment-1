using System;

namespace VirtualPet
{
    class Program
    {
        public static string Cat { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pet!");

            // Pet Creation
            Console.WriteLine("Choose a pet type (cat, dog, rabbit): ");
            string petType = Console.ReadLine();
            Console.WriteLine("Enter a name for your pet: ");
            string Chini = Console.ReadLine();

            Pet myPet = new Pet(Cat, Chini);

            // Display pet information
            Console.WriteLine($"Congratulations! You have a new {myPet.Cat} named {myPet.Chini}.");

            // Pet Care Loop
            bool exit = false;
        }
    }
}
