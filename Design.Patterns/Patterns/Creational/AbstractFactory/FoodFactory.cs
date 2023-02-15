using Design.Patterns.Entity;
using Design.Patterns.Interface;
using Design.Patterns.Patterns.Creational.AbstractFactory.Interface;

namespace Design.Patterns.Patterns.Creational.AbstractFactory;

public class FoodFactory : IFoodFactory
{
    public IFood CreateFood(string foodType)
    {
        return foodType switch
        {
            "dog food" => new DogFood(),
            "cat food" => new CatFood(),
            "cow food" => new CowFood(),
            _ => throw new ArgumentException($"Invalid food type: {foodType}")
        };
    }
}