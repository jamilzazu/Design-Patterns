using Design.Patterns.Interface;

namespace Design.Patterns.Entity;

public class Animal
{
    private readonly IAnimal _animal;
    private readonly string _specie;

    public Animal(string species, IAnimal animal)
    {
        _animal = animal;
        _specie = species;
    }

    public string MakeSound()
    {
        return _animal.MakeSound();
    }
    
    public string GetSpecie()
    {
        return _specie;
    }
}