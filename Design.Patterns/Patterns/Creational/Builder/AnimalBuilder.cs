using Design.Patterns.Entity;
using Design.Patterns.Interface;

namespace Design.Patterns.Patterns.Creational.Builder;

public static class AnimalBuilder
{
    public static Animal Build(string species, IAnimal animal)
    {
        return new Animal(species, animal);
    }
}