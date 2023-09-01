namespace Class_Library.Animal_models;

public class Fish : Animal
{
    public bool isSaltWater { get; set; }

    // Override Sound

    public override void Sound()
    {
        Console.WriteLine("Bloop Bloop");
    }

    // Constructors

    public Fish() : base() { }
    public Fish(string nickname, Gender gender, byte age, float price, int energy, int meal_quantity, bool isSaltWater) : base(nickname, gender, age, price, energy, meal_quantity) { this.isSaltWater = isSaltWater; }

    public override string ToString()
    {
        string text = this.Nickname;
        return text;
    }
}