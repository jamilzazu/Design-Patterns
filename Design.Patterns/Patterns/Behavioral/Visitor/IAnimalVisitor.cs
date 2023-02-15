using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Behavioral.Visitor;

public interface IAnimalVisitor
{
    void Visit(Animal animal);
}