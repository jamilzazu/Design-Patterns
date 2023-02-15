using Design.Patterns.Patterns.Creational.AbstractFactory.Interface;

namespace Design.Patterns.Patterns.Creational.AbstractFactory;

public class AbstractFactory
{
    public AbstractFactory()
    {
        IAnimalFactory animalFactory = new AnimalFactory();
        IFoodFactory foodFactory = new FoodFactory();

        Console.WriteLine("AbstractFactory:");
        var dog = animalFactory.CreateAnimal("dog");
        var cat = animalFactory.CreateAnimal("cat");
        var cow = animalFactory.CreateAnimal("cow");
        var dogFood = foodFactory.CreateFood("dog food");
        var catFood = foodFactory.CreateFood("cat food");
        var cowFood = foodFactory.CreateFood("cow food");

        Console.WriteLine($"The dog makes {dog.MakeSound()} and eats {dogFood.Name}");
        Console.WriteLine($"The cat makes {cat.MakeSound()} and eats {catFood.Name}");
        Console.WriteLine($"The cow makes {cow.MakeSound()} and eats {cowFood.Name}");

        Console.WriteLine();
    }
}