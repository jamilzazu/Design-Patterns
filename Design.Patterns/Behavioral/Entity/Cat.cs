using Design.Patterns.Behavioral.Interface;

namespace Design.Patterns.Behavioral.Entity;

public class Cat : IAnimal
{
    public string MakeSound()
    {
        return "miau";
    }
}