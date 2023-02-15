using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Structural.Facade;

public class AnimalFacade
{
    private readonly Animal _dog;
    private readonly Animal _cat;
    private readonly Animal _cow;

    public AnimalFacade()
    {
        _dog = new Animal("dog", new Dog());
        _cat = new Animal("cat", new Cat());
        _cow = new Animal("cow", new Cow());
    }

    public string GetDogSound()
    {
        return _dog.MakeSound();
    }

    public string GetCatSound()
    {
        return _cat.MakeSound();
    }

    public string GetCowSound()
    {
        return _cow.MakeSound();
    }
}