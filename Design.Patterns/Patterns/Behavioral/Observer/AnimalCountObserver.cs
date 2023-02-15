namespace Design.Patterns.Patterns.Behavioral.Observer;

public class AnimalSoundObserver
{
    public static void AnimalSoundEventHandler(object sender, string sound)
    {
        Console.WriteLine($"The animal made the sound: {sound}");
    }
}