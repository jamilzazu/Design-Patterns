namespace Design.Patterns.Patterns.Creational.FactoryMethod;

public class FactoryMethod
{
    public FactoryMethod()
    {
        Console.WriteLine("FactoryMethod:");
        var dog = AnimalFactory.CreateAnimal("dog");
        var cat = AnimalFactory.CreateAnimal("cat");
        var cow = AnimalFactory.CreateAnimal("cow");
        Console.WriteLine($"The dog makes {dog.MakeSound()}");
        Console.WriteLine($"The cat makes {cat.MakeSound()}");
        Console.WriteLine($"The cow makes {cow.MakeSound()}");
    }
}