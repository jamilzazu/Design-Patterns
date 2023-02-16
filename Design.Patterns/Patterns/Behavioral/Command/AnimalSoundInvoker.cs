namespace Design.Patterns.Patterns.Behavioral.Command;

public class AnimalSoundInvoker
{
    private readonly ICommand _makeSoundCommand;

    public AnimalSoundInvoker(ICommand makeSoundCommand)
    {
        _makeSoundCommand = makeSoundCommand;
    }

    public void MakeSound()
    {
        _makeSoundCommand.Execute();
    }
}