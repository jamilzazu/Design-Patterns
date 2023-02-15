using Design.Patterns.Interface;

namespace Design.Patterns.Patterns.Creational.AbstractFactory.Interface;

public interface IAnimalFactory
{
    IAnimal CreateAnimal(string species);
}