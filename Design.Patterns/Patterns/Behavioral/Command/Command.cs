using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Behavioral.Command;

public class Command
{
    public Command()
    {
        Console.WriteLine("Command:");

        var dog = new Animal("dog", new Cat());
        var cat = new Animal("cat", new Cat());
        var cow = new Animal("cow", new Cow());

        var dogMakeSoundCommand = new MakeSoundCommand(dog);
        var catMakeSoundCommand = new MakeSoundCommand(cat);
        var cowMakeSoundCommand = new MakeSoundCommand(cow);

        var dogSoundInvoker = new AnimalSoundInvoker(dogMakeSoundCommand);
        var catSoundInvoker = new AnimalSoundInvoker(catMakeSoundCommand);
        var cowSoundInvoker = new AnimalSoundInvoker(cowMakeSoundCommand);

        dogSoundInvoker.MakeSound();
        catSoundInvoker.MakeSound();
        cowSoundInvoker.MakeSound();
        
        Console.WriteLine();
    }
}