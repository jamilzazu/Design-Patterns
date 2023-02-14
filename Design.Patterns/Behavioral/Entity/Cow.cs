using Design.Patterns.Behavioral.Interface;

namespace Design.Patterns.Behavioral.Entity;

public class Cow : IAnimal
{
    public string MakeSound()
    {
        return "mooo";
    }
}