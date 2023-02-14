using Design.Patterns.Interface;

namespace Design.Patterns.Entity;

public class Cat : IAnimal
{
    public string MakeSound()
    {
        return "miau";
    }
}