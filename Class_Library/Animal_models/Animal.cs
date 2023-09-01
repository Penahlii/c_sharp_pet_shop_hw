namespace Class_Library.Animal_models;

public enum Gender
{
    Female,
    Male
}


public abstract class Animal
{
    Guid ID;
    private Gender gender;

    // Properties

    private string nickname;
    public string Nickname
    {
        set
        {
            if (value != null)
                this.nickname = value;
            else
                throw new Exception("Nickname can not be Null");
        }
        get => this.nickname;
    }

    private byte age;
    public byte Age
    {
        set
        {
            if (value > 0)
                this.age = value;
            else
                throw new Exception("Age can not be less than zero");
        }
        get => this.age;
    }

    private float price;
    public float Price
    {
        set
        {
            if (value > 0)
                this.price = value;
            else
                throw new Exception("Price can not be less than zero");
        }
        get => this.age;
    }

    private int energy;
    public int Energy { set; get; }

    private int meal_quantity;
    public int Meal_Quantity { set; get; }

    // Constructors

    public Animal() { this.ID = Guid.NewGuid(); }
    public Animal(string nickname, Gender gender, byte age, float price, int energy, int meal_quantity) : this()
    {
        this.Nickname = nickname;
        this.gender = gender;
        this.Age = age;
        this.Price = price;
        this.Energy = energy;
        this.Meal_Quantity = meal_quantity;
    }

    // Methods

   public void Eat()
   {
        this.energy += this.meal_quantity;
        Console.WriteLine($"{this.nickname} has eaten");
        this.price += 10;
   }

    public void Sleep()
    {
        this.energy += 10;
        Console.WriteLine($"{this.nickname} has slept");
    }

    public void Play()
    {
        if (this.energy >= 15)
        {
            this.energy -= 15;
            Console.WriteLine($"{this.nickname} has played");
        }
        else
            Console.WriteLine($"{this.nickname} is too tired to Play");
    }

    public abstract void Sound();
}