using Design.Patterns.Interface;

namespace Design.Patterns.Patterns.Creational.AbstractFactory.Interface;

public interface IFoodFactory
{
    IFood CreateFood(string foodType);
}