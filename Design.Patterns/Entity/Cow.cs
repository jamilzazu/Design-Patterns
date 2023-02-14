using Design.Patterns.Interface;

namespace Design.Patterns.Entity;

public class Cow : IAnimal
{
    public string MakeSound()
    {
        return "mooo";
    }
}