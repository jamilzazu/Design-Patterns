using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Behavioral.Command;

public class MakeSoundCommand : ICommand
{
    private readonly Animal _animal;

    public MakeSoundCommand(Animal animal)
    {
        _animal = animal;
    }

    public void Execute()
    {
        Console.WriteLine($"The {_animal.GetSpecie()} makes {_animal.MakeSound()}");
    }
}