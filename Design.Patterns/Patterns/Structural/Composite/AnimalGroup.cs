using Design.Patterns.Entity;
using Design.Patterns.Interface;

namespace Design.Patterns.Patterns.Structural.Composite;

public class AnimalGroup : IAnimal
{
    private readonly List<Animal> _animals;

    public AnimalGroup()
    {
        _animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        _animals.Remove(animal);
    }

    public string MakeSound()
    {
        var sound = "";
        foreach (var animal in _animals)
        {
            sound += animal.MakeSound() + " ";
        }

        return sound;
    }
}