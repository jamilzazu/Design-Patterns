using Design.Patterns.Interface;

namespace Design.Patterns.Entity;

public class Cat : IAnimal
{
    public string MakeSound()
    {
        return "miau";
    }
}

public class CatFood : IFood
{
    public string Name => "cat food";
}