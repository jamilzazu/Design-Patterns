using Design.Patterns.Interface;

namespace Design.Patterns.Entity;

public class Cat : IAnimal
{
    public string MakeSound()
    {
        return "miau";
    }

    public string GetSpecie()
    {
        throw new NotImplementedException();
    }
}

public class CatFood : IFood
{
    public string Name => "cat food";
}