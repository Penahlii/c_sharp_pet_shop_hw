namespace Class_Library.Animal_models;

public class Bird : Animal
{
    // Properties

    public float WingSpan { get; set; }

    // Override

    public override void Sound()
    {
        Console.WriteLine("Chick Chick");
    }

    // Constructors

    public Bird() : base() { }
    public Bird(string nickname, Gender gender, byte age, float price, int energy, int meal_quantity, float WingSpan) : base(nickname,gender,age,price,energy,meal_quantity) { this.WingSpan = WingSpan; }
}