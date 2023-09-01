using Class_Library.Animal_models;

namespace Class_Library;

public class Pet_Shop
{
    public Cat[] Cats = new Cat[20];
    public Dog[] Dogs = new Dog[20];
    public Bird[] Birds = new Bird[20];
    public Fish[] Fish = new Fish[20];

    public Pet_Shop() { }
    
    public void add_animal(Animal new_animal)
    {
        if (new_animal is Cat)
        {
            Array.Resize(ref Cats, Cats.Length + 1);
            Cats[Cats.Length - 1] = (Cat)new_animal;
        }
        else if (new_animal is Dog)
        {
            Array.Resize(ref Dogs, Dogs.Length + 1);
            Dogs[Dogs.Length - 1] = (Dog)new_animal;
        }
        else if (new_animal is Bird)
        {
            Array.Resize(ref Birds, Birds.Length + 1);
            Birds[Birds.Length - 1] = (Bird)new_animal;
        }
        else if (new_animal is Fish)
        {
            Array.Resize(ref Fish, Fish.Length + 1);
            Fish[Fish.Length - 1] = (Fish)new_animal;
        }
    }

    public double CalculateTotalPrice()
    {
        double total = Cats.Sum(cat => cat?.Price ?? 0);
        total += Dogs.Sum(dog => dog?.Price ?? 0);
        total += Birds.Sum(bird => bird?.Price ?? 0);
        total += Fish.Sum(fish => fish?.Price ?? 0);

        return total;
    }

    public int CalculateTotalMealQuantity()
    {
        int totalQuantity = Cats.Sum(cat => cat?.Meal_Quantity ?? 0);
        totalQuantity += Dogs.Sum(dog => dog?.Meal_Quantity ?? 0);
        totalQuantity += Birds.Sum(bird => bird?.Meal_Quantity ?? 0);
        totalQuantity += Fish.Sum(fish => fish?.Meal_Quantity ?? 0);

        return totalQuantity;
    }
}