namespace Class_Library.Animal_models;

public enum Color
{
    Black,
    White,
    Gray,
    Yellow
}
public class Cat : Animal
{
    public Color FurColor { get; set; }

    // Override Sound

    public override void Sound()
    {
        Console.WriteLine("Miau Miau");
    }

    // Constructors

    public Cat() : base() { }
    public Cat(string nickname, Gender gender, byte age, float price, int energy, int meal_quantity, Color FurColor) : base(nickname, gender, age, price, energy, meal_quantity) { this.FurColor = FurColor; }
}