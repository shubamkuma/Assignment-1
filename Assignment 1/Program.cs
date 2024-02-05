
using System;

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

    public void DisplayStats()
    {
        Console.WriteLine("Pet's Stats - Name: " + Name);
        Console.WriteLine("Hunger: " + Hunger);
        Console.WriteLine("Happiness: " + Happiness);
        Console.WriteLine("Health: " + Health);
    }

    public void CheckStatus()
    {
        if (Hunger <= 2)
        {
            Console.WriteLine("Warning: Pet's hunger is critically low!");
        }
        else if (Hunger >= 8)
        {
            Console.WriteLine("Warning: Pet's hunger is critically high!");
        }

        if (Happiness <= 2)
        {
            Console.WriteLine("Warning: Pet's happiness is critically low!");
        }
        else if (Happiness >= 8)
        {
            Console.WriteLine("Warning: Pet's happiness is critically high!");
        }

        if (Health <= 2)
        {
            Console.WriteLine("Warning: Pet's health is critically low!");
        }
        else if (Health >= 8)
        {
            Console.WriteLine("Warning: Pet's health is critically high!");
        }
    }
}

class Program
{
    static void Main()
    {
        Pet pet = new Pet("Fido");

        pet.DisplayStats();

        // Example of checking the pet's status
        pet.CheckStatus();
    }
}