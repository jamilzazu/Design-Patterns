using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Creational.Builder;

public class Builder
{
    public Builder()
    {
        Console.WriteLine("Builder:");
        var dog = AnimalBuilder.Build("dog", new Dog());
        var cat = AnimalBuilder.Build("cat", new Cat());
        var cow = AnimalBuilder.Build("cow", new Cow());
        Console.WriteLine($"The dog makes {dog.MakeSound()}");
        Console.WriteLine($"The cat makes {cat.MakeSound()}");
        Console.WriteLine($"The cow makes {cow.MakeSound()}");
        Console.WriteLine();
    }
}