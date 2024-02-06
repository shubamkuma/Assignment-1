
using System;
using System.Threading;

class Pet
{
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }
    public int Health { get; set; }

    public Pet(string name)
    {
        Name = name;
        Hunger = 5; // Initial value on a scale of 1 to 10
        Happiness = 5; // Initial value on a scale of 1 to 10
        Health = 5; // Initial value on a scale of 1 to 10
    }

    public void TimePassing()
    {
        // Simulate the passage of time
        for (int i = 0; i < 24; i++) // Simulate 24 hours
        {
            Thread.Sleep(1000); // Simulate an hour
            Hunger++; // Hunger increases over time
            Happiness--; // Happiness decreases slightly
        }
    }
}

class Program
{
    static void Main()
    {
        Pet pet = new Pet("Fido");

        pet.TimePassing(); // Simulate the passage of time

        Console.WriteLine("After 24 hours:");
        Console.WriteLine("Hunger: " + pet.Hunger);
        Console.WriteLine("Happiness: " + pet.Happiness);
    }
}