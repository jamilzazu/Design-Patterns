using Design.Patterns.Interface;

namespace Design.Patterns.Entity;

public class Cow : IAnimal
{
    public string MakeSound()
    {
        return "mooo";
    }

    public string GetSpecie()
    {
        throw new NotImplementedException();
    }
}

public class CowFood : IFood
{
    public string Name => "cow food";
}