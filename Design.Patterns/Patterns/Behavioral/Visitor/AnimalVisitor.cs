using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Behavioral.Visitor;

public class AnimalVisitor : Animal, IAnimal
{
    public AnimalVisitor(string species, Interface.IAnimal animal) : base(species, animal)
    {
    }

    public void Accept(IAnimalVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class AnimalSoundVisitor : IAnimalVisitor
{
    public void Visit(Animal animal)
    {
        Console.WriteLine($"The {animal.GetType().Name.ToLower()} makes {animal.MakeSound()}");
    }
}

public class AnimalCountVisitor : IAnimalVisitor
{
    public int Count { get; private set; }

    public void Visit(Animal animal)
    {
        Count++;
    }
}