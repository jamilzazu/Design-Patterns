namespace Design.Patterns.Patterns.Behavioral.Visitor;

public interface IAnimal : Interface.IAnimal
{
    void Accept(IAnimalVisitor visitor);
}