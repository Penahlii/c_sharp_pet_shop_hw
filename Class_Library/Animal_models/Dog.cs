using System.Diagnostics;
using System.Reflection;

namespace Class_Library.Animal_models;

public class Dog : Animal
{
    public bool IsFriendly { get; set; }

    // Override Sound

    public override void Sound()
    {
        Console.WriteLine("Hav Hav");
    }

    // Constructors

    public Dog() : base() { }
    public Dog(string nickname, Gender gender, byte age, float price, int energy, int meal_quantity, bool IsFriendly) : base(nickname, gender, age, price, energy, meal_quantity) { this.IsFriendly = IsFriendly; }
}