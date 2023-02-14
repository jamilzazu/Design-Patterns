using Design.Patterns.Entity;
using Design.Patterns.Interface;

namespace Design.Patterns.Patterns.Creational.FactoryMethod;

public static class AnimalFactory
{
    public static IAnimal CreateAnimal(string species)
    {
        return species switch
        {
            "dog" => new Dog(),
            "cat" => new Cat(),
            "cow" => new Cow(),
            _ => throw new ArgumentException($"Invalid species: {species}")
        };
    }
}