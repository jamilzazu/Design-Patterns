using Design.Patterns.Interface;

namespace Design.Patterns.Entity;

public class Animal
{
    private readonly IAnimal _animal;

    public Animal(string species, IAnimal animal)
    {
        _animal = animal;
    }

    public string MakeSound()
    {
        return _animal.MakeSound();
    }
}