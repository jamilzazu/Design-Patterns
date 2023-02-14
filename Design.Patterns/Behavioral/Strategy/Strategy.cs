using Design.Patterns.Behavioral.Entity;

namespace Design.Patterns.Behavioral.Strategy;

public class Strategy
{
    public Strategy()
    {
        var dog = new Animal("dog", new Dog());
        var cat = new Animal("cat", new Cat());
        var cow = new Animal("cow", new Cow());
        Console.WriteLine("The dog makes " + dog.MakeSound());
        Console.WriteLine("The cat makes " + cat.MakeSound());
        Console.WriteLine("The cow makes " + cow.MakeSound());
    }
}