using Design.Patterns.Interface;

namespace Design.Patterns.Entity;

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