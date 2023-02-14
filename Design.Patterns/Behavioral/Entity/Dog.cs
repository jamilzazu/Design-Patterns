using Design.Patterns.Behavioral.Interface;

namespace Design.Patterns.Behavioral.Entity;

public class Dog : IAnimal
{
    public string MakeSound()
    {
        return "auau";
    }
}
