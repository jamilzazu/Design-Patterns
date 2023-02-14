using Design.Patterns.Behavioral.Interface;

namespace Design.Patterns.Behavioral.Entity;

public class Animal
{
    private readonly IAnimal animal;

    public Animal(string species, IAnimal animal)
    {
        this.animal = animal;
    }

    public string MakeSound()
    {
        return animal.MakeSound();
    }
}