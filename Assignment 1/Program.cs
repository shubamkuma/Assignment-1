
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
        Hunger = 50;
        Happiness = 50;
        Health = 50;
    }

    public void Feed()
    {
        Hunger -= 20;
        if (Hunger < 0) Hunger = 0;
        Health += 10;
        Console.WriteLine("You fed " + Name + ". Hunger decreased, and health increased.");
    }

    public void Play()
    {
        Happiness += 20;
        if (Happiness > 100) Happiness = 100;
        Hunger += 10;
        if (Hunger > 100) Hunger = 100;
        Console.WriteLine("You played with " + Name + ". Happiness increased, but hunger also increased.");
    }

    public void Rest()
    {
        Health += 20;
        if (Health > 100) Health = 100;
        Happiness -= 10;
        if (Happiness < 0) Happiness = 0;
        Console.WriteLine("You let " + Name + " rest. Health improved, but happiness decreased slightly.");
    }
}

class Program
{
    static void Main()
    {
        Pet pet = new Pet("Fido");
        Console.WriteLine("Welcome to the virtual pet simulator! Your pet's name is " + pet.Name);

        // Example of caring for the pet
        pet.Feed();
        pet.Play();
        pet.Rest();
    }
}