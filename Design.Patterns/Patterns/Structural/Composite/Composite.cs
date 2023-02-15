using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Structural.Composite;

public class Composite
{
    public Composite()
    {
        Console.WriteLine("Composite:");

        var dog = new Animal("dog", new Dog());
        var cat = new Animal("cat", new Cat());
        var cow = new Animal("cow", new Cow());

        var group = new AnimalGroup();
        group.AddAnimal(dog);
        group.AddAnimal(cat);
        group.AddAnimal(cow);

        Console.WriteLine($"The dog makes {dog.MakeSound()}");
        Console.WriteLine($"The cat makes {cat.MakeSound()}");
        Console.WriteLine($"The cow makes {cow.MakeSound()}");
        Console.WriteLine($"The group makes {group.MakeSound()}");

        Console.WriteLine();
    }
}