using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Behavioral.Visitor;

public class Visitor
{
    public Visitor()
    {
        Console.WriteLine("Visitor:");

        var animals = new List<AnimalVisitor>
        {
            new("dog", new Dog()),
            new("cat", new Cat()),
            new("cow", new Cow()),
            new("dog", new Dog())
        };

        var soundVisitor = new AnimalSoundVisitor();
        var countVisitor = new AnimalCountVisitor();

        foreach (var animal in animals)
        {
            animal.Accept(soundVisitor);
            animal.Accept(countVisitor);
        }

        Console.WriteLine($"Total number of animals: {countVisitor.Count}");
        Console.WriteLine();
    }
}