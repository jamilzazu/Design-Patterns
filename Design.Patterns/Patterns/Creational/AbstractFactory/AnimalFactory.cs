using Design.Patterns.Entity;
using Design.Patterns.Interface;
using Design.Patterns.Patterns.Creational.AbstractFactory.Interface;

namespace Design.Patterns.Patterns.Creational.AbstractFactory;

public class AnimalFactory : IAnimalFactory
{
    public IAnimal CreateAnimal(string species)
    {
        return species switch
        {
            "dog" => new Dog(),
            "cat" => new Cat(),
            "cow" => new Cow(),
            _ => throw new ArgumentException($"Invalid animal species: {species}")
        };
    }
}