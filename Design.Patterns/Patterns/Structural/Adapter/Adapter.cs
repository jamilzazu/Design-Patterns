using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Structural.Adapter;

public class Adapter
{
    public Adapter()
    {
        Console.WriteLine("Adapter:");

        var dog = new Animal("dog", new Dog());
        var cat = new Animal("cat", new Cat());
        var cow = new Animal("cow", new Cow());

        var thirdPartyAnimal = new ThirdPartyAnimalAdapter(new ThirdPartyAnimal());

        Console.WriteLine($"The dog makes {dog.MakeSound()}");
        Console.WriteLine($"The cat makes {cat.MakeSound()}");
        Console.WriteLine($"The cow makes {cow.MakeSound()}");
        Console.WriteLine($"The third-party animal makes {thirdPartyAnimal.MakeSound()}");
        Console.WriteLine();
    }
}